using System.Collections.Generic;
using System.Linq;

namespace sler
{
    public class CustomersSuperManager
    {
        public List<CustomerData> customers = new List<CustomerData>();

        // parsedAmount is amount as string for example parsed from report with regex etc.
        public void AddSuperPayment(string parsedAmount, int ci)
        {
            decimal payment = parsedAmount.ToAmount();
            var customer = customers.First(c => c.CustomerId == ci);
            customer.Payments.Add(payment);
        }

        public void RemoveCustomerByName(string customerName)
        {
            foreach (var customer in customers)
            {
                if(customer.CustomerName == customerName)
                customers.Remove(customer);
            }
        }

    }
}