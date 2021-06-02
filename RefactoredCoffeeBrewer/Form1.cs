using System;
using System.Windows.Forms;

namespace RefactoredCoffeeBrewer
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        Timer t = new Timer();
        IMessage obj;
        DateTime dateOfBrewing;
        public Form1()
        {
            InitializeComponent();
        }

        private void startTimer_Click(object sender, EventArgs e)
        {
            timer.Start();

            t.Interval = 500;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = dateOfBrewing.Subtract(DateTime.Now);
            timeRemaining.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            dateOfBrewing = brewingDate.Value;
            obj = new Brewing(brewingDate.Value);

            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour == dateOfBrewing.Hour && currentTime.Minute == dateOfBrewing.Minute && currentTime.Second == dateOfBrewing.Second)
            {
                timer.Stop();
                t.Stop();
                obj.BeginBrewing();
                System.Threading.Thread.Sleep(5000);
                obj.EndBrewing();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
            t.Stop();
            obj.StopBrewing();
        }
    }
}
