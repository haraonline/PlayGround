using System.Reflection;

namespace PlayGround
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //there is a class in C# that is of type
            //Type someType;

            //one way of examining the class
            Person person1 = new Person();
            Type persontype1 = person1.GetType();

            //another way
            //access details of the personType via dot notation
            Type type2 = typeof(Person);
            var props = type2.GetProperties();

            //interate and print property name and type
            Console.WriteLine("REFLECTIONS: PROPERTIES OF PERSON CLASS");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            foreach (var prop in props)
            {
                Console.WriteLine($"Property Name: {prop.Name}, Property Type: {prop.PropertyType.Name}");
            }

            //create an instance of Person
            Person person2 = new Person();
            //set the properties
            person2.Name = "John";
            person2.Age = 30;
            person2.Address = "123 Main Street";
            

            var methods = type2.GetMethods();
            //interate and print method name and return type
            Console.WriteLine("REFLECTIONS: METHODS OF PERSON CLASS");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            foreach (var method in methods)
            {
                Console.WriteLine($"Method Name: {method.Name}, Return Type: {method.ReturnType.Name}");
                //if the method name is Print then call it
                if (method.Name == "print")
                {
                    method.GetParameters();
                    method.Invoke(person2, null); //this function needs no parameters
                }
            }

        }
    }
}