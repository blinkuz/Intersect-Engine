using DiscordRPC_Plugin_Server.Networking.Packets.Client;
using DiscordRPC_Plugin_Server.Networking.Packets.Server;
using DiscordRPC_Plugin.Loggin;
using DiscordRPC_Plugin.Networking.Handlers;
using Intersect.Client.General;
using Intersect.Client.Plugins;
using Intersect.Client.Plugins.Interfaces;
using Intersect.Plugins;
using Microsoft;

namespace DiscordRPC_Plugin;

public class PluginEntry: ClientPluginEntry
{
    private DiscordRichPresenceManager _discordManager;
    public override void OnBootstrap([ValidatedNotNull] IPluginBootstrapContext context)
    {
        Logger.Context = context;
        Logger.Write(LogLevel.Info, "*======================================*");
        Logger.Write(LogLevel.Info, "*         DiscordRPC-Plugin            *");
        Logger.Write(LogLevel.Info, "*======================================*");
        Logger.Write(LogLevel.Info, String.Format("Name    : {0}", context.Manifest.Name));
        Logger.Write(LogLevel.Info, String.Format("Version : {0}", context.Manifest.Version));
        Logger.Write(LogLevel.Info, String.Format("Author  : {0}", context.Manifest.Authors));
        Logger.Write(LogLevel.Info, String.Format("Homepage: {0}", context.Manifest.Homepage));
        Logger.Write(LogLevel.Info, "---");
        
        Logger.Write(LogLevel.Info, "Registering packets...");
        if (!context.Packet.TryRegisterPacketType<GetRichPresenceConfig>())
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(GetRichPresenceConfig)} packet.");
            Environment.Exit(-3);
        }
        
        if (!context.Packet.TryRegisterPacketType<RichPresenceConfig>())
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(RichPresenceConfig)} packet.");
            Environment.Exit(-3);
        }
        
        Logger.Write(LogLevel.Info, "Registering packet handlers...");
        if (!context.Packet.TryRegisterPacketHandler<RichPresencePacketHandler, RichPresenceConfig>(out _))
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(RichPresenceConfig)} packet handler.");
            Environment.Exit(-4);
        }
    }
    
    public override void OnStart(IClientPluginContext context)
    {
        _discordManager = new DiscordRichPresenceManager("1079638956368482314");    
        Logger.Write(LogLevel.Info,"DiscordRPC-Plugin started");
        context.Lifecycle.GameUpdate += HandleGameUpdate;
    }
    
    private void HandleGameUpdate([ValidatedNotNull] IClientPluginContext context, [ValidatedNotNull] GameUpdateArgs gameUpdateArgs)
    {
        if (gameUpdateArgs.State == GameStates.InGame)
        {
            _discordManager.UpdatePresence(gameUpdateArgs.Player);
        }
    }

    public override void OnStop(IClientPluginContext context)
    {
        _discordManager.Dispose();
    }
}