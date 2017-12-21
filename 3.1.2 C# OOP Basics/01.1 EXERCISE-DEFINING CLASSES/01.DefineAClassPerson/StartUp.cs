using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefineAClassPerson
{
    public class StartUp
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var person = new Person()
            {
                name = "Pesho",
                age = 20
            };

            var secondPerson = new Person();
            secondPerson.name = "Gosho";
            secondPerson.age = 18;

            var thirdPerson = new Person();
            thirdPerson.name = "Stamat";
            thirdPerson.age = 43;
        }
    }
}
