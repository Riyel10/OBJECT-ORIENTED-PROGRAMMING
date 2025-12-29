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
    public partial class CheckOut : Form
    {
        private DataAccess Da { get; set; }
        private Employee Em {  get; set; }
        public CheckOut()
        {
            InitializeComponent();
        }
        public CheckOut(Employee Em)
        {
            InitializeComponent();
            this.Em = Em;
            this.Da = new DataAccess();
            this.PopulateGidView();
        }
        public void PopulateGidView(string sql = "select * from CheckIn;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCheckIn.AutoGenerateColumns = false;
            this.dgvCheckIn.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Em.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            new Billing(this).Show();
            this.Hide();
        }

        private void CheckOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvCheckIn_DoubleClick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.dgvCheckIn.CurrentRow.Cells[0].Value.ToString();
            this.textBox2.Text = this.dgvCheckIn.CurrentRow.Cells[1].Value.ToString();
            this.textBox3.Text = this.dgvCheckIn.CurrentRow.Cells[2].Value.ToString();
            this.textBox4.Text = this.dgvCheckIn.CurrentRow.Cells[3].Value.ToString();
            this.textBox5.Text = this.dgvCheckIn.CurrentRow.Cells[4].Value.ToString();
            this.comboBox1.Text = this.dgvCheckIn.CurrentRow.Cells[5].Value.ToString();
            this.dateTimePicker1.Text = this.dgvCheckIn.CurrentRow.Cells[6].Value.ToString();
            this.textBox8.Text = this.dgvCheckIn.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
