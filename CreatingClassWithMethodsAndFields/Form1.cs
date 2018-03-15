using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingClassWithMethodsAndFields
{
    public partial class Form1 : Form
    {
        //If i declare guys bob and joe here then later i can skip "New" word while creating objects.
        Guy bob;
        Guy joe;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Name = "Bob", Cash = 100 }; //{} allows me save time and space and it's just simplier to read
            joe = new Guy() { Name = "Joe", Cash = 110 };
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            joeLabel.Text = "Joe ma " + joe.Cash + " zł";
            bobLabel.Text = "Bob ma " + bob.Cash + " zł";
            bankLabel.Text = "Bank ma " + bank + " zł";
        }

        private void bobGivesButton_Click(object sender, EventArgs e)
        {
            joe.Cash += bob.GiveCash(5);
            UpdateLabels();
        }

        private void joeGivesButton_Click(object sender, EventArgs e)
        {


            bob.Cash += joe.GiveCash(5);
            UpdateLabels();
        }

        private void bankTakesButton_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10 && bob.Cash >= 10)
            {
                joe.GiveCash(10);
                bob.GiveCash(10);
                bank += 20;
            }
            else
            {
                MessageBox.Show("Panowie nie mają wystarczającej ilości pieniędzy.", "Obsługa banku mówi..");
            }
            UpdateLabels();
        }
    

        private void bankGivesButton_Click(object sender, EventArgs e)
        {
            if (bank >= 20)
            {
                joe.ReceiveCash(10);
                bob.ReceiveCash(10);
                bank -= 20;
            }
            else
            {
                MessageBox.Show("Niestety, ale nie możemy obsłużyć państwa w tej chwili", "Obsługa banku mówi...");
            }
            UpdateLabels();
        }
    }
}
