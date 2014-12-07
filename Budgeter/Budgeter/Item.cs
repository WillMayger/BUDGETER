using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeter
{
    public class Item
    {
        public int PaymentPeriod { get; private set; }
        public decimal CostPerPeriod { get; private set; }
        public string Name { get; private set; }

        public Item(int paymentPeriod, decimal costPerPeriod, string name)
        {
            if (costPerPeriod < 0 || paymentPeriod < 0 ) return;

            PaymentPeriod = paymentPeriod;
            CostPerPeriod = costPerPeriod;
            Name = name;
        }
    }
}
