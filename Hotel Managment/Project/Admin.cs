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
    public partial class Admin : Form
    {
        private DataAccess Da { get; set; }
        private Login l1 { get; set; }
        private Employees uc1 { get; set; }
        private Profile uc2 { get; set; }
        private User uc3 { get; set; }
        private ARoom uc4 { get; set; }
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string text,Login l1) : this()
        {
            this.lblWelcom.Text += text;
            this.l1 = l1;
            this.Da = new DataAccess();
            this.uc1 = new Employees();
            this.uc2 = new Profile();
            this.uc3 = new User();
            this.uc4 = new ARoom();
            this.PopulateGidView();
        }
        public void PopulateGidView(string sql = "select * from Userinfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUserinfo.AutoGenerateColumns = false;
            this.dgvUserinfo.DataSource = ds.Tables[0];
        }

            private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Are you want to Log Out","Log Out",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==re)
            {
                this.Hide();
                this.l1.Show();
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.pnlDeshboard.Controls.Add(uc1);
            this.pnlDeshboard.Controls.Remove(uc2);
            this.pnlDeshboard.Controls.Remove(uc3);
            this.pnlDeshboard.Controls.Remove(uc4);
            this.panel2.Visible = false;
            this.panel4.Visible = false;
        }

        private void btnDeshboart_Click(object sender, EventArgs e)
        {
            this.pnlDeshboard.Controls.Remove(uc1);
            this.pnlDeshboard.Controls.Remove(uc2);
            this.pnlDeshboard.Controls.Remove(uc3);
            this.pnlDeshboard.Controls.Remove(uc4);
            this.panel2.Visible = true;
            this.panel4.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.pnlDeshboard.Controls.Remove(uc1);
            this.pnlDeshboard.Controls.Remove(uc3);
            this.pnlDeshboard.Controls.Remove(uc4);
            this.panel2.Visible = false;
            this.pnlDeshboard.Controls.Add(uc2);
            this.panel4.Visible = false;
        }

        private void btnMangeuser_Click(object sender, EventArgs e)
        {
            this.pnlDeshboard.Controls.Remove(uc1);
            this.panel2.Visible = false;
            this.pnlDeshboard.Controls.Remove(uc2);
            this.pnlDeshboard.Controls.Remove(uc4);
            this.pnlDeshboard.Controls.Add(uc3);
            this.panel4.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.pnlDeshboard.Controls.Remove(uc1);
            this.pnlDeshboard.Controls.Remove(uc2);
            this.pnlDeshboard.Controls.Remove(uc3);
            this.pnlDeshboard.Controls.Remove(uc4);
            this.pnlDeshboard.Controls.Add(uc4);
            this.panel2.Visible = false;
            this.panel4.Visible = false;
        }
    }
}
