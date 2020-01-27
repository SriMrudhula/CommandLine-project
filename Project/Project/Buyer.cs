using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Buyer
    {
        public int id;
        public string name, phno, email;
        private string pwd;

        public Buyer(int id, string name,string pwd, string phno, string email)
        {
            this.id = id;
            this.name = name;
            this.phno = phno;
            this.email = email;
            this.pwd = pwd;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phno { get => phno; set => phno = value; }
        public string Email { get => email; set => email = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
