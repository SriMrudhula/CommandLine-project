using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartProject2.Models
{
    public class Category
    {
        
        public int Cid { get; set; }
        public string Cname { get; set; }
       public Category(int Cid,string Cname)
        {
            this.Cid = Cid;
            this.Cname = Cname;
        }

    }
}
