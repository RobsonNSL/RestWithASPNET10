using RestWithASPNET10.Model;

namespace RestWithASPNET10.Service.Implementation
{
    public class ImplementationPersonServices : IPersonServices
    {
        public Person Create(Person person)
        {
            person.Id = new Random().Next(1, 1000);
            return person;
        }

        public void Delete(long id)
        {
            //
        }

        public List<Person> FindAll()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = new Random().Next(1,1000),
                    FirstName = "Luis",
                    LastName = "Santos",
                    Address = "Rua dos Bobos, 20",
                    Gender = "Masculino"
                }

            };
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "Lucas",
                LastName = "Santos",
                Address = "Rua dos Bobos, 0",
                Gender = "Masculino"
            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
