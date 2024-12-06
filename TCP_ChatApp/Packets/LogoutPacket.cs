using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_ChatApp.Packets
{
    [Serializable]
    public class LogoutPacket : Packet
    {
        public LogoutPacket()
        {
            type = PacketType.Logout;
        }
    }
}
