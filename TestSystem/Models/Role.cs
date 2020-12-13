using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Profile> Profiles { get; set; }
        public Role()
        {
            Profiles = new List<Profile>();
        }
    
    }
}
