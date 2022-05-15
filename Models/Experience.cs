using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVPerson.Models;

namespace CVPerson.Models
{
    public class Experience
    {
        public int ExperienceID { get; set; }

        public string Field { get; set; }

        public int Year { get; set; }

        public string SkillLevel { get; set; }


        //Navigation
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
