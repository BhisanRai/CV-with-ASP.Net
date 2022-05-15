using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVPerson.Models;

namespace CVPerson.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string Address { get; set; } 
        public bool WorkStatus { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }

        //Navigation
        public ICollection<Education> Education { get; set; }

        public ICollection<Experience> Experience { get; set; }
        public Person()
        {
            Education = new HashSet<Education>();
            Experience = new HashSet<Experience>();

        }
    }
}
