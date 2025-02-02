using Blinkuz.Plugins.Tools.Logging;
using Blinkuz.Plugins.Tools.Networking.Packets.Client;
using Blinkuz.Plugins.Tools.Networking.Packets.Server;
using DiscordRPC_Plugin_Server.Configuration;
using DiscordRPC_Plugin_Server.Networking.Handlers;
using Intersect.Plugins;
using Intersect.Server.Plugins;

namespace DiscordRPC_Plugin_Server;

public class PluginEntry: ServerPluginEntry
{
    public override void OnBootstrap(IPluginBootstrapContext context)
    {
        base.OnBootstrap(context);
        Logger.Context = context;
        Logger.WriteToConsole = true;

        PluginSettings.Settings = context.GetTypedConfiguration<PluginSettings>();
    
        Logger.Write(LogLevel.Info, "*======================================*");
        Logger.Write(LogLevel.Info, "*         DiscordRPC-Plugin-Server     *");
        Logger.Write(LogLevel.Info, "*======================================*");
        Logger.Write(LogLevel.Info, String.Format("Name    : {0}", context.Manifest.Name));
        Logger.Write(LogLevel.Info, String.Format("Version : {0}", context.Manifest.Version));
        Logger.Write(LogLevel.Info, String.Format("Author  : {0}", context.Manifest.Authors));
        Logger.Write(LogLevel.Info, String.Format("Homepage: {0}", context.Manifest.Homepage));
        Logger.Write(LogLevel.Info, "---");
    
        Logger.Write(LogLevel.Info, "Registering packets...");
        if (!context.Packet.TryRegisterPacketType<GetRichPresenceConfigPacket>())
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(GetRichPresenceConfigPacket)} packet.");
            Environment.Exit(-3);
        }

        if (!context.Packet.TryRegisterPacketType<RichPresenceConfigPacket>())
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(RichPresenceConfigPacket)} packet.");
            Environment.Exit(-3);
        }

        Logger.Write(LogLevel.Info,"Registering packet handlers...");
        if (!context.Packet.TryRegisterPacketHandler<GetRichPresenceConfigPacketHandler, GetRichPresenceConfigPacket>(out _))
        {
            Logger.Write(LogLevel.Error,$"Failed to register {nameof(GetRichPresenceConfigPacketHandler)} packet handler.");
            Environment.Exit(-4);
        }
    }
    
    public override void OnStart(IServerPluginContext context)
    {
        Logger.Write(LogLevel.Info,"DiscordRPC-Plugin-Server started");
    }

    public override void OnStop(IServerPluginContext context)
    {
        
    }
}