using Blinkuz.Plugins.Tools.Networking.Packets.Client;
using Intersect.Logging;
using Intersect.Network;
using Intersect.Network.Packets.Server;

namespace DiscordRPC_Plugin.Networking.Hooks;

public class JoinGamePostHook: IPacketHandler<JoinGamePacket>
{
    public bool Handle(IPacketSender packetSender, JoinGamePacket packet)
    {
        var packetSent = packetSender.Send(new GetRichPresenceConfigPacket());
        if (!packetSent)
        {
            Log.Error("Failed to send a message to the client!");
        }

        return packetSent;
    }

    public bool Handle(IPacketSender packetSender, IPacket packet) => Handle(packetSender, packet as JoinGamePacket);
}