using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingNetNetCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingNetNetCore.Controllers
{
    public class NistTutorialController : Controller
    {
        // GET: /<controller>/

        private List<PersonalDetail> people = new List<PersonalDetail>();
        public NistTutorialController()
        {
            people = NistMemory.GetPeople();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult People()
        {
            
            
            return View(people);
        }
        public IActionResult AddPeople(string name, string address, string occupation)
        {
            
            people.Add(new PersonalDetail()
            {
                FirstName = name,
                Address = address,
                Occupation = occupation
            });
            return RedirectToAction("People");
        }
    }
}
