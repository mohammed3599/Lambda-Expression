namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Func<int, int> square = x => x * x;
            //Func<int, int> square = (x) =>
            //{
            //    Console.WriteLine(x);
            //    return x * x;
            //};
            //int result = square(6);
            //    Console.WriteLine(result);

            //MathOperation mathOperation = add;
            //int result2 = mathOperation(3,5);
            //Console.WriteLine(result2);

            //mathOperation = multiply;
            //int result3 = mathOperation(4,6);
            //Console.WriteLine(result3);

            List<Person> list = new List<Person>()
            {
                new Person("Salim", 29, "Male", "Muscat"),
                new Person("Fatema", 25, "Female", "Ibri"),
                new Person("Ali", 32, "Male", "Sohar"),
                new Person("Maha", 22, "Female", "Salalah"),
                new Person("Saeed", 22, "Male", "Nizwa"),
                new Person("Mohammed", 24, "Male", "Rustaq"),
                new Person("Reem", 30, "Female", "Barka"),
                new Person("Sheikha", 20, "Female", "Muscat"),
                new Person("Abddulah", 34, "Male", "Salalah"),
            };

            //List<Person> persons = list
            //    .Where(x => x.Age <= 25)
            //    .OrderBy(x => x.Name)
            //    .ToList();
            //List<Person> persons = list.First(x => x.Address == "Muscat");
            //Console.WriteLine(persons);


            List<String> Names = list
                                     .Where(x => x.Age <= 25)
                                     .OrderBy(x => x.Name)
                                     .Select(x => x.Name)
                                     .ToList();

            Person? person = list .FirstOrDefault(x => x.Address == "Muscat");
            if (person == null)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine(person?.Name);
            Console.WriteLine(person?.Name?? "Hello");
        }

        public List<Person> getByAge (int age, List<Person> persons)
        {
            List<Person> agePerson = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Age > age)
                {
                    agePerson.Add(person);
                }
            }
            return agePerson;
        }
        static void printPersonList(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }

        public delegate int MathOperation(int a, int b);
        static int add(int a, int b) => a+b;
        static int multiply(int a, int b) => a*b;
        static void abc() { }

    }
}