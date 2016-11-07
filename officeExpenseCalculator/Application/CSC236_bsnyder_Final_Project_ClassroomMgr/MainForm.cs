using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace CSC236_bsnyder_Final_Project_ClassroomMgr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

                public void SplashStart()
        {
            Application.Run(new SplashIntro());
        }

        private void addClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display the form.
            AddForm details = new AddForm();

            // display the form.
            details.ShowDialog();
        }

        private void viewClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display the form.
            ViewForm details = new ViewForm();

            // display the form.
            details.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // credit for writing the program
            string s = "Application developed by Joel Snyder.\n\nSnyderLogic\n200 E. Main Street\nDenver, CO 80207";
            MessageBox.Show(s, "Application Credit");
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close application
            this.Close();
        }
    }
}
