using System.Reflection;

namespace PlayGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class of type
            //Type someType;

            //one way of checking the class
            //Person person1 = new Person();
            //Type type1 = person1.GetType();

            //another way. access details of the personType via dot notation
            Type type2 = typeof(Person);
            var props = type2.GetProperties();
            
            //interate and print property name and type
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
            foreach (var method in methods)
            {
                Console.WriteLine($"Method Name: {method.Name}, Return Type: {method.ReturnType.Name}");
                //if the method name is Prin then call it
                if (method.Name == "print")
                {
                    method.GetParameters();
                    method.Invoke(person2, null);
                }
            }

        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }


            public void print()
            {
                Console.WriteLine($"Name: {Name} Age: {Age} Address: {Address}");

            }

            public void ChangeAddresses(string newAddress)
            {
                Address = newAddress;
                Console.WriteLine($"Name: {Name} Age: {Age} has a new Address: {Address}");
            }
        }        
    }
}