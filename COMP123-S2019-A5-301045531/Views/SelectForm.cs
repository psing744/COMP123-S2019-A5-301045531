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
using COMP123_S2019_A5_301045531.Controllers;

namespace COMP123_S2019_A5_301045531.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using(var db=new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // local variables that are used as aliases
            var currentRow = ProductDataGridView.CurrentRow;
            var rowIndex = ProductDataGridView.CurrentRow.Index;
            var cells = currentRow.Cells;

            // displays selected hardware in end of form
            SelectedHardwareLabel.Text = $"{cells[2].Value} {cells[3].Value} Priced at: {cells[1].Value}";

            Program.Product.productID = int.Parse(cells[0].Value.ToString());
            Program.Product.condition = cells[10].Value.ToString();
            Program.Product.cost = double.Parse(cells[1].Value.ToString());
            Program.Product.platform = cells[11].Value.ToString();
            Program.Product.OS = cells[12].Value.ToString();
            Program.Product.manufacturer = cells[2].Value.ToString();
            Program.Product.model = cells[3].Value.ToString();
            Program.Product.RAM_size = cells[4].Value.ToString();
            Program.Product.screensize = cells[5].Value.ToString();
            Program.Product.HDD_size = cells[13].Value.ToString();
            Program.Product.CPU_brand = cells[6].Value.ToString();
            Program.Product.CPU_number = cells[8].Value.ToString();
            Program.Product.GPU_Type = cells[13].Value.ToString();
            Program.Product.CPU_type = cells[7].Value.ToString();
            Program.Product.CPU_speed = cells[9].Value.ToString();
            Program.Product.webcam = cells[14].Value.ToString();
        }
    }
}
