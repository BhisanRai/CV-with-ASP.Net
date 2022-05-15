using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVPerson.Models;

namespace CVPerson.Models
{
    public class Education
    {
        public int EducationID { get; set; }
        public string College { get; set; }
        public string Course { get; set; }
        public DateTime ? CompletionYear { get; set; }
        public bool Project { get; set; }


        //Navigation
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
