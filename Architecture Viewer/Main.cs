using System;
using System.Windows.Forms;

namespace Architecture_Viewer
{
    public partial class Main : Form
    {
        public object computer;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var startupForm = new Startup();
            var dresult = startupForm.ShowDialog();
            if (dresult != DialogResult.OK)
            {
                Application.Exit();
            }
            Shown += run;
        }

        private void run(object sender, EventArgs e)
        {
            var dataGen = new GenerateData();
            dataGen.ShowDialog();
            computer = dataGen.computer;
            setValues((ComputerEnvironment) computer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var genRpt = new GenerateReport();
            genRpt.Launch(computer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void setValues(ComputerEnvironment computer)
        {
            osNameBox.Text = computer.os;
            osVerBox.Text = computer.osVerString;
            servicePackBox.Text = computer.servicePack;
            ramInstalledBox.Text = computer.ramTotal.ToString() + " MB";
            ramFreeBox.Text = computer.ramFree.ToString() + " MB";
            is64bitBox.Text = computer.is64.ToString();
            ramUsed.Value = (int)computer.ramUsed;
            ramUsageNo.Text = Math.Round(computer.ramUsed, 1).ToString() + "%";
            disksBox.Text = computer.diskInfo;
            installedProgramsBox.Text = computer.installedSoftware;
        }
    }
}
