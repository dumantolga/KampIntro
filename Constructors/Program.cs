using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="Tolga",LastName="Duman",City="Antakya"};
            Customer customer2 = new Customer(2,"Tugay","Mert","Hatay");
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        //default constructor = parametresi olmayan constructor
        public Customer()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}