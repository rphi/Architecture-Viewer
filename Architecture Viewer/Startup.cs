using System;
using System.Windows.Forms;

namespace Architecture_Viewer
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Abort;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborted", "The application will now terminate");
            Application.Exit();
        }
    }
}
