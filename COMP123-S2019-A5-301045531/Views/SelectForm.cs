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

            Program.product.productID = int.Parse(cells[0].Value.ToString());
            Program.product.condition = cells[14].Value.ToString();
            Program.product.cost = double.Parse(cells[1].Value.ToString());
            Program.product.platform = cells[16].Value.ToString();
            Program.product.os = cells[15].Value.ToString();
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.ram_size = cells[5].Value.ToString();
            Program.product.LCDsize = cells[7].Value.ToString();
            Program.product.hdd = cells[17].Value.ToString();
            Program.product.CPU_Brand = cells[10].Value.ToString();
            Program.product.CPUnumber = cells[13].Value.ToString();
            Program.product.GPUtype = cells[19].Value.ToString();
            Program.product.CPU_Type = cells[11].Value.ToString();
            Program.product.CPU_Speed = cells[12].Value.ToString();
            Program.product.WebCam = cells[30].Value.ToString();
        }
    }
}
