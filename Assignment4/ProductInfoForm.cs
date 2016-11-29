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
    public partial class ProductInfoForm : Form
    {
        private Product computer;
        private Form PreviousForm;
        public ProductInfoForm(Product computer, Form PreviousForm)
        {
            this.computer = computer;
            this.PreviousForm = PreviousForm;
            InitializeComponent();

            ProductIDTextBox.Text = ""+computer.productID;
            ConditionTextBox.Text = computer.condition;
            CostTextBox.Text = "$" + computer.cost;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
