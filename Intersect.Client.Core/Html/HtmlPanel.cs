using System;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Input;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Framework.Graphics;
using Intersect.Client.Framework.GenericClasses;

namespace Intersect.Client.Html
{
    /// <summary>
    /// A Gwen.NET control that displays HTML content using Ultralight rendering.
    /// Extends ImagePanel to provide HTML content display with full input forwarding.
    /// </summary>
    public class HtmlPanel : ImagePanel
    {
        private HtmlRenderer? _htmlRenderer;
        private bool _disposed = false;
        private string _lastHtml = string.Empty;
        private string _lastUrl = string.Empty;
        
        /// <summary>
        /// The HTML renderer instance
        /// </summary>
        public HtmlRenderer? Renderer => _htmlRenderer;
        
        /// <summary>
        /// Gets or sets whether mouse events should be forwarded to the HTML content
        /// </summary>
        public bool ForwardMouseEvents { get; set; } = true;
        
        /// <summary>
        /// Gets or sets whether keyboard events should be forwarded to the HTML content
        /// </summary>
        public bool ForwardKeyboardEvents { get; set; } = true;
        
        /// <summary>
        /// Event fired when HTML content loading is complete
        /// </summary>
        public event Action? OnHtmlLoaded;
        
        /// <summary>
        /// Event fired when HTML content fails to load
        /// </summary>
        public event Action<string>? OnHtmlLoadFailed;
        
        /// <summary>
        /// Creates a new HTML panel
        /// </summary>
        /// <param name="parent">Parent control</param>
        public HtmlPanel(Base parent) : base(parent)
        {
            Initialize();
        }
        
        /// <summary>
        /// Initializes the HTML panel
        /// </summary>
        private void Initialize()
        {
            // Set up the panel to handle input events
            MouseInputEnabled = true;
            KeyboardInputEnabled = true;
            
            // Subscribe to input events
            Clicked += OnPanelClicked;
            // Note: MouseMoved and KeyPressed events might not be available on ImagePanel
            // Will handle these in Think() method instead
            
            // Initialize with empty HTML
            SetHtml("<html><body style='margin:0;padding:10px;font-family:Arial,sans-serif;background:#f0f0f0;'><h2>HTML Panel Ready</h2><p>Load content using SetHtml() or LoadUrl()</p></body></html>");
        }
        
        /// <summary>
        /// Sets the HTML content to display
        /// </summary>
        /// <param name="html">HTML content</param>
        /// <param name="baseUrl">Base URL for resolving relative resources</param>
        public void SetHtml(string html, string? baseUrl = null)
        {
            if (string.IsNullOrEmpty(html) || html == _lastHtml)
                return;
                
            _lastHtml = html;
            _lastUrl = string.Empty;
            
            CreateRendererIfNeeded();
            _htmlRenderer?.LoadHtml(html, baseUrl);
        }
        
        /// <summary>
        /// Loads a URL into the HTML panel
        /// </summary>
        /// <param name="url">URL to load</param>
        public void LoadUrl(string url)
        {
            if (string.IsNullOrEmpty(url) || url == _lastUrl)
                return;
                
            _lastUrl = url;
            _lastHtml = string.Empty;
            
            CreateRendererIfNeeded();
            _htmlRenderer?.LoadUrl(url);
        }
        
        /// <summary>
        /// Creates the HTML renderer if it doesn't exist or needs to be recreated
        /// </summary>
        private void CreateRendererIfNeeded()
        {
            var currentWidth = (int)Width;
            var currentHeight = (int)Height;
            
            // Skip if dimensions are invalid
            if (currentWidth <= 0 || currentHeight <= 0)
                return;
                
            // Skip if renderer exists and dimensions haven't changed
            if (_htmlRenderer != null && 
                _htmlRenderer.Width == currentWidth && 
                _htmlRenderer.Height == currentHeight)
                return;
                
            // Get game renderer from skin renderer
            var gameRenderer = Skin?.Renderer as IGameRenderer;
            
            if (gameRenderer == null)
            {
                Console.WriteLine("Warning: Could not get IGameRenderer for HTML rendering");
                return;
            }
            
            try
            {
                // Dispose old renderer
                _htmlRenderer?.Dispose();
                
                // Create new renderer with current dimensions
                _htmlRenderer = new HtmlRenderer(gameRenderer, currentWidth, currentHeight);
                
                // Set up event handlers
                _htmlRenderer.OnNeedsPaint += OnHtmlNeedsPaint;
                
                // Update the image panel texture
                UpdateTexture();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to create HTML renderer: {ex.Message}");
                OnHtmlLoadFailed?.Invoke(ex.Message);
            }
        }
        
        /// <summary>
        /// Updates the panel's texture with the rendered HTML content
        /// </summary>
        private void UpdateTexture()
        {
            if (_htmlRenderer?.Texture != null)
            {
                Texture = _htmlRenderer.Texture;
                Invalidate();
            }
        }
        
        /// <summary>
        /// Called when HTML content needs to be repainted
        /// </summary>
        private void OnHtmlNeedsPaint()
        {
            UpdateTexture();
        }
        
        /// <summary>
        /// Updates the HTML renderer and handles any repainting
        /// </summary>
        public override void Think()
        {
            base.Think();
            
            // Update HTML renderer
            _htmlRenderer?.Update();
            
            // Check if we need to create/recreate the renderer
            if (_htmlRenderer == null || 
                _htmlRenderer.Width != (int)Width || 
                _htmlRenderer.Height != (int)Height)
            {
                if (!string.IsNullOrEmpty(_lastHtml))
                {
                    CreateRendererIfNeeded();
                    if (_htmlRenderer != null)
                        _htmlRenderer.LoadHtml(_lastHtml);
                }
                else if (!string.IsNullOrEmpty(_lastUrl))
                {
                    CreateRendererIfNeeded();
                    if (_htmlRenderer != null)
                        _htmlRenderer.LoadUrl(_lastUrl);
                }
            }
        }
        
        #region Input Event Handlers
        
        /// <summary>
        /// Handles mouse click events
        /// </summary>
        private void OnPanelClicked(Base sender, MouseButtonState arguments)
        {
            if (ForwardMouseEvents && _htmlRenderer != null)
            {
                var localX = arguments.X - (int)X;
                var localY = arguments.Y - (int)Y;
                
                if (arguments.IsPressed)
                    _htmlRenderer.OnMouseDown(localX, localY, (int)arguments.MouseButton);
                else
                    _htmlRenderer.OnMouseUp(localX, localY, (int)arguments.MouseButton);
            }
        }
        
        /// <summary>
        /// Handles mouse movement events (placeholder - need to find the right event)
        /// </summary>
        private void OnPanelMouseMoved(Base sender, EventArgs arguments)
        {
            if (ForwardMouseEvents && _htmlRenderer != null)
            {
                // TODO: Get mouse position from event args when we find the right event type
                Console.WriteLine("[HtmlPanel] Mouse moved");
            }
        }
        
        /// <summary>
        /// Handles key press events (placeholder - need to find the right event)
        /// </summary>
        private void OnPanelKeyPressed(Base sender, EventArgs arguments)
        {
            if (ForwardKeyboardEvents && _htmlRenderer != null)
            {
                Console.WriteLine("[HtmlPanel] Key pressed");
            }
        }
        
        #endregion
        
        #region IDisposable Implementation
        
        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Unsubscribe from events
                    Clicked -= OnPanelClicked;
                    
                    _htmlRenderer?.Dispose();
                }
                _disposed = true;
            }
            
            base.Dispose(disposing);
        }
        
        #endregion
    }
}