namespace Project
{
    partial class Payment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDeshboard = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnNagad = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnBkash = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDeshboard.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeshboard
            // 
            this.pnlDeshboard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlDeshboard.Controls.Add(this.button1);
            this.pnlDeshboard.Controls.Add(this.btnCash);
            this.pnlDeshboard.Controls.Add(this.btnNagad);
            this.pnlDeshboard.Controls.Add(this.btnCard);
            this.pnlDeshboard.Controls.Add(this.btnBkash);
            this.pnlDeshboard.Controls.Add(this.panel3);
            this.pnlDeshboard.Location = new System.Drawing.Point(-2, 1);
            this.pnlDeshboard.Name = "pnlDeshboard";
            this.pnlDeshboard.Size = new System.Drawing.Size(804, 448);
            this.pnlDeshboard.TabIndex = 4;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Turquoise;
            this.btnCash.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(312, 306);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(180, 49);
            this.btnCash.TabIndex = 8;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnNagad
            // 
            this.btnNagad.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNagad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNagad.Location = new System.Drawing.Point(312, 242);
            this.btnNagad.Name = "btnNagad";
            this.btnNagad.Size = new System.Drawing.Size(180, 46);
            this.btnNagad.TabIndex = 7;
            this.btnNagad.Text = "Nagad";
            this.btnNagad.UseVisualStyleBackColor = false;
            this.btnNagad.Click += new System.EventHandler(this.btnNagad_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.Turquoise;
            this.btnCard.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.Location = new System.Drawing.Point(312, 174);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(180, 48);
            this.btnCard.TabIndex = 6;
            this.btnCard.Text = "Bank Card";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnBkash
            // 
            this.btnBkash.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBkash.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBkash.Location = new System.Drawing.Point(312, 108);
            this.btnBkash.Name = "btnBkash";
            this.btnBkash.Size = new System.Drawing.Size(180, 49);
            this.btnBkash.TabIndex = 5;
            this.btnBkash.Text = "Bkash";
            this.btnBkash.UseVisualStyleBackColor = false;
            this.btnBkash.Click += new System.EventHandler(this.btnBkash_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(114, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 59);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Payment Methood";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDeshboard);
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.pnlDeshboard.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeshboard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnNagad;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnBkash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}