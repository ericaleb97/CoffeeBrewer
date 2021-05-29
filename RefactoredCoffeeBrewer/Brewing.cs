using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefactoredCoffeeBrewer
{
    public class Brewing : IMessage
    {
        private DateTime brewDate1;

        public Brewing(DateTime brewDate)
        {
            brewDate1 = brewDate;
        }

        public DateTime brewDate
        {
            get
            {
                return brewDate1;
            }

            set
            {
                brewDate1 = value;
            }
        }

        public bool BeginBrewing()
        {
            MessageBox.Show("The coffee has begun to brew");
            return true;
        }

        public bool EndBrewing()
        {
            MessageBox.Show("The coffee has finished brewing");
            return true;
        }
    }
}
