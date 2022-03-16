using Microsoft.AspNetCore.Mvc;
using PersonManagement.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<PersonController>

        private readonly IPerson _person;

        public PersonController(IPerson person)
        {
             _person = person;
        }
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _person.ListPersons();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _person.GetById(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public int Post([FromBody] Person person)
        {
            return _person.Insert(person);
        }

    }
}
