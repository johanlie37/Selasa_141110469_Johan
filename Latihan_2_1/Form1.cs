using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domain.SelectedItem = "Januari";
            DateTime start = new DateTime(2016, 1, 1);
            DateTime end = new DateTime(2016, 12, 31);
            TimeSpan range = end - start;
            int day = range.Days;
            for (var i = 0; i <= day; i++)
            {
                var bolddate = start.AddDays(i);
                switch (bolddate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        monthCalendar1.AddBoldedDate(bolddate);
                        break;
                    case DayOfWeek.Sunday:
                        monthCalendar1.AddBoldedDate(bolddate);
                        break;
                }
            }
            //Tgl Lahir : 23 Maret
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1996, 3, 23));
        }
        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }



        

        private void button1_Click_1(object sender, EventArgs e)
        
        {

                monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, domain.SelectedIndex + 1, Convert.ToInt32(numeric.Value)));
                monthCalendar1.UpdateBoldedDates();
        }

        private void domain_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domain.Text == "Januari" || domain.Text == "Maret" || domain.Text == "Mei" || domain.Text == "Juli"
                || domain.Text == "Agustus" || domain.Text == "Oktober" || domain.Text == "Desember")
            {
                numeric.Maximum = 31;
                numeric.Minimum = 1;
            }
            else if (domain.Text == "Februari")
            {
                numeric.Maximum = 29;
                numeric.Minimum = 1;
            }
            else
            {
                numeric.Maximum = 30;
                numeric.Minimum = 1;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, domain.SelectedIndex + 1, Convert.ToInt32(numeric.Value)));
            monthCalendar1.UpdateBoldedDates();
        }

        private void numeric_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
