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
    public partial class User : UserControl
    {
        private DataAccess Da { get; set; }
        public User()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PopulateGidView();
            this.AutoIdGenerate();
            this.dgvUserinfo.ClearSelection();
        }
        public void PopulateGidView(string sql = "select * from Userinfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUserinfo.AutoGenerateColumns = false;
            this.dgvUserinfo.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate()
        {
            var sql = "select Id from Userinfo order by Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "u-" + (++num).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Userinfo where Id = '" + this.txtSearch.Text + "';";
            this.PopulateGidView(sql);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGidView();
        }

        private void dgvUserinfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvUserinfo.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvUserinfo.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvUserinfo.CurrentRow.Cells[2].Value.ToString();
            this.txtRole.Text = this.dgvUserinfo.CurrentRow.Cells[3].Value.ToString();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtPassword.Text)
            || String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtRole.Text))
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtRole.Clear();
            this.txtPassword.Text = "";
            this.txtName.Clear();
            this.txtUserId.Clear();
            this.dgvUserinfo.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                var sql = "select * from Userinfo where Id = '" + this.txtUserId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    query = @"update Userinfo
                            set Name = '" + this.txtName.Text + @"',
                            Password = '" + this.txtPassword.Text + @"',
                            Role = '" + this.txtRole.Text + @"'
                            where Id = '" + this.txtUserId.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data updated Success");
                    else
                        MessageBox.Show("User data upgradation failed");
                }
                else
                {
                    //insert
                    query = "insert into Userinfo values('" + this.txtUserId.Text + "', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtRole.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data added Succes");
                    else
                        MessageBox.Show("User data saving failed");
                }

                this.PopulateGidView();
                this.ClearAll();
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
                if (this.dgvUserinfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var Id = this.dgvUserinfo.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgvUserinfo.CurrentRow.Cells[1].Value.ToString();
                //MessageBox.Show(id+title);
                var query = "delete from Userinfo where Id = '" + Id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("User data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(this.txtSearch.Text == "Search by ID")
            {
                this.txtSearch.Text = string.Empty;
                this.txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "")
            {
                this.txtSearch.Text = "Search by ID";
                this.txtSearch.ForeColor = Color.DimGray;
            }
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchName.Text == "Search by Name")
            {
                this.txtSearchName.Text = string.Empty;
                this.txtSearchName.ForeColor = Color.Black;
            }
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchName.Text == "")
            {
                this.txtSearchName.Text = "Search by Name";
                this.txtSearchName.ForeColor = Color.DimGray;
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Userinfo where Name like '%" + this.txtSearchName.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
