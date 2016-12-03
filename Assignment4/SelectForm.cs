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
        private Form _PreviousForm = Program.startForm;
        private Product _selectedComputer;
        private ComputerModel _db;
        public SelectForm()
        {
            InitializeComponent();
            _db = new ComputerModel();
        }

        /// <summary>
        /// Sends the user back to the Start Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            _PreviousForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Send the product selected to the Product Info Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfo = new ProductInfoForm(_selectedComputer, this);
            productInfo.Show();
            this.Hide();
        }

        /// <summary>
        /// Fills the table with data from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        /// <summary>
        /// When user selects a computer from the list, shows manufacturer in text box and saves the Product to be sent to the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int ProductID = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells[0].Value);

                _selectedComputer = (from Product in _db.products
                                   where Product.productID == ProductID
                                    select Product).FirstOrDefault();

                ComputerNameTextBox.Text = _selectedComputer.manufacturer + " - " + _selectedComputer.model;
            }

            //Enable the Next Button
            if (NextButton.Enabled == false)
                NextButton.Enabled = true;
        }
    }
}