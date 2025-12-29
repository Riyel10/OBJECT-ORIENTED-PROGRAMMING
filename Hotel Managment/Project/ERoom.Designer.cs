namespace Project
{
    partial class ERoom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchNumber = new System.Windows.Forms.Button();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgbRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnSearchName);
            this.panel1.Controls.Add(this.btnSearchNumber);
            this.panel1.Controls.Add(this.txtSearchNumber);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Controls.Add(this.dgbRoom);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 448);
            this.panel1.TabIndex = 3;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(85, 112);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(138, 34);
            this.btnSearchName.TabIndex = 28;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearchNumber
            // 
            this.btnSearchNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNumber.Location = new System.Drawing.Point(410, 112);
            this.btnSearchNumber.Name = "btnSearchNumber";
            this.btnSearchNumber.Size = new System.Drawing.Size(138, 34);
            this.btnSearchNumber.TabIndex = 27;
            this.btnSearchNumber.Text = "Search";
            this.btnSearchNumber.UseVisualStyleBackColor = true;
            this.btnSearchNumber.Click += new System.EventHandler(this.btnSearchNumber_Click);
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchNumber.Location = new System.Drawing.Point(378, 73);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(219, 20);
            this.txtSearchNumber.TabIndex = 26;
            this.txtSearchNumber.Text = "Search By Number";
            // 
            // txtSearchName
            // 
            this.txtSearchName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchName.Location = new System.Drawing.Point(44, 73);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(219, 20);
            this.txtSearchName.TabIndex = 25;
            this.txtSearchName.Text = "Search By Name";
            // 
            // dgbRoom
            // 
            this.dgbRoom.AllowUserToAddRows = false;
            this.dgbRoom.AllowUserToDeleteRows = false;
            this.dgbRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgbRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgbRoom.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgbRoom.Location = new System.Drawing.Point(0, 218);
            this.dgbRoom.Name = "dgbRoom";
            this.dgbRoom.ReadOnly = true;
            this.dgbRoom.Size = new System.Drawing.Size(639, 230);
            this.dgbRoom.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RId";
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "RName";
            this.Column2.HeaderText = "Room Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RType";
            this.Column3.HeaderText = "Room Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RStatus";
            this.Column4.HeaderText = "Room Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Information";
            // 
            // ERoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ERoom";
            this.Size = new System.Drawing.Size(643, 454);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchNumber;
        private System.Windows.Forms.TextBox txtSearchNumber;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgbRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
