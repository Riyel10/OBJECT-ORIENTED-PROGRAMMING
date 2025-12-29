using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Billing : Form
    {
        private CheckOut Co {  get; set; }
        public Billing()
        {
            InitializeComponent();
        }
        public Billing(CheckOut Co)
        {
            InitializeComponent();
            this.Co = Co;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Payment(this).Show();
            this.Hide();
        }

        private void Billing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Co.Show();
        }
    }
}
