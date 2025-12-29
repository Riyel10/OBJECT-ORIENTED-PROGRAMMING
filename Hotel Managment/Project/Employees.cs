using System;
using System.Collections;
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
    public partial class Employees : UserControl
    {
        private DataAccess Da { get; set; }
        public Employees()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
            this.AutoIdGenerate();
            this.dgvEmployee.ClearSelection();
        }

        public void PopulateGidView(string sql = "select * from Employee;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGidView();
        }

        private void AutoIdGenerate()
        {
            var sql = "select Id from Employee order by Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "E-" + (++num).ToString("d3");
            this.txtID.Text = newId;
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            var sql = "select * from Employee where Id like '%" + this.txtSearchId.Text + "%';";
            this.PopulateGidView(sql);
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            var sql = "select * from Employee where Name like '" + this.txtSearchName.Text + "%';";
            this.PopulateGidView(sql);
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            this.txtSearchId.Clear();
            this.txtSearchName.Clear();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtRole.Text)
            || String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPhone.Text)
            || String.IsNullOrEmpty(this.comboBox1.Text) || String.IsNullOrEmpty(this.dateTimePicker1.Text)
            || String.IsNullOrEmpty(this.txtSalary.Text))
                return false;
            else
                return true;
        }
        private bool IsValidToLoad()
        {
            if (String.IsNullOrEmpty(this.txtID1.Text) || String.IsNullOrEmpty(this.txtRole1.Text)
            || String.IsNullOrEmpty(this.txtName1.Text) || String.IsNullOrEmpty(this.txtPhone1.Text)
            || String.IsNullOrEmpty(this.comboBox2.Text) || String.IsNullOrEmpty(this.dateTimePicker2.Text)
            || String.IsNullOrEmpty(this.txtSalary1.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtRole.Clear();
            this.txtPhone.Clear();
            this.txtSalary.Clear();
            this.dateTimePicker1.Text = "";
            this.comboBox1.SelectedIndex = -1;
            this.AutoIdGenerate();
        }
        private void ClearAll1()
        {
            this.txtID1.Clear();
            this.txtName1.Clear();
            this.txtRole1.Clear();
            this.txtPhone1.Clear();
            this.txtSalary1.Clear();
            this.dateTimePicker2.Text = "";
            this.comboBox2.SelectedIndex = -1;
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                query = "insert into Employee values('" + this.txtID.Text + "', '" + this.txtName.Text + "', '" + this.txtRole.Text + "','" + this.dateTimePicker1.Text + "','" + this.comboBox1.Text + "','" + this.txtSalary.Text + "','" + this.txtPhone.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)

                    MessageBox.Show("Employee data has been added properly");
                else
                    MessageBox.Show("Please fill all the information");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
            this.ClearAll();
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            this.ClearAll1();

        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            this.ClearAll1();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToLoad())
                {
                    MessageBox.Show("Please select a row first from 'Search Employee' to load the data or Fill all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string query = null;
                var sql = "select * from Employee where Id = '" + this.txtID1.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                DialogResult result = MessageBox.Show("Confirm the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                query = @"update Employee
                            set Name = '" + this.txtName1.Text + @"',
                            Role = '" + this.txtRole1.Text + @"',
                            DOB = '" + this.dateTimePicker2.Text + @"',
                            Gender = '" + this.comboBox2.Text + @"',
                            Phone = " + this.txtPhone1.Text + @", 
                            Salary = " + this.txtSalary1.Text + @"
                            where Id = '" + this.txtID1.Text + "'; ";

                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show("Employee data has been updated properly");
                else
                    MessageBox.Show("Empployee data upgradation failed");

                this.PopulateGidView();
                this.ClearAll1();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToLoad())
                {
                    MessageBox.Show("Please select a row first from 'Search Employee' to load the data or Fill all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
                var Id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                var query = "delete from Employee where Id = '" + Id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Employee data remove failed");

                this.PopulateGidView();
                this.ClearAll1();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
            this.ClearAll1();
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtID1.Text = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            this.txtName1.Text = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            this.txtRole1.Text = this.dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            this.dateTimePicker2.Text = this.dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            this.comboBox2.Text = this.dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            this.txtSalary1.Text = this.dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            this.txtPhone1.Text = this.dgvEmployee.CurrentRow.Cells[6].Value.ToString();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dgvEmployee.ClearSelection();
        }
    }
}