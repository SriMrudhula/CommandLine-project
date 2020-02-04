using System;
using System.ComponentModel.DataAnnotations;
namespace EmartProject2.Models
{
    public class ValidateDomainAttribute:ValidationAttribute
    {
        private String allowdomain;
        public ValidateDomainAttribute(string allowdomain)
        {
            this.allowdomain = allowdomain;
        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == allowdomain)
                return true;
            else
                return false;
        }
    }
}