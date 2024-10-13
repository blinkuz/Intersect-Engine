using Blinkuz.Plugins.Tools.Logging;
using Blinkuz.Plugins.Tools.Networking.Packets.Client;
using Blinkuz.Plugins.Tools.Networking.Packets.Server;
using DiscordRPC_Plugin.Networking.Handlers;
using DiscordRPC_Plugin.Networking.Hooks;
using Intersect.Client.General;
using Intersect.Client.Plugins;
using Intersect.Client.Plugins.Interfaces;
using Intersect.Network.Packets.Server;
using Intersect.Plugins;
using Microsoft;

namespace DiscordRPC_Plugin;

public class PluginEntry: ClientPluginEntry
{
    public override void OnBootstrap([ValidatedNotNull] IPluginBootstrapContext context)
    {
        Logger.Context = context;
        Logger.WriteToConsole = true;
        Logger.Write(LogLevel.Info, "*======================================*");
        Logger.Write(LogLevel.Info, "*         DiscordRPC-Plugin            *");
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
    
        Logger.Write(LogLevel.Info, "Registering packet handlers...");
        if (!context.Packet.TryRegisterPacketHandler<RichPresencePacketHandler, RichPresenceConfigPacket>(out _))
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(RichPresenceConfigPacket)} packet handler.");
            Environment.Exit(-4);
        }

        if (!context.Packet.TryRegisterPacketPostHook<JoinGamePostHook, JoinGamePacket>(out _))
        {
            Logger.Write(LogLevel.Warning, $"Failed to register {nameof(JoinGamePacket)} packet post hook.");
            Environment.Exit(-5);
        }
    }
    
    public override void OnStart(IClientPluginContext context)
    {
        Logger.Write(LogLevel.Info,"DiscordRPC-Plugin started");
        context.Lifecycle.GameUpdate += HandleGameUpdate;
    }
    
    private void HandleGameUpdate([ValidatedNotNull] IClientPluginContext context, [ValidatedNotNull] GameUpdateArgs gameUpdateArgs)
    {
        if (gameUpdateArgs.State == GameStates.InGame)
        {
            DiscordRichPresenceManager.Instance.UpdatePresence(gameUpdateArgs.Player);
        }
    }

    public override void OnStop(IClientPluginContext context)
    {
        DiscordRichPresenceManager.Instance.Dispose();
    }
}