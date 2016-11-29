using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4.Models;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        private Form PreviousForm;
        private Product selectedComputer;
        private ComputerModel db;
        public SelectForm(Form PreviousForm)
        {
            InitializeComponent();
            this.PreviousForm = PreviousForm;
            db = new ComputerModel();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfo = new ProductInfoForm(selectedComputer, this);
            productInfo.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int ProductID = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells[0].Value);

                selectedComputer = (from Product in db.products
                                   where Product.productID == ProductID
                                    select Product).FirstOrDefault();

                ComputerNameTextBox.Text = selectedComputer.manufacturer + " - " + selectedComputer.model;
            }

            //Enable the Next Button
            if (NextButton.Enabled == false)
                NextButton.Enabled = true;
        }
    }
}