using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Profile : UserControl
    {
        private Login l1 { get; set; }
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string txt,string txt1,string txt2,Login l1) : this()
        {
            InitializeComponent();
            this.label12.Text += txt;
            this.label13.Text += txt1;
            this.label14.Text += txt2;
            this.l1 = l1;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            this.pnlPassword.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.pnlPassword.Visible=false;
        }
    }
}
