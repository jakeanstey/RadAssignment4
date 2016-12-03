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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Assignment4
{
    public partial class ProductInfoForm : Form
    {
        private Product _computer;
        private Form _previousForm;
        public ProductInfoForm(Product computer)
        {
            this._computer = computer;
            InitializeComponent();
            displayCriteria();
        }

        /// <summary>
        /// Overloaded constructor that takes a previous form
        /// </summary>
        /// <param name="computer"></param>
        /// <param name="previousForm"></param>
        public ProductInfoForm(Product computer, Form previousForm)
        {
            this._computer = computer;
            this._previousForm = previousForm;
            InitializeComponent();
            displayCriteria();
        }

        /// <summary>
        /// Sets the text boxes with the correct values
        /// </summary>
        private void displayCriteria()
        {
            ProductIDTextBox.Text = "" + _computer.productID;
            ConditionTextBox.Text = _computer.condition;
            CostTextBox.Text = "$" + (Math.Truncate(100 * (Decimal)_computer.cost) / 100);
            PlatformTextBox.Text = _computer.platform;
            OSTextBox.Text = _computer.OS;
            ManufacturerTextBox.Text = _computer.manufacturer;
            ModelTextBox.Text = _computer.model;
            MemoryTextBox.Text = _computer.RAM_size;
            LCDSizeTextBox.Text = _computer.displaytype;
            HDDTextBox.Text = _computer.HDD_size;
            CPUBrandTextBox.Text = _computer.CPU_brand;
            CPUNumberTextBox.Text = _computer.CPU_number;
            GPUTypeTextBox.Text = _computer.GPU_Type;
            CPUTypeTextBox.Text = _computer.CPU_type;
            CPUSpeedTextBox.Text = _computer.CPU_speed;
            WebcamTextBox.Text = _computer.webcam;
        }

        /// <summary>
        /// Opens a file dialog box for the user to select their previous order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = file.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                try
                {
                    StreamReader sr = new StreamReader(file.FileName);
                    this._computer = toProduct(sr);
                    displayCriteria();
                }
                catch (Exception)
                {

                }
            }
        }

        /// <summary>
        /// Calls on the save oredr method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrder();
        }

        /// <summary>
        /// Sends the user to the Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_computer, this);
            orderForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Saves the users order with the Menufacturer and Model of the laptop as the name
        /// </summary>
        private void SaveOrder()
        {
            StreamWriter writer = new StreamWriter(_computer.manufacturer + "-" + _computer.model + ".dco", true);
            writer.Write(toString(_computer));
            writer.Close();
        }

        /// <summary>
        /// Takes a product object and converts it into a string to be saved
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private string toString(Product product)
        {
            XmlSerializer serializer = new XmlSerializer(product.GetType());
            using (StringWriter sw = new StringWriter())
            {
                serializer.Serialize(sw, product);
                return sw.ToString();
            }
        }

        /// <summary>
        /// Takes the save file and converts it back into a product object
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Product toProduct(StreamReader reader)
        {
            string productAsString = "";
            while (reader.Peek() != -1)
            {
                productAsString += reader.ReadLine();
            }
            reader.Close();

            XmlSerializer deserializer = new XmlSerializer(typeof(Product));
            using (TextReader tr = new StringReader(productAsString))
            {
                return (Product)deserializer.Deserialize(tr);
            }
        }

        /// <summary>
        /// Send the user back to the Select Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (_previousForm != null)
            {
                _previousForm.Show();
                this.Dispose();
            }
            else
            {
                SelectForm selectForm = new SelectForm();
                selectForm.Show();
                this.Dispose();
            }
        }
    }
}
