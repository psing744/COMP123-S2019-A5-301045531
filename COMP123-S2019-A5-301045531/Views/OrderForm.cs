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
            conditionOutputLabel.Text = Program.Product.condition;
            priceOutputLabel.Text = string.Format("{0:c}",Program.Product.cost);
            salesTaxOutputLabel.Text = string.Format("{0:c}", Convert.ToDouble(Program.Product.cost) * 0.13);
            totalPriceOutputLabel.Text = string.Format("{0:c}",Convert.ToDouble(Program.Product.cost) * 1.13);
            platformOutputLabel.Text = Program.Product.platform;
            osOutputLabel.Text = Program.Product.OS;
            manufacturerOutputLabel.Text = Program.Product.manufacturer;
            modelOutputLabel.Text = Program.Product.model;
            memoryOutputLabel.Text = Program.Product.RAM_size;
            lcdSizeOutputLabel.Text = Program.Product.screensize;
            hddOutputLabel.Text = Program.Product.HDD_size;
            cpuBrandOutputLabel.Text = Program.Product.CPU_brand;
            cpuNumberOutputLabel.Text = Program.Product.CPU_number;
            gpuTypeOuputLabel.Text = Program.Product.GPU_Type;
            cpuTypeOutputLabel.Text = Program.Product.CPU_type;
            cpuSpeedOutputLabel.Text = Program.Product.CPU_speed;
            webcamOutputLabel.Text = Program.Product.webcam;
            if (Program.Product.platform=="Laptop")
            {
                laptopPictureBox.Image = Resources.laptop;
            }
            if(Program.Product.platform=="Desktop PC")
            {
                laptopPictureBox.Image = Resources.desktop;
            }
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
