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
    public partial class SplashscreenForm : Form
    {
        public SplashscreenForm()
        {
            InitializeComponent();
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            StartTimer.Dispose();
            StartForm startForm = new Assignment4.StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}
