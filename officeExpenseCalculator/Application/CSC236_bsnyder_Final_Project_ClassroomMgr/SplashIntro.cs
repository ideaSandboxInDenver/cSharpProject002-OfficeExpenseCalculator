using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_bsnyder_Final_Project_ClassroomMgr
{
    public partial class SplashIntro : Form
    {
        public SplashIntro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(12);
            if (progressBar1.Value == 100)
                timer1.Stop();
        }

        private void splashLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
