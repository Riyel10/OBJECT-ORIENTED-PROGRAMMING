using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class Employee : Form
    {

        private Login l1 { get; set; }
        private CheckIn uc1 { get; set; }
        private ERoom uc2 { get; set; }
        private EProfile uc3 { get; set; }
        private CheckOut Co {  get; set; }
        public Employee()
        {
            InitializeComponent();
            this.uc1 = new CheckIn();
            this.uc2 = new ERoom();
            this.uc3 = new EProfile();
            this.Co = Co;
        }
        public Employee(string text,Login l1) : this()
        {
            this.lblWelcome.Text += text;
            this.l1 = l1;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Are you want to Log Out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == re)
            {
                this.Hide();
                this.l1.Show();
            };
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            this.pnlDashboard.Controls.Add(uc1);
            this.pnlDashboard.Controls.Remove(uc3);
            this.pnlDashboard.Controls.Remove(uc2);
            this.panel3.Visible = false;
            this.panel2.Visible = false;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckOut(this).Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.pnlDashboard.Controls.Remove(uc1);
            this.pnlDashboard.Controls.Remove(uc3);
            this.pnlDashboard.Controls.Add(uc2);
            this.panel3.Visible = false;
            this.panel2.Visible = false;
        }

        private void btnDeshboart_Click(object sender, EventArgs e)
        {
            this.pnlDashboard.Controls.Remove(uc1);
            this.pnlDashboard.Controls.Remove(uc2);
            this.pnlDashboard.Controls.Remove(uc3);
            this.panel3.Visible = true;
            this.panel2.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.pnlDashboard.Controls.Remove(uc1);
            this.pnlDashboard.Controls.Remove(uc2);
            this.pnlDashboard.Controls.Add(uc3);
            this.panel3.Visible = false;
            this.panel2.Visible = false;
        }
    }
}
