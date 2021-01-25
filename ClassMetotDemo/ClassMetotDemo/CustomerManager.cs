using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("Id: " + customer.Id + " ,Name: " + customer.Name + " , LastName: " + customer.LastName + " , Age: " + customer.Age);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            }
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);

            Console.WriteLine("******"+"Customer Id Number " + customer.Id + " has been deleted.");
        }
      
       
    }
}
