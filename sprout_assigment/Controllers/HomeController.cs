using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace sprout_assigment
{
    [ApiController]
    public class PeopleController : ControllerBase
    {
        static IEnumerable<Person> gPersonRepository = new[]
            {
                new Person { Name = "Ana" },
                new Person { Name = "Felipe" },
                new Person { Name = "Emillia" }
            };

        [HttpGet("people/all")]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return new  ActionResult < IEnumerable < Person >> (gPersonRepository);
        }

        [HttpGet("people/{customerId}")]
        public ActionResult<Person> GetPerson(int customerId)
        {
            if (gPersonRepository.Count() < customerId)
            {
                return NotFound();
            }
            return gPersonRepository.ElementAt(customerId);
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
