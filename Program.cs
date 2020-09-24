using System;

namespace sler
{
    class Program
    {
        static void Main(string[] args)
        {
            var cm = new CustomersSuperManager();
            cm.customers.Add(new CustomerData{CustomerId = 1, CustomerName = "Bob"});
            cm.customers.Add(new CustomerData{CustomerId = 2, CustomerName = "Brajan"});
            cm.customers.Add(new CustomerData{CustomerId = 3, CustomerName = "Dzesika"});
            cm.customers.Add(new CustomerData{CustomerId = 4, CustomerName = "Karina"});

            cm.AddSuperPayment("23.4", 1);
            cm.AddSuperPayment("23,1", 1);

            cm.RemoveCustomerByName("Karina");
        }
    }
}
