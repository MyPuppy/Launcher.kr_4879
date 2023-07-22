using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;

namespace RiderData
{
    public static class FavoriteItem
    {
        public static void Favorite_Item()
        {
            int itemCount = 18;
            using (OutPacket outPacket = new OutPacket("PrFavoriteItemGet"))
            {
                if (Program.FavoriteItem)
                {
                    outPacket.WriteInt(itemCount);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(839);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(854);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1045);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1098);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1239);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1247);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1252);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1269);
                    outPacket.WriteShort(78);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1276);
                    outPacket.WriteShort(81);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1297);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1307);
                    outPacket.WriteShort(101);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1341);
                    outPacket.WriteShort(111);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1348);
                    outPacket.WriteShort(115);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1350);
                    outPacket.WriteShort(117);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1357);
                    outPacket.WriteShort(124);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1359);
                    outPacket.WriteShort(125);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1360);
                    outPacket.WriteShort(126);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1365);
                    outPacket.WriteShort(130);
                    outPacket.WriteByte(0);
                }
                else
                {
                    outPacket.WriteInt(0);
                }
                RouterListener.MySession.Client.Send(outPacket);
            }
        }
    }
}