using System.Runtime.Serialization;
using Intersect.Plugins;

namespace DiscordRPC_Plugin_Server.Configuration;

public class PluginSettings: PluginConfiguration
{
    public static PluginSettings Settings { get; set; }
    
    public string DiscordClientId { get; set; }
    public string DetailsTemplate { get; set; }
    public string StateTemplate { get; set; }
    public string Button1Label { get; set; }
    public string Button1Url { get; set; }
    public string Button2Label { get; set; }
    public string Button2Url { get; set; }
    public string LargeImageKey { get; set; }
    public string LargeImageText { get; set; }
    public string SmallImageKey { get; set; }
    public string SmallImageText { get; set; }
    
    [OnDeserialized]
    internal void OnDeserializedMethod(StreamingContext context)
    {
    }
}