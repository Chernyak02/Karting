using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Karting
{
    public partial class Gender : Form
    {
        DateTime voteTime = new DateTime(2022, 6, 20, 10, 0, 0);
        public Gender()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        Timer timer1 = new Timer();

        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            Date.Text = "До начала события осталось: 0лет," + TimeRemaining.Days + "дней," + TimeRemaining.Hours + "часов," + TimeRemaining.Minutes + "минут," + TimeRemaining.Seconds + "секунд.";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MenuRacer frm1 = new MenuRacer();
            frm1.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            KartSkills2017 frm2 = new KartSkills2017();
            frm2.Show();
            this.Hide();
        }
    }
}
