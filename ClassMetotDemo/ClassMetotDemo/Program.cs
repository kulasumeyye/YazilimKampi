using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Sümeyye",
                LastName = "Kula",
                Age = 23
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Ahmet",
                LastName = "Özcan",
                Age = 29
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Zeynep",
                LastName = "Öztürk",
                Age = 33
            };
            CustomerManager customer = new CustomerManager();
            customer.Add(customer1);
            customer.Add(customer2);
            customer.Add(customer3);

            customer.List();
            customer.Delete(customer3);
            customer.List();

            Console.ReadLine();
        }
    }
}
