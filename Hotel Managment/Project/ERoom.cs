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
    public partial class ERoom : UserControl
    {
        private DataAccess Da { get; set; }
        public ERoom()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
            this.dgbRoom.ClearSelection();
        }
        public void PopulateGidView(string sql = "select * from Room;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgbRoom.AutoGenerateColumns = false;
            this.dgbRoom.DataSource = ds.Tables[0];
        }
        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchName.Text == "Search By Name")
            {
                this.txtSearchName.Text = string.Empty;
                this.txtSearchName.ForeColor = Color.Black;
            }
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchName.Text == "")
            {
                this.txtSearchName.Text = "Search By Name";
                this.txtSearchName.ForeColor = Color.DimGray;
            }
        }

        private void txtSearchNumber_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchName.Text == "Search By Number")
            {
                this.txtSearchName.Text = string.Empty;
                this.txtSearchName.ForeColor = Color.Black;
            }
        }

        private void txtSearchNumber_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchName.Text == "")
            {
                this.txtSearchName.Text = "Search By Number";
                this.txtSearchName.ForeColor = Color.DimGray;
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            var sql = "select * from Room where RName like '" + this.txtSearchName.Text + "%';";
            this.PopulateGidView(sql);
        }

        private void btnSearchNumber_Click(object sender, EventArgs e)
        {
            var sql = "select * from Room where RId like '%" + this.txtSearchNumber.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
