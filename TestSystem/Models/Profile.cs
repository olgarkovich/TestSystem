using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Profile : IdentityUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
    }
}
