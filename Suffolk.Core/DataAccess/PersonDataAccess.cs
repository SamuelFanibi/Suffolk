namespace Suffolk.Core.DataAccess
{

    public class PersonDataAccess : IPersonDataAccess
    {
        private List<Person> people = new();
        public PersonDataAccess()
        {
            people.Add(new Person { Id = new Guid("{7F0ADCF8-4EB2-4B47-A60C-373584AAA82B}"), FirstName = "Samuel", LastName = "Fanibi", DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddDays(-20)) });
            people.Add(new Person { Id = new Guid("{5A914441-2E24-4B18-9F13-EA3371FC92EB}"), FirstName = "Samuel", LastName = "Seyi", DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddDays(-21)) });
            people.Add(new Person { Id = new Guid("{4310A650-1EDD-4A14-9BB8-A860BB671231}"), FirstName = "Samuel", LastName = "James", DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddDays(-10)) });
        }

        public List<Person> GetPeople()
        {

            return people;
        }

        public Person AddPerson(string firstname, string lastname, DateTime dataofbirth)
        {
            Person person = new() { Id = Guid.NewGuid(), FirstName = firstname, LastName = lastname, DateOfBirth = DateOnly.FromDateTime(dataofbirth) };
            people.Add(person);
            return person;
        }
    }
}
