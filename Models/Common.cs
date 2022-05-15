using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVPerson.Models
{
    public class Common
    {
        public ICollection<Person> Person { get; set; }
        public ICollection<Education> Education { get; set; }

        public ICollection<Experience> Experience { get; set; }
        public Common()
        {
            Person = new HashSet<Person>();
            Education = new HashSet<Education>();
            Experience = new HashSet<Experience>();

        }
    }
}
