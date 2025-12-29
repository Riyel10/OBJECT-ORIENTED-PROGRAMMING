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
    public partial class Payment : Form
    {
        private Billing Bi {set; get; }
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(Billing Bi)
        {
            InitializeComponent();
            this.Bi = Bi;
        }

        private void btnBkash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void btnNagad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Bi.Show();
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
