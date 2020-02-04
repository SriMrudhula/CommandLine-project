using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartProject2.Models
{
    public class Item
    {
        [Key]
        public int Ino { get; set; }
        public string Sname { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Desc { get; set; }
        public int Noi { get; set; }
        public int Scid { get; set; }
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Scname { get; set; }
        public Item()
        {

        }
        public Item(string Sname, string Name, int Price, string Desc, int Ino, int Noi, int Cid, int Scid, string Cname, string Scname)
        {
            this.Sname = Sname;
            this.Ino = Ino;
            this.Name = Name;
            this.Noi = Noi;
            this.Price = Price;
            this.Desc = Desc;
            this.Scid = Scid;
            this.Cid = Cid;
            this.Scname = Scname;
            this.Cname = Cname;
        }
    }
}
