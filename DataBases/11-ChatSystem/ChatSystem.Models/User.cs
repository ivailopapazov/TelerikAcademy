using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem.Models
{
    public class User
    {
        public string Name { get; private set; }

        public User(string name)
        {
            this.Name = name;
        }
    }
}
