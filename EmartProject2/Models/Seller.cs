using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace EmartProject2.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Mobile Number")]
        public string Phno { get; set; }
    
        public string Cname { get; set; }
        public string Gstin { get; set; }
        [Required]
        //[ValidateDomain(allowdomain: "gmail.com")]
        [Remote(action: "IsExist", controller: "Sellers")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password ")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="Enter Password")]
        [DataType("Password")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage="password Mismatch")]
        [DataType("Password")]
        public string Cpwd { get; set; }
        public string Photo { get;set; }
        public Seller()
        {

        }
        public Seller(int Id, string Name, string Pwd, string Phno, string Email, string Cname, string Gstin)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phno = Phno;
            this.Cname = Cname;
            this.Gstin = Gstin;
            this.Email = Email;
            this.Pwd = Pwd;
        }

    }
}
