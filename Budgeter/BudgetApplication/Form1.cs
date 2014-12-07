using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Budgeter;

namespace BudgetApplication
{
    public partial class Form1 : Form
    {
        Month bugeter = new Month(700.00m);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            List<string> itemsString = new List<string>();

            decimal moneyIn;
            bool i = decimal.TryParse(income.Text, out moneyIn);

            

            string stringNetflix = "";
            bugeter.AddItem(1, 6.99m, itemName.Text);
            
            foreach (Item item in bugeter.Items)
            {
                stringNetflix = item.Name + " " + "£" + item.CostPerPeriod;
                itemsString.Add(stringNetflix);
            }
            itemsString.Add("Money Left Over: £" + bugeter.MoneyLeft());
            listBox1.DataSource = itemsString;
        }
    }
}
