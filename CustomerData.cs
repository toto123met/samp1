using System;
using System.Collections.Generic;

namespace sler
{
    public class CustomerData
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<decimal> Payments { get; set; } =new List<decimal>();
    }
}