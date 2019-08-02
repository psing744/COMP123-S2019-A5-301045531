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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCTINFO_FORM].Hide();
            Program.Forms[FormName.ORDER_FORM].Show();
        }

        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCTINFO_FORM].Hide();
            Program.Forms[FormName.SELECT_FORM].Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
