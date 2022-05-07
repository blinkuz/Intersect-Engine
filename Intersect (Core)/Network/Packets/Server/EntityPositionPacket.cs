﻿using System;

using Intersect.Enums;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class EntityPositionPacket : AbstractTimedPacket
    {
        //Parameterless Constructor for MessagePack
        public EntityPositionPacket()
        {
        }

        public EntityPositionPacket(
            Guid id,
            EntityTypes type,
            Guid mapId,
            byte x,
            byte y,
            byte direction,
            bool passable,
            bool hideName,
            bool running
        )
        {
            Id = id;
            Type = type;
            MapId = mapId;
            X = x;
            Y = y;
            Direction = direction;
            Passable = passable;
            HideName = hideName;
            Running = running;
        }

        [Key(3)]
        public Guid Id { get; set; }

        [Key(4)]
        public EntityTypes Type { get; set; }

        [Key(5)]
        public Guid MapId { get; set; }

        [Key(6)]
        public byte X { get; set; }

        [Key(7)]
        public byte Y { get; set; }

        [Key(8)]
        public byte Direction { get; set; }

        [Key(9)]
        public bool Passable { get; set; }

        [Key(10)]
        public bool HideName { get; set; }
        
        [Key(11)]
        public bool Running { get; set; }

    }

}
