using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Architecture_Viewer
{
    public partial class GenerateReport : Form
    {
        string folder;

        public GenerateReport()
        {
            InitializeComponent();
        }

        private void folderChooserButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
            }

            selectedFolder.Text = folder;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.SelectedPath.Length == 0)
            {
                MessageBox.Show("Please select a location to save the report before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            progressBar.Enabled = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            var location = folderBrowserDialog1.SelectedPath + "\\PhippsNET-ITC-report-" + DateTime.Now.ToString("dd-MM-yy-HHmmss") + ".txt";

            var report = reportGen();

            try
            {
                File.WriteAllText(location, report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar.Enabled = false;
                return;
            }

            MessageBox.Show("Your report has been saved to " + location + ". Please send this document to the support engineer.", "All done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private string reportGen()
        {
            var env = new ComputerEnvironment();
            var stringbld = new StringBuilder();

            stringbld.AppendLine("###### PhippsNET ITC System Information Tool Report ######");
            stringbld.AppendLine("Computer Name: " + env.computerName);
            stringbld.AppendLine("Generated: " + env.timestamp);
            stringbld.AppendLine("OS Name: " + env.os);
            stringbld.AppendLine("OS Version: " + env.osVerString);
            stringbld.AppendLine("64bit: " + env.is64);
            stringbld.AppendLine("Service Pack: " + env.servicePack);
            stringbld.AppendLine("Installed RAM: " + env.ramTotal);
            stringbld.AppendLine("Free RAM: " + env.ramFree + "(" + Math.Round(env.ramUsed, 1) + "% used)");

            return stringbld.ToString();
        }
    }
}
