using System;
using Intersect.Client.Framework.Html;
using Intersect.Client.Framework.Gwen.Control;

namespace Intersect.Client.Framework.Examples
{
    /// <summary>
    /// Example usage of the HTML UI integration in Intersect Engine.
    /// This class demonstrates how to create and use HTML panels within the existing Gwen.NET UI system.
    /// </summary>
    public static class HtmlUIExample
    {
        /// <summary>
        /// Creates a simple HTML panel with sample content
        /// </summary>
        /// <param name="parent">Parent Gwen control to attach the HTML panel to</param>
        /// <returns>Configured HTML panel ready for use</returns>
        public static HtmlPanel CreateSampleHtmlPanel(Base parent)
        {
            // Initialize HTML manager if not already done
            if (!HtmlManager.IsInitialized)
            {
                HtmlManager.Initialize();
            }
            
            // Create HTML panel
            var htmlPanel = new HtmlPanel(parent)
            {
                // Set panel dimensions
                Width = 400,
                Height = 300,
                
                // Enable input forwarding
                ForwardMouseEvents = true,
                ForwardKeyboardEvents = true
            };
            
            // Load sample HTML content
            var sampleHtml = @"
<!DOCTYPE html>
<html>
<head>
    <title>Intersect Game UI</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(135deg, #1e3c72 0%, #2a5298 100%);
            color: white;
            margin: 0;
            padding: 20px;
            min-height: calc(100vh - 40px);
        }
        
        .container {
            background: rgba(255, 255, 255, 0.1);
            border-radius: 15px;
            padding: 25px;
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.2);
        }
        
        .title {
            text-align: center;
            font-size: 24px;
            margin-bottom: 20px;
            text-shadow: 2px 2px 4px rgba(0,0,0,0.5);
        }
        
        .stats {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 15px;
            margin: 20px 0;
        }
        
        .stat-item {
            background: rgba(0, 0, 0, 0.3);
            padding: 15px;
            border-radius: 8px;
            text-align: center;
        }
        
        .stat-value {
            font-size: 20px;
            font-weight: bold;
            color: #4CAF50;
        }
        
        .stat-label {
            font-size: 12px;
            opacity: 0.8;
            margin-top: 5px;
        }
        
        .action-buttons {
            text-align: center;
            margin-top: 20px;
        }
        
        .game-button {
            background: linear-gradient(45deg, #4CAF50, #45a049);
            border: none;
            color: white;
            padding: 12px 24px;
            margin: 0 10px;
            border-radius: 6px;
            cursor: pointer;
            font-size: 14px;
            transition: all 0.3s ease;
        }
        
        .game-button:hover {
            transform: translateY(-2px);
            box-shadow: 0 4px 8px rgba(0,0,0,0.3);
        }
        
        .game-button:active {
            transform: translateY(0);
        }
        
        .info-panel {
            margin-top: 20px;
            padding: 15px;
            background: rgba(255, 255, 255, 0.05);
            border-radius: 8px;
            border-left: 4px solid #4CAF50;
        }
    </style>
</head>
<body>
    <div class='container'>
        <div class='title'>🎮 Game Interface</div>
        
        <div class='stats'>
            <div class='stat-item'>
                <div class='stat-value' id='health'>100</div>
                <div class='stat-label'>Health</div>
            </div>
            <div class='stat-item'>
                <div class='stat-value' id='mana'>75</div>
                <div class='stat-label'>Mana</div>
            </div>
            <div class='stat-item'>
                <div class='stat-value' id='level'>12</div>
                <div class='stat-label'>Level</div>
            </div>
            <div class='stat-item'>
                <div class='stat-value' id='gold'>1,250</div>
                <div class='stat-label'>Gold</div>
            </div>
        </div>
        
        <div class='action-buttons'>
            <button class='game-button' onclick='castSpell()'>Cast Spell</button>
            <button class='game-button' onclick='useItem()'>Use Item</button>
            <button class='game-button' onclick='showInventory()'>Inventory</button>
        </div>
        
        <div class='info-panel'>
            <strong>HTML UI Integration Active!</strong><br>
            This panel demonstrates HTML content running inside the Intersect Engine using the new UltralightNet integration.
        </div>
    </div>
    
    <script>
        // Sample JavaScript functionality
        let health = 100;
        let mana = 75;
        
        function castSpell() {
            if (mana >= 10) {
                mana -= 10;
                document.getElementById('mana').textContent = mana;
                console.log('Spell cast! Mana: ' + mana);
            } else {
                alert('Not enough mana!');
            }
        }
        
        function useItem() {
            if (health < 100) {
                health = Math.min(100, health + 25);
                document.getElementById('health').textContent = health;
                console.log('Health restored! Health: ' + health);
            } else {
                alert('Health is already full!');
            }
        }
        
        function showInventory() {
            alert('Inventory system would open here!');
        }
        
        // Simulate dynamic updates
        setInterval(() => {
            const now = new Date();
            // Could update time, stats, or other dynamic content
        }, 1000);
        
        console.log('HTML UI initialized successfully in Intersect Engine!');
    </script>
</body>
</html>";
            
            htmlPanel.SetHtml(sampleHtml);
            
            return htmlPanel;
        }
        
