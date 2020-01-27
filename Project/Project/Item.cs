using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Item
    {
         public int ino { get; set; }
        public int noi, price,scid,sid;
        public string desc,name;

        public Item(int sid,int ino,int scid,string name,int noi,int price,string desc)
        { 
            this.sid = sid;
            this.ino = ino;
            this.name = name;
            this.noi = noi;
            this.price=price;
            this.desc = desc;
            this.scid = scid;
        }


       }
}
