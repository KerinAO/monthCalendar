using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
             TimeSpan period = moncalKalendar.SelectionEnd
                - moncalKalendar.SelectionStart;

            if (period.Days < 1)
            {
                MessageBox.Show("Niste odabrali bla bla. Pritisnite "
                + "SHIFT da odaberete bla bla bla. "
                + " dana.", "GREŠKA!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Rezervirali ste period od "
                    + moncalKalendar.SelectionStart.ToShortDateString() 
                    + "do "
                    + moncalKalendar.SelectionEnd.ToShortDateString(), 
                    "Rezervacija",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
