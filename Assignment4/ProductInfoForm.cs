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
            CostTextBox.Text = "$" + (Math.Truncate(100 * (Decimal)computer.cost) / 100);
            PlatformTextBox.Text = computer.platform;
            OSTextBox.Text = computer.OS;
            ManufacturerTextBox.Text = computer.manufacturer;
            ModelTextBox.Text = computer.model;
            MemoryTextBox.Text = computer.RAM_size;
            LCDSizeTextBox.Text = computer.displaytype;
            HDDTextBox.Text = computer.HDD_size;
            CPUBrandTextBox.Text = computer.CPU_brand;
            CPUNumberTextBox.Text = computer.CPU_number;
            GPUTypeTextBox.Text = computer.GPU_Type;
            CPUTypeTextBox.Text = computer.CPU_type;
            CPUSpeedTextBox.Text = computer.CPU_speed;
            WebcamTextBox.Text = computer.webcam;
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
