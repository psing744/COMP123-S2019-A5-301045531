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

/*
 * Name - Pritpal Singh
 * Id# 301045531
 * desc- This is order form class
 */

namespace COMP123_S2019_A5_301045531.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Hide();
            Program.productInfoForm.Show();
        }

        /// <summary>
        /// event handler for cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        /// <summary>
        /// event hanfler for order form activation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// event handler for print button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is printing", "Printing", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// event handler for finish button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Thanks for shopping with us\nYour order will be processed in 7-10 business days", "Thank You", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// event handler for about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }
    }
}
