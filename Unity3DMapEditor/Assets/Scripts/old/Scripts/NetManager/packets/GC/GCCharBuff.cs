﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Network;
using Network.Handlers;
using UnityEngine;
namespace Network.Packets
{
    public class GCCharBuff : PacketBase
    {
        public override bool readFromBuff(ref NetInputBuffer buff)
        {
            if (buff.ReadInt(ref m_nReceiverID) != sizeof(int)) return false;
            if (buff.ReadShort(ref m_nBuffID) != sizeof(short)) return false;
            if (buff.ReadInt(ref m_bEnable) != sizeof(int)) return false;
            if (m_bEnable != 0)
            {
                if (buff.ReadInt(ref m_nSenderID) != sizeof(int)) return false;
                if (buff.ReadShort(ref m_nSkillID) != sizeof(short)) return false;
                if (buff.ReadInt(ref m_nSenderLogicCount) != sizeof(int)) return false;
                if (buff.ReadUint(ref m_nSN) != sizeof(uint)) return false;
            }
            
            return true;
        }
        public override int writeToBuff(ref NetOutputBuffer buff)
        {
            buff.WriteInt(m_nReceiverID);
            buff.WriteShort(m_nBuffID);
            buff.WriteInt(m_bEnable);
            if (m_bEnable != 0)
            {
                buff.WriteInt(m_nSenderID);
                buff.WriteShort(m_nSkillID);
                buff.WriteInt(m_nSenderLogicCount);
                buff.WriteUint(m_nSN);
            }
            return NET_DEFINE.PACKET_HEADER_SIZE + getSize();
        }

        public override short getPacketID()
        {
            return (short)PACKET_DEFINE.PACKET_GC_CHAR_BUFF;
        }

        public override int getSize()
        {
            if (m_bEnable != 0)
            {
                return sizeof(int) * 4 + sizeof(short) * 2 + sizeof(uint);
            }
            else
            {
                return sizeof(int) *2+ sizeof(short);
            }
        }

        public int RecieverID
        {
            get { return this.m_nReceiverID; }
            set { m_nReceiverID = value; }
        }

        public int SenderID
        {
            get { return this.m_nSenderID; }
            set { m_nSenderID = value; }
        }

        public int SenderLogicCount
        {
            get { return this.m_nSenderLogicCount; }
            set { m_nSenderLogicCount = value; }
        }

        public short BuffID
        {
            get { return this.m_nBuffID; }
            set { m_nBuffID = value; }
        }

        public short SkillID
        {
            get { return this.m_nSkillID; }
            set { m_nSkillID = value; }
        }

        public int Enable
        {
            get { return this.m_bEnable; }
            set { m_bEnable = value; }
        }

        public uint SN
        {
            get { return this.m_nSN; }
            set { m_nSN = value; }
        }

        int m_nReceiverID;			// 效果接受者的ID
        int m_nSenderID;		// 效果施放者的ID
        short m_nBuffID;		// 特效数据的ID(索引)
        short m_nSkillID;		// 技能的资源ID	
        int m_bEnable;			// 是效果生效消息还是
        int  m_nSenderLogicCount;		//效果发起者的逻辑计数
        uint m_nSN;				//持续性效果的序列号(用于识别)
    };

    public class GCCharBuffFactory : PacketFactory
    {
        public override PacketBase CreatePacket() { return new GCCharBuff(); }
        public override int GetPacketID() { return (short)PACKET_DEFINE.PACKET_GC_CHAR_BUFF; }
        public override int GetPacketMaxSize()
        {
            return sizeof(int) * 4 + sizeof(short) * 2 + sizeof(uint);
        }
    };
}