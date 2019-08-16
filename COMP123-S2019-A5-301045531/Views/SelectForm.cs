using COMP123_S2019_A5_301045531.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name - Pritpal Singh
 * Id# 301045531
 * desc- This is select form class
 */

namespace COMP123_S2019_A5_301045531.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for load of select form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using(var db=new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
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
        /// event handler for next button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Hide();
            Program.productInfoForm.Show();
        }

        /// <summary>
        /// event button for selection change on data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // local variables that are used as aliases
            var currentRow = ProductDataGridView.CurrentRow;
            var rowIndex = ProductDataGridView.CurrentRow.Index;
            var cells = currentRow.Cells;

            // displays selected hardware in end of form
            SelectedHardwareLabel.Text = $"{cells[2].Value} {cells[3].Value} Priced at: {cells[1].Value:c}";

            // storing values of product selection to class
            Program.Product.productID = short.Parse(cells[0].Value.ToString());
            Program.Product.condition = cells[14].Value.ToString();
            Program.Product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.Product.platform = cells[16].Value.ToString();
            Program.Product.OS = cells[15].Value.ToString();
            Program.Product.manufacturer = cells[2].Value.ToString();
            Program.Product.model = cells[3].Value.ToString();
            Program.Product.RAM_size = cells[5].Value.ToString();
            Program.Product.screensize = cells[7].Value.ToString();
            Program.Product.HDD_size = cells[17].Value.ToString();
            Program.Product.CPU_brand = cells[10].Value.ToString();
            Program.Product.CPU_number = cells[13].Value.ToString();
            Program.Product.GPU_Type = cells[19].Value.ToString();
            Program.Product.CPU_type = cells[11].Value.ToString();
            Program.Product.CPU_speed = cells[12].Value.ToString();
            Program.Product.webcam = cells[30].Value.ToString();
        }
    }
}
