using System;
using System.Collections.Generic;
using System.IO;
using Intersect.Client.Framework.Graphics;

namespace Intersect.Client.Framework.Html
{
    /// <summary>
    /// Manages multiple Ultralight instances and provides both AppCore and headless rendering modes.
    /// This is the primary interface for HTML UI integration in Intersect Engine.
    /// </summary>
    public static class HtmlManager
    {
        private static bool _initialized = false;
        private static readonly Dictionary<string, HtmlRenderer> _renderers = new();
        private static readonly object _lock = new object();
        
        /// <summary>
        /// Gets whether the HTML manager has been initialized
        /// </summary>
        public static bool IsInitialized => _initialized;
        
        /// <summary>
        /// Event fired when a renderer encounters an error
        /// </summary>
        public static event Action<string, Exception>? OnRendererError;
        
        /// <summary>
        /// Initializes the HTML manager. Must be called before using any HTML functionality.
        /// </summary>
        /// <param name="resourcePath">Path to web resources (HTML, CSS, JS files)</param>
        public static void Initialize(string? resourcePath = null)
        {
            if (_initialized)
                return;
                
            lock (_lock)
            {
                if (_initialized)
                    return;
                    
                try
                {
                    // Set up resource path - default to game content directory
                    var defaultResourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content", "Html");
                    var finalResourcePath = resourcePath ?? defaultResourcePath;
                    
                    // Ensure resource directory exists
                    if (!Directory.Exists(finalResourcePath))
                    {
                        Directory.CreateDirectory(finalResourcePath);
                        
                        // Create a default index.html for testing
                        var defaultHtml = @"<!DOCTYPE html>
<html>
<head>
    <title>Intersect HTML UI</title>
    <style>
        body { 
            font-family: Arial, sans-serif; 
            margin: 20px; 
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            text-align: center;
        }
        .container {
            background: rgba(255,255,255,0.1);
            padding: 20px;
            border-radius: 10px;
            backdrop-filter: blur(10px);
        }
        .button {
            background: #4CAF50;
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 5px;
        }
        .button:hover {
            background: #45a049;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h1>🚀 Intersect Engine HTML UI</h1>
        <p>HTML rendering is now active!</p>
        <button class='button' onclick='alert(""Hello from HTML!"")'>Click Me!</button>
        <p><small>Powered by UltralightNet (Placeholder Mode)</small></p>
    </div>
    <script>
        console.log('HTML UI initialized successfully');
        
        function updateTime() {
            const now = new Date();
            const timeElement = document.getElementById('time');
            if (timeElement) {
                timeElement.textContent = now.toLocaleTimeString();
            }
        }
        
        // Add time display
        document.addEventListener('DOMContentLoaded', function() {
            const container = document.querySelector('.container');
            const timeDiv = document.createElement('div');
            timeDiv.innerHTML = '<p>Current Time: <span id=""time""></span></p>';
            container.appendChild(timeDiv);
            
            updateTime();
            setInterval(updateTime, 1000);
        });
    </script>
</body>
</html>";
                        
                        File.WriteAllText(Path.Combine(finalResourcePath, "index.html"), defaultHtml);
                    }
                    
                    _initialized = true;
                    
                    Console.WriteLine($"[HtmlManager] Initialized with resource path: {finalResourcePath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[HtmlManager] Failed to initialize: {ex.Message}");
                    OnRendererError?.Invoke("Initialization", ex);
                    throw new InvalidOperationException("Failed to initialize HTML manager", ex);
                }
            }
        }
        
        /// <summary>
        /// Creates a new HTML renderer with the specified identifier and dimensions
        /// </summary>
        /// <param name="id">Unique identifier for the renderer</param>
        /// <param name="gameRenderer">Game renderer for texture creation</param>
        /// <param name="width">Width in pixels</param>
        /// <param name="height">Height in pixels</param>
        /// <returns>The created HTML renderer</returns>
        public static HtmlRenderer CreateRenderer(string id, IGameRenderer gameRenderer, int width, int height)
        {
            if (!_initialized)
                throw new InvalidOperationException("HTML manager must be initialized before creating renderers");
                
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("Renderer ID cannot be null or empty", nameof(id));
                
            lock (_lock)
            {
                // Remove existing renderer with same ID
                if (_renderers.ContainsKey(id))
                {
                    _renderers[id].Dispose();
                    _renderers.Remove(id);
                }
                
                try
                {
                    var renderer = new HtmlRenderer(gameRenderer, width, height);
                    _renderers[id] = renderer;
                    
                    Console.WriteLine($"[HtmlManager] Created renderer '{id}' ({width}x{height})");
                    return renderer;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[HtmlManager] Failed to create renderer '{id}': {ex.Message}");
                    OnRendererError?.Invoke(id, ex);
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Gets an existing HTML renderer by ID
        /// </summary>
        /// <param name="id">Renderer identifier</param>
        /// <returns>The renderer, or null if not found</returns>
        public static HtmlRenderer? GetRenderer(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;
                
            lock (_lock)
            {
                return _renderers.TryGetValue(id, out var renderer) ? renderer : null;
            }
        }
        
        /// <summary>
        /// Removes and disposes a renderer
        /// </summary>
        /// <param name="id">Renderer identifier</param>
        /// <returns>True if the renderer was found and removed</returns>
        public static bool RemoveRenderer(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;
                
            lock (_lock)
            {
                if (_renderers.TryGetValue(id, out var renderer))
                {
                    renderer.Dispose();
                    _renderers.Remove(id);
                    Console.WriteLine($"[HtmlManager] Removed renderer '{id}'");
                    return true;
                }
                return false;
            }
        }
        
        /// <summary>
        /// Updates all active HTML renderers
        /// </summary>
        public static void UpdateAll()
        {
            if (!_initialized)
                return;
                
            lock (_lock)
            {
                foreach (var kvp in _renderers)
                {
                    try
                    {
                        kvp.Value.Update();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[HtmlManager] Error updating renderer '{kvp.Key}': {ex.Message}");
                        OnRendererError?.Invoke(kvp.Key, ex);
                    }
                }
            }
        }
        
        /// <summary>
        /// Gets the number of active renderers
        /// </summary>
        public static int RendererCount
        {
            get
            {
                lock (_lock)
                {
                    return _renderers.Count;
                }
            }
        }
        
        /// <summary>
        /// Gets all renderer IDs
        /// </summary>
        public static string[] GetRendererIds()
        {
            lock (_lock)
            {
                var ids = new string[_renderers.Count];
                _renderers.Keys.CopyTo(ids, 0);
                return ids;
            }
        }
        
        /// <summary>
        /// Creates an HTML panel with automatic renderer management
        /// </summary>
        /// <param name="parent">Parent Gwen control</param>
        /// <param name="id">Unique identifier (auto-generated if null)</param>
        /// <returns>Configured HTML panel</returns>
        public static HtmlPanel CreatePanel(Gwen.Control.Base parent, string? id = null)
        {
            if (!_initialized)
                Initialize();
                
            id ??= $"html_panel_{Guid.NewGuid():N}";
            
            var panel = new HtmlPanel(parent);
            
            // The panel will create its own renderer when needed
            return panel;
        }
        
        /// <summary>
        /// Cleans up all resources and shuts down the HTML manager
        /// </summary>
        public static void Shutdown()
        {
            if (!_initialized)
                return;
                
            lock (_lock)
            {
                Console.WriteLine("[HtmlManager] Shutting down...");
                
                // Dispose all renderers
                foreach (var kvp in _renderers)
                {
                    try
                    {
                        kvp.Value.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[HtmlManager] Error disposing renderer '{kvp.Key}': {ex.Message}");
                    }
                }
                
                _renderers.Clear();
                _initialized = false;
                
                Console.WriteLine("[HtmlManager] Shutdown complete");
            }
        }
    }
}