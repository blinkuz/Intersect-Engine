using Intersect.Network.Packets.Server;
using System;
using Intersect.Client.Framework.Entities;
using Intersect.Enums;
using Intersect.Utilities;

namespace Intersect.Client.Entities
{
    public class Corpse : Entity
    {
        public const long TIME_TO_RESPAWN = 10000;
        public long TickCount { get; set; }

        public Corpse(Guid id, EntityPacket packet) : base(id, packet, EntityTypes.GlobalEntity)
        {
        }

        public Corpse(Guid id, Entity entityBase) : base(id, null, EntityTypes.GlobalEntity)
        {
            this.Id = id;
            this.X = entityBase.X;
            this.Y = entityBase.Y;
            this.Name = entityBase.Name;
            this.Sprite = entityBase.Sprite;
            this.Texture = entityBase.Texture;
            this.MapId = entityBase.MapId;
            this.SpriteAnimation = SpriteAnimations.Death;
            this.TickCount = Timing.Global.Milliseconds;
        }
    }
}
