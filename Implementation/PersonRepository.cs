using PersonManagement.Interfaces;

namespace PersonManagement.Implementation
{
    public class PersonRepository : IPerson
    {
        public List<Person> _Persons { get; set; }

        public PersonRepository()
        {
            _Persons = new List<Person>
            {
                new Person()
                {
                    Name = "John",
                    Id = 1,
                    Age =24,
                    DateOfBirth = DateTime.Now,
                },
                new Person()
                {
                    Name = "Samuel",
                    Id = 1,
                    Age =24,
                    DateOfBirth = DateTime.Now,
                },
                new Person()
                {
                    Name = "gabriel",
                    Id = 1,
                    Age =24,
                    DateOfBirth = DateTime.Now,
                },
            };
        }


        public Person GetById(int id)
        {
            //var persons = PersonDb();
            var person = _Persons.FirstOrDefault(x => x.Id == id);
            return person;
        }

        public int Insert(Person person)
        {
            _Persons.Add(person);
            return person.Id;
        }

        public List<Person> ListPersons()
        {
            return _Persons.ToList();
        }

        private List<Person> PersonDb()
        {
            var data = new List<Person>
            {
                new Person()
                {
                    Name = "John",
                    Id = 1,
                    Age =24,
                    DateOfBirth = DateTime.Now,
                },
                new Person()
                {
                    Name = "Samuel",
                    Id = 1,
                    Age =24,
                    DateOfBirth = DateTime.Now,
                },
                new Person()
                {
                    Name = "gabriel",
                    Id = 1,
                    Age =24,
                    DateOfBirth = DateTime.Now,
                },
            };

            return data;
        }
    }
}
