using System;
using System.ComponentModel.DataAnnotations;

namespace HealthcarePortal.Core.Models
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }
        [UIHint("password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
       
    }
}

