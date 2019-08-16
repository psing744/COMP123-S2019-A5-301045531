using COMP123_S2019_A5_301045531.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301045531.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            Program.Forms[FormName.SPLASH_FORM].Hide();
            Program.Forms[FormName.START_FORM].Show();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            welcomePictureBox.Image = Resources.welcomeLogo;
        }
    }
}
