using Blinkuz.Plugins.Tools.Networking.Packets.Client;
using Blinkuz.Plugins.Tools.Networking.Packets.Server;
using DiscordRPC_Plugin_Server.Configuration;
using Intersect.Logging;
using Intersect.Network;

namespace DiscordRPC_Plugin_Server.Networking.Handlers;

public class GetRichPresenceConfigPacketHandler: IPacketHandler<GetRichPresenceConfigPacket>
{
    public bool Handle(IPacketSender packetSender, GetRichPresenceConfigPacket packet)
    {
        Log.Info($"Received a {nameof(GetRichPresenceConfigPacket)} packet from the client!");
        
        var settings = PluginSettings.Settings;
        if (string.IsNullOrEmpty(settings.DiscordClientId) ||
            string.IsNullOrEmpty(settings.DetailsTemplate) ||
            string.IsNullOrEmpty(settings.StateTemplate) ||
            string.IsNullOrEmpty(settings.LargeImageKey) ||
            string.IsNullOrEmpty(settings.LargeImageText) ||
            string.IsNullOrEmpty(settings.SmallImageKey) ||
            string.IsNullOrEmpty(settings.SmallImageText))
        {
            Log.Error("Incomplete settings. Please complete the Discord Rich Presence configuration.");
            return false;
        }
        
        RichPresenceConfigPacket configPacket = new RichPresenceConfigPacket(
            settings.DiscordClientId,
            settings.DetailsTemplate,
            settings.StateTemplate,
            settings.Button1Label,
            settings.Button1Url,
            settings.Button2Label,
            settings.Button2Url,
            settings.LargeImageKey,
            settings.LargeImageText,
            settings.SmallImageKey,
            settings.SmallImageText
        );
        
        var packetSent = packetSender.Send(configPacket);
        if (packetSent)
        {
            Log.Info($"Sent a {nameof(RichPresenceConfigPacket)} packet to the client!");
        }
        else
        {
            Log.Error($"Failed to send a {nameof(RichPresenceConfigPacket)} packet to the client!");
        }
        
        return packetSent;
    }

    public bool Handle(IPacketSender packetSender, IPacket packet) => Handle(packetSender, packet as GetRichPresenceConfigPacket);
}