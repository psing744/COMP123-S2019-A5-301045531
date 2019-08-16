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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            conditionOutputLabel.Text = Program.product.condition;
            priceOutputLabel.Text = Program.product.cost + "";
            salesTaxOutputLabel.Text = (Program.product.cost * 0.13) + "";
            totalPriceOutputLabel.Text = (Program.product.cost * 1.13) + "";
            platformOutputLabel.Text = Program.product.platform;
            osOutputLabel.Text = Program.product.os;
            manufacturerOutputLabel.Text = Program.product.manufacturer;
            modelOutputLabel.Text = Program.product.model;
            memoryOutputLabel.Text = Program.product.ram_size;
            lcdSizeOutputLabel.Text = Program.product.LCDsize;
            hddOutputLabel.Text = Program.product.hdd;
            cpuBrandOutputLabel.Text = Program.product.CPU_Brand;
            cpuNumberOutputLabel.Text = Program.product.CPUnumber;
            gpuTypeOuputLabel.Text = Program.product.GPUtype;
            cpuTypeOutputLabel.Text = Program.product.CPU_Type;
            cpuSpeedOutputLabel.Text = Program.product.CPU_Speed;
            webcamOutputLabel.Text = Program.product.WebCam;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is printing", "Printing", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Thanks for shopping with us\nYour order will be processed in 7-10 business days", "Thank You", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
