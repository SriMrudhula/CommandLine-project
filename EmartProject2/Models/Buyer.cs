using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace EmartProject2.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Mobile Number")]
        public string Phno { get; set; }
        [Required]
        //[ValidateDomain(allowdomain: "gmail.com")]
        [Remote(action: "IsExist", controller: "Buyers")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password ")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "Enter Password")]
        [DataType("Password")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "password Mismatch")]
        [DataType("Password")]
        public string Cpwd { get; set; }
        public Buyer()
        {

        }
    }
}
