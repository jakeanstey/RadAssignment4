using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        private Form PreviousForm;
        public SelectForm(Form PreviousForm)
        {
            InitializeComponent();
            this.PreviousForm = PreviousForm;
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
