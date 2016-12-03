using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Assignment4.Models;
using System.Diagnostics;

namespace Assignment4
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Program.startForm = this;
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Opens a file dialog box for the user to select a previous order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = file.ShowDialog();

            if(result != DialogResult.Cancel)
            {
                try
                {
                    StreamReader sr = new StreamReader(file.FileName);
                    ProductInfoForm pif = new ProductInfoForm(toProduct(sr));
                    pif.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    Debug.WriteLine("File is invalid");
                }
            }
        }

        /// <summary>
        /// Opens the select computer form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Runs when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Takes a stringn from the save file and converts it back into a Product
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Product toProduct(StreamReader reader)
        {
            string productAsString = "";
            while(reader.Peek() != -1)
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
    }
}
