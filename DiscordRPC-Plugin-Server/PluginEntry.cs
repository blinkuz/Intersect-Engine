using DiscordRPC_Plugin_Server.Configuration;
using DiscordRPC_Plugin_Server.Networking.Handlers;
using DiscordRPC_Plugin_Server.Networking.Packets.Client;
using DiscordRPC_Plugin_Server.Networking.Packets.Server;
using Intersect.Plugins;
using Intersect.Server.Plugins;

namespace DiscordRPC_Plugin_Server;

public class PluginEntry: ServerPluginEntry
{
    public override void OnBootstrap(IPluginBootstrapContext context)
    {
        base.OnBootstrap(context);
        
        PluginSettings.Settings = context.GetTypedConfiguration<PluginSettings>();

        context.Logging.Application.Info(
            $@"{nameof(PluginEntry)}.{nameof(OnBootstrap)} writing to the application log!");

        context.Logging.Plugin.Info(
            $@"{nameof(PluginEntry)}.{nameof(OnBootstrap)} writing to the plugin log!");

        context.Logging.Plugin.Info("Registering packets...");
        if (!context.Packet.TryRegisterPacketType<GetRichPresenceConfig>())
        {
            context.Logging.Plugin.Error($"Failed to register {nameof(GetRichPresenceConfig)} packet.");
            Environment.Exit(-3);
        }

        if (!context.Packet.TryRegisterPacketType<RichPresenceConfig>())
        {
            context.Logging.Plugin.Error($"Failed to register {nameof(RichPresenceConfig)} packet.");
            Environment.Exit(-3);
        }

        context.Logging.Plugin.Info("Registering packet handlers...");
        if (!context.Packet.TryRegisterPacketHandler<GetRichPresenceConfigPacketHandler, GetRichPresenceConfig>(out _))
        {
            context.Logging.Plugin.Error($"Failed to register {nameof(GetRichPresenceConfigPacketHandler)} packet handler.");
            Environment.Exit(-4);
        }
    }
    
    public override void OnStart(IServerPluginContext context)
    {
        
    }

    public override void OnStop(IServerPluginContext context)
    {
        
    }
}