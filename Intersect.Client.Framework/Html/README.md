# HTML UI Integration for Intersect Engine

This document describes the HTML UI integration that allows rendering HTML content within the Intersect Engine using UltralightNet.

## Overview

The HTML UI integration provides the ability to create dynamic, interactive UI elements using HTML, CSS, and JavaScript within the existing Gwen.NET-based interface system. This enables developers to create modern, responsive UI components while maintaining compatibility with the existing game architecture.

## Architecture

### Core Components

1. **HtmlRenderer**: Manages the actual HTML content rendering using UltralightNet (currently placeholder implementation)
2. **HtmlPanel**: A Gwen.NET control that hosts HTML content and forwards input events
3. **HtmlManager**: Centralized management system for HTML renderers and resources

### Integration Points

- **Gwen.NET Compatibility**: HTML panels extend ImagePanel to integrate seamlessly with existing UI
- **MonoGame Integration**: Uses IGameRenderer abstraction for texture management
- **Input Forwarding**: Mouse and keyboard events are forwarded from Gwen controls to HTML content
- **Resource Management**: Automatic creation and management of HTML content directories

## Usage

### Basic Setup

```csharp
using Intersect.Client.Framework.Html;

// Initialize the HTML manager (typically done once at startup)
HtmlManager.Initialize();

// Create an HTML panel within an existing Gwen control
var htmlPanel = new HtmlPanel(parentControl)
{
    Width = 400,
    Height = 300,
    ForwardMouseEvents = true,
    ForwardKeyboardEvents = true
};

// Load HTML content
htmlPanel.SetHtml(@"
<html>
<body style='background: #f0f0f0; font-family: Arial;'>
    <h1>Hello from HTML!</h1>
    <button onclick='alert(""Button clicked!"")'>Click Me</button>
</body>
</html>");
```

### Loading External URLs

```csharp
// Load content from a URL
htmlPanel.LoadUrl("https://example.com");

// Load local HTML files
htmlPanel.LoadUrl("file:///path/to/local/file.html");
```

### Example Usage Patterns

See `HtmlUIExample.cs` for comprehensive examples including:

- **Game Interface Panel**: Character stats, action buttons, interactive elements
- **Notification System**: Toast-style notifications with different types
- **Minimap Component**: Animated minimap with dynamic content

## Configuration

### Resource Directory

By default, HTML resources are stored in `Content/Html/` relative to the application directory. This can be customized:

```csharp
HtmlManager.Initialize("/custom/path/to/html/resources");
```

### Input Event Forwarding

Control which types of input events are forwarded to HTML content:

```csharp
var htmlPanel = new HtmlPanel(parent)
{
    ForwardMouseEvents = true,    // Enable mouse interaction
    ForwardKeyboardEvents = false // Disable keyboard input
};
```

## Current Implementation Status

### ✅ Completed Features

- [x] Basic HTML panel integration with Gwen.NET
- [x] Resource management and initialization
- [x] Input event forwarding structure
- [x] Comprehensive test coverage
- [x] Example implementations and documentation
- [x] Compatible with existing Intersect Engine architecture

### 🚧 Placeholder Implementation

The current implementation uses placeholder classes for the actual HTML rendering. The structure is in place for UltralightNet integration, but actual HTML rendering is not yet functional.

### 🔄 Planned Features

- [ ] Full UltralightNet integration for actual HTML rendering
- [ ] JavaScript API bridging between game and HTML content
- [ ] Advanced input handling (scroll, touch, etc.)
- [ ] Performance optimizations (dirty rectangle updates, caching)
- [ ] CSS/HTML template system for common UI patterns

## Technical Details

### CPU Rendering Mode

The integration uses CPU rendering via BitmapSurface as UltralightNet's GPUDriver is not currently supported in the C# bindings. This approach:

- Renders HTML content to a CPU-accessible bitmap
- Converts bitmap data to MonoGame Texture2D
- Displays texture within Gwen.NET ImagePanel

### Memory Management

- HTML renderers are automatically disposed when panels are destroyed
- Resource cleanup is handled by HtmlManager
- Texture memory is managed through the existing IGameTexture system

### Performance Considerations

- Updates only occur when content changes (dirty rectangle optimization planned)
- Multiple HTML panels can share rendering resources
- Background rendering minimizes impact on main game thread

## Troubleshooting

### Common Issues

1. **HTML content not displaying**: Ensure HtmlManager.Initialize() is called before creating panels
2. **Input events not working**: Check ForwardMouseEvents/ForwardKeyboardEvents properties
3. **Resource loading failures**: Verify HTML content directory exists and is accessible

### Debugging

Enable console logging to see HTML manager operations:

```csharp
// HTML manager operations are logged to console
// Look for messages starting with "[HtmlManager]" and "[HtmlRenderer]"
```

## Examples

### Simple Game Panel

```csharp
var gamePanel = HtmlUIExample.CreateSampleHtmlPanel(parentControl);
// Creates a complete game interface with stats, buttons, and styling
```

### Notification System

```csharp
var notification = HtmlUIExample.CreateNotificationPanel(
    parentControl, 
    "Level up!", 
    "success"
);
// Creates a styled notification panel
```

### Dynamic Minimap

```csharp
var minimap = HtmlUIExample.CreateMinimapPanel(parentControl);
// Creates an animated minimap with player position tracking
```

## Integration with Game Logic

### Event Handling

HTML panels can trigger game events through the parent Gwen control system:

```csharp
htmlPanel.OnHtmlLoaded += () => {
    // HTML content finished loading
};

htmlPanel.OnHtmlLoadFailed += (error) => {
    // Handle loading errors
};
```

### Dynamic Content Updates

Update HTML content dynamically based on game state:

```csharp
// Update player stats in HTML
var newHtml = $@"
<div>Health: {player.Health}</div>
<div>Mana: {player.Mana}</div>";

htmlPanel.SetHtml(newHtml);
```

## Future Enhancements

The HTML UI integration is designed to be extensible. Future enhancements may include:

- **JavaScript Bridge**: Two-way communication between game and HTML
- **Template System**: Reusable HTML templates for common UI patterns
- **Animation Support**: Hardware-accelerated CSS animations
- **WebGL Integration**: 3D content within HTML panels
- **Responsive Design**: Automatic scaling for different screen sizes

## Contributing

When contributing to the HTML UI integration:

1. Maintain compatibility with existing Gwen.NET architecture
2. Follow the established patterns for resource management
3. Add comprehensive tests for new functionality
4. Update documentation for any API changes
5. Consider performance implications of changes

For questions or issues, please refer to the main Intersect Engine documentation or submit issues through the project's issue tracker.