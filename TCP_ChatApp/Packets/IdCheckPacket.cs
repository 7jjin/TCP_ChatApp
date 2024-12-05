using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_ChatApp.Packets
{
    [Serializable]
    public class IdCheckPacket : Packet
    {
        public bool success {  get; set; }
        public string id {  get; set; }

        public IdCheckPacket(){}

        public IdCheckPacket(string id)
        {
            type = PacketType.IdCheck;
            this.id = id;
        }
    }
}
