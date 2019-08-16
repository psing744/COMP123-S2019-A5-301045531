using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name - Pritpal Singh
 * Id# 301045531
 * desc- This is start form class
 */

namespace COMP123_S2019_A5_301045531.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for click event of start new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.START_FORM].Hide();
            Program.Forms[FormName.SELECT_FORM].Show();
        }

        /// <summary>
        /// event handler for exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// event handler for open saved order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
            Program.productInfoForm.OpenSavedOrder(sender,e);
        }
    }
}
