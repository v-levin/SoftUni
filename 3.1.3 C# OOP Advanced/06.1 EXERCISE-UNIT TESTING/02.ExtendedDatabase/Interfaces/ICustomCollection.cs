using System.Collections.Generic;

namespace ExtendedDatabase.Interfaces
{
    public interface ICustomCollection
    {
        void Add(Person person);
        void Remove();
        IList<Person> Fetch();
        Person FindById(long id);
        Person FindByUsername(string username);
    }
}
