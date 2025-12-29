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
    public partial class ARoom : UserControl
    {
        private DataAccess Da { get; set; }
        public ARoom()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
            this.AutoIdGenerate();
            this.dgbRoom.ClearSelection();
        }
        public void PopulateGidView(string sql = "select * from Room;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgbRoom.AutoGenerateColumns = false;
            this.dgbRoom.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate()
        {
            var sql = "select RId from Room order by RId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "r-" + (++num).ToString("d3");
            this.txtRoomNumber.Text = newId;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGidView();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtRoomName.Text) || String.IsNullOrEmpty(this.txtRoomNumber.Text)
            || String.IsNullOrEmpty(this.comboBox1.Text) || String.IsNullOrEmpty(this.comboBox2.Text))
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtRoomName.Clear();
            this.txtRoomNumber.Clear();
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            this.AutoIdGenerate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearAll();
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
                var sql = "select * from Room where RId = '" + this.txtRoomNumber.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    query = @"update Userinfo
                            set RName = '" + this.txtRoomName.Text + @"',
                            RType = '" + this.comboBox1.Text + @"',
                            RStatus = '" + this.comboBox2.Text + @"'
                            where RId = '" + this.txtRoomNumber.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Room data has been updated success");
                    else
                        MessageBox.Show("Room data upgradation failed");
                }
                else
                {
                    //insert
                    query = "insert into Room values('" + this.txtRoomNumber.Text + "', '" + this.txtRoomName.Text + "', '" + this.comboBox1.Text + "', '" + this.comboBox2.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Room data has been added properly");
                    else
                        MessageBox.Show("Room data saving failed");
                }

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please select a row first to load the data or Fill all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
                var Id = this.dgbRoom.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgbRoom.CurrentRow.Cells[1].Value.ToString();
                var query = "delete from Room where RId = '" + Id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Room data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
            this.ClearAll();
        }

        private void dgbRoom_DoubleClick(object sender, EventArgs e)
        {
            this.txtRoomNumber.Text = this.dgbRoom.CurrentRow.Cells[0].Value.ToString();
            this.txtRoomName.Text = this.dgbRoom.CurrentRow.Cells[1].Value.ToString();
            this.comboBox1.Text = this.dgbRoom.CurrentRow.Cells[2].Value.ToString();
            this.comboBox2.Text = this.dgbRoom.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Room where RId = '" + this.txtSearch.Text + "';";
            this.PopulateGidView(sql);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "Search by ID")
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
    }
}
