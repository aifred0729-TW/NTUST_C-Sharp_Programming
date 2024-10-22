using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework01
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkFries_CheckedChanged(object sender, EventArgs e) {
            if (chkFries.Checked) {
                rbBigFries.Enabled = true;
                rbSmallFries.Enabled = true;
            } else {
                rbBigFries.Enabled = false;
                rbSmallFries.Enabled= false;
            }
        }

        private void cbDrink_CheckedChanged(object sender, EventArgs e) {
            if (chkDrink.Checked) {
                rbCola.Enabled = true;
                rbCoffee.Enabled = true;
                rbBlackTea.Enabled = true;
            } else {
                rbCola.Enabled = false;
                rbCoffee.Enabled = false;
                rbBlackTea.Enabled= false;
            }
        }

        static int countPrice(int price, string count) { return price * int.Parse(count); }

        private void btOrder_Click(object sender, EventArgs e) {
            int price = 0;

            if (chkFishBurger.Checked && tbFishBurgerCount.Text != "") price += countPrice(59, tbFishBurgerCount.Text);
            if (chkChickenBurger.Checked && tbChickenBurgerCount.Text != "") price += countPrice(69, tbChickenBurgerCount.Text);
            if (chkSmallPizza.Checked && tbSmallPizzaCount.Text != "") price += countPrice(259, tbSmallPizzaCount.Text);
            if (chkBigPizza.Checked && tbBigPizzaCount.Text != "") price += countPrice(429, tbBigPizzaCount.Text);

            if (chkFries.Checked) {
                if (rbBigFries.Checked && tbBigFries.Text != "") price += countPrice(35, tbBigFries.Text);
                else if (rbSmallFries.Checked && tbSmallFries.Text != "") price += countPrice(25, tbSmallFries.Text);
                else { MessageBox.Show("PLEASE SELECT ONE OF THE FRIES OR ENTER THE COUNT !", "ERROR"); return; }
            } 
            
            if (chkDrink.Checked) {
                if (rbCola.Checked && tbCola.Text != "") price += countPrice(25, tbCola.Text);
                else if (rbCoffee.Checked && tbCoffee.Text != "") price += countPrice(30, tbCoffee.Text);
                else if (rbBlackTea.Checked && tbBlackTea.Text != "") price += countPrice(20, tbBlackTea.Text);
                else { MessageBox.Show("PLEASE SELECT ONE OF THE DRINK OR ENTER THE COUNT !", "ERROR"); return; }
            }

            lbMoney.Text = price.ToString().PadRight(8);
        }
    }
}
