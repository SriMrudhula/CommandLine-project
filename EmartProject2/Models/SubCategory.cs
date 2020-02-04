using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartProject2.Models
{
    public class SubCategory:Category
    {
       [Key]
        public int Scid { get; set; }
        public string Scname { get; set; }

        public SubCategory(int Scid,String Scname,int Cid,String Cname):base(Cid,Cname)
        {
            this.Scid = Scid;
            this.Scname = Scname;
        }
    }
}
