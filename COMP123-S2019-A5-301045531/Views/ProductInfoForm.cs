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
            OpenSavedOrder();
            ProductInfoForm_Activated(sender, e);
        }

        public void OpenSavedOrder()
        {
            // configure the file dailog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt";

            // open the file dailog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // open stream for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.Product.productID = short.Parse(inputStream.ReadLine());
                        Program.Product.condition = inputStream.ReadLine();
                        Program.Product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.Product.platform = inputStream.ReadLine();
                        Program.Product.OS = inputStream.ReadLine();
                        Program.Product.manufacturer = inputStream.ReadLine();
                        Program.Product.model = inputStream.ReadLine();
                        Program.Product.RAM_size = inputStream.ReadLine();
                        Program.Product.screensize = inputStream.ReadLine();
                        Program.Product.HDD_size = inputStream.ReadLine();
                        Program.Product.CPU_brand = inputStream.ReadLine();
                        Program.Product.CPU_number = inputStream.ReadLine();
                        Program.Product.GPU_Type = inputStream.ReadLine();
                        Program.Product.CPU_type = inputStream.ReadLine();
                        Program.Product.CPU_speed = inputStream.ReadLine();
                        Program.Product.webcam = inputStream.ReadLine();

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
                    outputStream.WriteLine(Program.Product.productID);
                    outputStream.WriteLine(Program.Product.condition);
                    outputStream.WriteLine(Program.Product.cost);
                    outputStream.WriteLine(Program.Product.platform);
                    outputStream.WriteLine(Program.Product.OS);
                    outputStream.WriteLine(Program.Product.manufacturer);
                    outputStream.WriteLine(Program.Product.model);
                    outputStream.WriteLine(Program.Product.RAM_size);
                    outputStream.WriteLine(Program.Product.screensize);
                    outputStream.WriteLine(Program.Product.HDD_size);
                    outputStream.WriteLine(Program.Product.CPU_brand);
                    outputStream.WriteLine(Program.Product.CPU_number);
                    outputStream.WriteLine(Program.Product.GPU_Type);
                    outputStream.WriteLine(Program.Product.CPU_type);
                    outputStream.WriteLine(Program.Product.CPU_speed);
                    outputStream.WriteLine(Program.Product.webcam);
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
            ProductIdOutputLabel.Text = Program.Product.productID+"";
            conditionOutputLabel.Text = Program.Product.condition;
            costOutputLabel.Text = string.Format("{0:c}",Program.Product.cost);
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
        }
    }
}
