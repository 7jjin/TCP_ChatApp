﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_ChatApp.Models;

namespace TCP_ChatApp.Packets
{
    [Serializable]
    public class RegisterPacket : Packet
    {
        public bool success = false;

        public User user;

        public RegisterPacket(bool success)
        {
            type = PacketType.Register;
            this.success = success;
        }

        public RegisterPacket(User user)
        {
            type = PacketType.Register;
            this.user = user;
        }
    }
}