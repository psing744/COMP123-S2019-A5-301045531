using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dailog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt";

            // open the file dailog
            var result = ProductOpenFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                try
                {
                    // open stream for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.product.productID = int.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = double.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.os = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.ram_size = inputStream.ReadLine();
                        Program.product.LCDsize = inputStream.ReadLine();
                        Program.product.hdd = inputStream.ReadLine();
                        Program.product.CPU_Brand = inputStream.ReadLine();
                        Program.product.CPUnumber = inputStream.ReadLine();
                        Program.product.GPUtype = inputStream.ReadLine();
                        Program.product.CPU_Type = inputStream.ReadLine();
                        Program.product.CPU_Speed = inputStream.ReadLine();
                        Program.product.WebCam = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ProductInfoForm_Activated(sender,e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dailog
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            // open the file dailog
            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write content in string format
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.os);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.ram_size);
                    outputStream.WriteLine(Program.product.LCDsize);
                    outputStream.WriteLine(Program.product.hdd);
                    outputStream.WriteLine(Program.product.CPU_Brand);
                    outputStream.WriteLine(Program.product.CPUnumber);
                    outputStream.WriteLine(Program.product.GPUtype);
                    outputStream.WriteLine(Program.product.CPU_Type);
                    outputStream.WriteLine(Program.product.CPU_Speed);
                    outputStream.WriteLine(Program.product.WebCam);
                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIdOutputLabel.Text = Program.product.productID+"";
            conditionOutputLabel.Text = Program.product.condition;
            costOutputLabel.Text = Program.product.cost+"";
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
    }
}
