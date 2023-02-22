namespace PlayGround
{
    internal partial class Program
    {
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