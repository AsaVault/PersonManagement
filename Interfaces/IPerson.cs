namespace PersonManagement.Interfaces
{
    public interface IPerson
    {
        Person GetById(int id);
        int Insert(Person person);
        List<Person> ListPersons();
    }
}
