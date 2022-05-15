using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVPerson.Models;
using Microsoft.AspNetCore.Http;
using CVPerson.Data;

namespace CVPerson.Controllers
{
    public class MainController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        

        public MainController(ApplicationDbContext context)
        {
            
            dbContext = context ;
            

        }
      
        
        public async Task<IActionResult> Index(Person person, List<Education> education, List<Experience> experience)
        {
            if (person.FirstName!=null && education.Count != 0 && experience.Count != 0)
            {
                dbContext.Add(person);
                await dbContext.SaveChangesAsync();
                for (var i = 0; i < education.Count; i++)
                {
                    education[i].PersonID = person.PersonID;
                }
                for (var j = 0; j < experience.Count; j++)
                {
                    experience[j].PersonID = person.PersonID;
                }
              // dbContext.Add(education);
              // await dbContext.SaveChangesAsync();
              // dbContext.Add(experience);
              // await dbContext.SaveChangesAsync();
                return RedirectToAction("Final");

            }
            return View();

        }
      public IActionResult Final()
        {
            Common comobj = new Common
            {
                Person = dbContext.Person.ToList(),
                Education = dbContext.Education.ToList(),
                Experience = dbContext.Experience.ToList()
            };
            return View(comobj);

        }
    }
}
