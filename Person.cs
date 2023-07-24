using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Person
    {

        public String Name { get; set; }
        public int Age { get; set; }
        public String Gender { get; set; }
        public String Address { get; set; }

        public Person(String Name, int Age, String Gender, String Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Address = Address;
        }

    }
}
