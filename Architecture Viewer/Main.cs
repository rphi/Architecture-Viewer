using System;
using System.Windows.Forms;

namespace Architecture_Viewer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var computer = new ComputerEnvironment();

            osNameBox.Text = computer.os;
            osVerBox.Text = computer.osVerString;
            servicePackBox.Text = computer.servicePack;
            ramInstalledBox.Text = computer.ramTotal.ToString() + " MB";
            ramFreeBox.Text = computer.ramFree.ToString() + " MB";
            is64bitBox.Text = computer.is64.ToString();
            ramUsed.Value = (int)computer.ramUsed;
            ramUsageNo.Text = Math.Round(computer.ramUsed, 1).ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var genRpt = new GenerateReport();
            genRpt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
