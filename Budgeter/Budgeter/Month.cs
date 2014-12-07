using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budgeter
{
    public class Month
    {
        public List<Item> Items = new List<Item>();

        public int NumberOfItems { get { return Items.Count; } }

        public decimal MoneyIn  { get; private set; }

        public Month(decimal salary, decimal leftOver)
        {
            MoneyIn = salary + leftOver;
        }

        public Month(decimal salary)
        {
            MoneyIn = salary + 0.0m;
        }

        public void AddItem(int paymentPeriod, decimal costPerPeriod, string name)
        {
            if (paymentPeriod < 0 || costPerPeriod < 0) return;

                Items.Add(new Item(paymentPeriod, costPerPeriod, name));
        }

        public void RemoveItem(string itemName)
        {
            foreach (Item OI in Items)
            {
                if (OI.Name == itemName) Items.Remove(OI);
                return;
            }
        }

        public void ClearBudget()
        {
            Items.Clear();
        }

        public bool IsProductInBasket(string name)
        {
            foreach (Item OI in Items)
            {
                if (OI.Name == name) return true;
            }
            return false;
        }

        public bool SaveBasket(string fileName)
        {
            FileInfo receipt = new FileInfo(fileName);

            if (receipt.Exists) return false;

            StreamWriter file = new StreamWriter(fileName);
            foreach (Item OI in Items)
            {
                file.WriteLine(OI.Name + ": " + OI.PaymentPeriod + " £" + OI.CostPerPeriod);
            }

            file.Close();

            return true;
        }

        public decimal MoneyLeft()
        {
            decimal moneyLeft = MoneyIn;
            foreach (Item i in Items)
            {
                moneyLeft -= i.CostPerPeriod;
            }
            return moneyLeft;
        }
    }
}
