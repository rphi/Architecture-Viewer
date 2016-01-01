using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Architecture_Viewer
{
    public partial class GenerateData : Form
    {
        public object computer;
        public GenerateData()
        {
            InitializeComponent();
        }

        private void GenerateData_Load(object sender, EventArgs e)
        {
            Show();
            Shown += run;
        }

        private void run(object sender, EventArgs e)
        {
            var timer = new System.Timers.Timer(3000);
            timer.Start();
            computer = new ComputerEnvironment();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DoInvoke(Close);
        }

        private void DoInvoke(MethodInvoker del)
        {
            if (InvokeRequired)
            {
                Invoke(del);
            }
            else
            {
                del();
            }
        }
    }
}
