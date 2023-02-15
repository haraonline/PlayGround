using System.Reflection;

namespace PlayGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class of type
            Type someType;

            //one way of checking the class
            Person somePerson = new Person();
            someType = somePerson.GetType();

            //another way
            Type personType = typeof(Person);
            
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