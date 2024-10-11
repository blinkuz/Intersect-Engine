using System.Runtime.Serialization;
using Intersect.Plugins;

namespace DiscordRPC_Plugin_Server.Configuration;

public class PluginSettings: PluginConfiguration
{
    public static PluginSettings Settings { get; set; }
    
    [OnDeserialized]
    internal void OnDeserializedMethod(StreamingContext context)
    {
    }
}