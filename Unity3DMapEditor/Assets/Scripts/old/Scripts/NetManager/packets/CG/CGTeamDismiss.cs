﻿using System;

using Network;

namespace Network.Packets
{
    public class CGTeamDismiss : PacketBase
    {
        public override short getPacketID()
        {
            return (short)PACKET_DEFINE.PACKET_CG_TEAMDISMISS;
        }

        public override int getSize()
        {
            return sizeof(uint);
        }

        public override bool readFromBuff(ref NetInputBuffer buff)
        {
            throw new NotImplementedException();
        }
        public override int writeToBuff(ref NetOutputBuffer buff)
        {
            buff.WriteUint(m_GUID);

            return NET_DEFINE.PACKET_HEADER_SIZE + getSize();
        }

        public uint GUID
        {
            set { m_GUID = value; }
        }

        uint m_GUID;
    }

    public class CGTeamDismissFactory : PacketFactory
    {
        public override PacketBase CreatePacket() { return new CGTeamDismiss(); }
        public override int GetPacketID() { return (short)PACKET_DEFINE.PACKET_CG_TEAMDISMISS; }
        public override int GetPacketMaxSize()
        {
            return sizeof(uint);
        }
    }
}