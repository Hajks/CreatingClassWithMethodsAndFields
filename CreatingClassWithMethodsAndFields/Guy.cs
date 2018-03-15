using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingClassWithMethodsAndFields
{
    public class Guy //Class which use two methods and two fields. It allows me to give or take cash from my objects.
    {
       public int Cash;
       public string Name;

        public int GiveCash(int amount)
        {
            if (amount > 0 && Cash >= amount) // amount > 0 is for being sure that minus value will be not used.
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Nie mam wystarczającej ilości pieniędzy", "Powiedział " + Name);
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("To nie jest taka ilość pieniędzy jaką mogę przyjąć", "Powiedział " + Name);
                return 0;
            }
        }
    }
}
