using System;
using System.Collections.Generic;
using System.Text;

namespace Listview.Models
{
   public class Employes
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public Employes(string name, string lastName, string position, string email)
        {
            Name = name;
            LastName = lastName;
            Position = position;
            Email = email;
        }
        
    }
}
