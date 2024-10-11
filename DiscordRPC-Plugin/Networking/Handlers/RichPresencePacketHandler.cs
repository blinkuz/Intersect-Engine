using DiscordRPC_Plugin_Server.Networking.Packets.Server;
using DiscordRPC_Plugin.Loggin;
using Intersect.Network;

namespace DiscordRPC_Plugin.Networking.Handlers;

public class RichPresencePacketHandler: IPacketHandler<RichPresenceConfig>
{
    public bool Handle(IPacketSender packetSender, RichPresenceConfig packet)
    {
        if (default == packetSender)
        {
            throw new ArgumentNullException(nameof(packetSender));
        }

        if (default == packet)
        {
            throw new ArgumentNullException(nameof(packet));
        }

        Logger.Write(LogLevel.Info, "Received server packet!");

        return true;
    }

    public bool Handle(IPacketSender packetSender, IPacket packet) => Handle(packetSender, packet as RichPresenceConfig);
}