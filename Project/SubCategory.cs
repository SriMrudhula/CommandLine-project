using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SubCategory:Category
    {
       public int scid { get; set; }
        
        public string scname { get; set; }
        public string scdesc{ get; set; }
            public SubCategory(int cid,int scid,string cname,string scname,string cdesc,string scdesc)
        {   
            this.scid = scid;
            this.scname = scname;
            this.scdesc = scdesc;
            this.cid = cid;
            this.cname = cname;
            this.cdesc = cdesc;
            
        }
    }
}
