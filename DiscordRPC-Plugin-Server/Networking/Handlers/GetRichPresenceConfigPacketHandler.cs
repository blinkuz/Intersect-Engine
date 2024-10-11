using DiscordRPC_Plugin_Server.Networking.Packets.Client;
using Intersect.Logging;
using Intersect.Network;

namespace DiscordRPC_Plugin_Server.Networking.Handlers;

public class GetRichPresenceConfigPacketHandler: IPacketHandler<GetRichPresenceConfig>
{
    public bool Handle(IPacketSender packetSender, GetRichPresenceConfig packet)
    {
        Log.Info($"Received example plugin response from the client: ");
        return true;
    }

    public bool Handle(IPacketSender packetSender, IPacket packet) => Handle(packetSender, packet as GetRichPresenceConfig);
}