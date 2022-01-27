using Timer = System.Windows.Forms.Timer;

namespace Karting
{
    public partial class KartSkills2017 : Form
    {
        DateTime voteTime = new DateTime(2022, 6, 20, 10, 0, 0);

        public KartSkills2017()
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
            Date.Text = "До начала события осталось: 0лет," +TimeRemaining.Days + "дней," + TimeRemaining.Hours + "часов," + TimeRemaining.Minutes + "минут," + TimeRemaining.Seconds + "секунд.";
        }

        private void Sponsor_Click(object sender, EventArgs e)
        {
            Sponsor frm1 = new Sponsor();
            frm1.Show();
            this.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Info frm2 = new Info();
            frm2.Show();
            this.Hide();
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            Authorization frm3 = new Authorization();
            frm3.Show();
            this.Hide();
        }
    }
}