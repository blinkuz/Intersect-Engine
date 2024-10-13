using Blinkuz.Plugins.Tools.Logging;
using Blinkuz.Plugins.Tools.Networking.Packets.Server;
using Intersect.Network;

namespace DiscordRPC_Plugin.Networking.Handlers;

public class RichPresencePacketHandler : IPacketHandler<RichPresenceConfigPacket>
{
    public bool Handle(IPacketSender packetSender, RichPresenceConfigPacket packet)
    {
        DiscordRichPresenceManager.Instance.Initialize(
            packet.DiscordClientId,
            packet.DetailsTemplate,
            packet.StateTemplate,
            packet.Button1Label,
            packet.Button1Url,
            packet.Button2Label,
            packet.Button2Url,
            packet.MaxPartySize,
            packet.LargeImageKey,
            packet.LargeImageText,
            packet.SmallImageKey,
            packet.SmallImageText
        );

        return true;
    }

    public bool Handle(IPacketSender packetSender, IPacket packet) => Handle(packetSender, packet as RichPresenceConfigPacket);
}