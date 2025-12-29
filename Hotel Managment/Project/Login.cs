using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Id = '" + this.txtUserID.Text + "' and Password = '" + this.txtPassword.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                var name = ds.Tables[0].Rows[0][1].ToString();
                var role = ds.Tables[0].Rows[0][3].ToString();
                MessageBox.Show("Valid User: " + name.ToUpper());
                if (role == "Admin")
                {
                    this.Hide();
                    new Admin(name,this).Show();
                    this.txtUserID.Clear();
                    this.txtPassword.Clear();
                    Profile p = new Profile(this.txtUserID.Text,name, this.txtPassword.Text,this);
                }
                else if (role == "Receptionist")
                {
                    this.Hide();
                    new Employee(name,this).Show();
                    this.txtUserID.Clear();
                    this.txtPassword.Clear();
                }

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
