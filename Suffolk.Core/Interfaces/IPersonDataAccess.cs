namespace Suffolk.Core.Interfaces
{
    public interface IPersonDataAccess
    {
        Person AddPerson(string firstname, string lastname, DateTime dataofbirth);
        List<Person> GetPeople();
    }

}
