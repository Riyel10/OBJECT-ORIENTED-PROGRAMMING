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
    public partial class CheckIn : UserControl
    {
        private DataAccess Da { get; set; }
        public CheckIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIdGenerate();
            this.PopulateGidView();
        }
        public void PopulateGidView(string sql = "select * from CheckIn;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCheckin.AutoGenerateColumns = false;
            this.dgvCheckin.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate()
        {
            var sql = "select CId from CheckIn order by CId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "c-" + (++num).ToString("d3");
            this.textBox1.Text = newId;
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text)
            || String.IsNullOrEmpty(this.textBox3.Text) || String.IsNullOrEmpty(this.textBox4.Text)
            || String.IsNullOrEmpty(this.textBox5.Text) || String.IsNullOrEmpty(this.comboBox1.Text)
            || String.IsNullOrEmpty(this.dateTimePicker1.Text))
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.dateTimePicker1.Text = "";
            this.comboBox1.SelectedIndex = -1;
            this.AutoIdGenerate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                query = "insert into CheckIn values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.comboBox1.Text + "','" + this.dateTimePicker1.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)

                    MessageBox.Show("Customer data has been added successfully");
                else
                    MessageBox.Show("Please fill all the information");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
            this.ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PopulateGidView();
        }
    }
}