        /// <summary>
        /// Creates a notification-style HTML panel
        /// </summary>
        /// <param name="parent">Parent control</param>
        /// <param name="message">Notification message</param>
        /// <param name="type">Notification type (success, warning, error)</param>
        /// <returns>Configured notification panel</returns>
        public static HtmlPanel CreateNotificationPanel(Base parent, string message, string type = "info")
        {
            if (!HtmlManager.IsInitialized)
            {
                HtmlManager.Initialize();
            }
            
            var notificationPanel = new HtmlPanel(parent)
            {
                Width = 300,
                Height = 80,
                ForwardMouseEvents = true
            };
            
            var typeColors = new System.Collections.Generic.Dictionary<string, string>
            {
                ["success"] = "#4CAF50",
                ["warning"] = "#FF9800", 
                ["error"] = "#F44336",
                ["info"] = "#2196F3"
            };
            
            var color = typeColors.GetValueOrDefault(type, "#2196F3");
            
            var notificationHtml = $@"
<!DOCTYPE html>
<html>
<head>
    <style>
        body {{
            margin: 0;
            padding: 10px;
            font-family: Arial, sans-serif;
            background: linear-gradient(90deg, {color}, {color}dd);
            color: white;
            border-radius: 8px;
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 60px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.3);
        }}
        
        .notification {{
            text-align: center;
            font-weight: bold;
            text-shadow: 1px 1px 2px rgba(0,0,0,0.5);
        }}
        
        .close-btn {{
            position: absolute;
            top: 5px;
            right: 10px;
            background: none;
            border: none;
            color: white;
            cursor: pointer;
            font-size: 16px;
        }}
    </style>
</head>
<body>
    <div class='notification'>
        {System.Web.HttpUtility.HtmlEncode(message)}
        <button class='close-btn' onclick='window.close()'>×</button>
    </div>
</body>
</html>";
            
            notificationPanel.SetHtml(notificationHtml);
            
            return notificationPanel;
        }
        
        /// <summary>
        /// Creates a minimap-style HTML panel
        /// </summary>
        /// <param name="parent">Parent control</param>
        /// <returns>Configured minimap panel</returns>
        public static HtmlPanel CreateMinimapPanel(Base parent)
        {
            if (!HtmlManager.IsInitialized)
            {
                HtmlManager.Initialize();
            }
            
            var minimapPanel = new HtmlPanel(parent)
            {
                Width = 200,
                Height = 200,
                ForwardMouseEvents = true
            };
            
            var minimapHtml = @"
<!DOCTYPE html>
<html>
<head>
    <style>
        body {
            margin: 0;
            padding: 10px;
            background: rgba(0, 0, 0, 0.8);
            border: 2px solid #333;
            border-radius: 10px;
            font-family: Arial, sans-serif;
            color: white;
        }
        
        .minimap {
            width: 180px;
            height: 180px;
            background: #1a1a1a;
            border: 1px solid #555;
            position: relative;
            border-radius: 5px;
        }
        
        .player-dot {
            width: 6px;
            height: 6px;
            background: #4CAF50;
            border-radius: 50%;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            box-shadow: 0 0 10px #4CAF50;
        }
        
        .poi {
            width: 4px;
            height: 4px;
            background: #FF5722;
            border-radius: 50%;
            position: absolute;
        }
        
        .title {
            text-align: center;
            font-size: 12px;
            margin-bottom: 5px;
            color: #ccc;
        }
    </style>
</head>
<body>
    <div class='title'>MINIMAP</div>
    <div class='minimap'>
        <div class='player-dot'></div>
        <div class='poi' style='top: 30%; left: 20%;'></div>
        <div class='poi' style='top: 70%; left: 80%;'></div>
        <div class='poi' style='top: 20%; left: 60%;'></div>
    </div>
    
    <script>
        // Animate player dot
        let angle = 0;
        const playerDot = document.querySelector('.player-dot');
        
        setInterval(() => {
            angle += 0.1;
            const x = 90 + Math.cos(angle) * 20;
            const y = 90 + Math.sin(angle) * 20;
            playerDot.style.left = x + 'px';
            playerDot.style.top = y + 'px';
        }, 100);
    </script>
</body>
</html>";
            
            minimapPanel.SetHtml(minimapHtml);
            
            return minimapPanel;
        }
    }
}