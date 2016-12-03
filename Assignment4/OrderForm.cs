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
    public partial class OrderForm : Form
    {
        private Product _computer;
        private Form _previousForm;
        public OrderForm(Product computer, Form previousForm)
        {
            this._computer = computer;
            this._previousForm = previousForm;
            InitializeComponent();
            BuildForm();
        }

        /// <summary>
        /// Puts data from the product into text boxes on the form, calculates the total for the user
        /// </summary>
        private void BuildForm()
        {
            ConditionTextBox.Text = _computer.condition;
            PlatformTextBox.Text = _computer.platform;
            ManufacturerTextBox.Text = _computer.manufacturer;
            ModelTextBox.Text = _computer.model;
            SpecsRichTextBox.Text = _computer.displaytype + "\n" +
                                    _computer.RAM_size + "\n" +
                                    _computer.CPU_brand + "\n" +
                                    _computer.CPU_type + "\n" +
                                    _computer.CPU_number + "\n" +
                                    _computer.CPU_speed + "\n" +
                                    _computer.HDD_size + "\n" +
                                    _computer.GPU_Type + "\n" +
                                    _computer.webcam + "\n" +
                                    _computer.OS;
            PriceTextBox.Text = Convert.ToString(_computer.cost);
            SalesTaxTextBox.Text = "13%";
            TotalTextBox.Text = Convert.ToString((double)_computer.cost * 1.13);
        }

        /// <summary>
        /// Brings the user back to the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Dispose();
        }

        /// <summary>
        /// Cancels the Order and Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Prompts the user with a goodbye, and exits of accepted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank you for you business,\nYour order will be processed within 7-10 business days.", "Thank you!", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Displays a message to the user that their order is printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is now printing.", "Print");
        }
    }
}
