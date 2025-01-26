namespace Aquaters_Capstone_
{
    partial class PersonalInfo
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
            this.txName = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txContactNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(40, 73);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(231, 38);
            this.txName.TabIndex = 0;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(37, 44);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(40, 170);
            this.txAddress.Multiline = true;
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(231, 141);
            this.txAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // txContactNo
            // 
            this.txContactNo.Location = new System.Drawing.Point(319, 73);
            this.txContactNo.Multiline = true;
            this.txContactNo.Name = "txContactNo";
            this.txContactNo.Size = new System.Drawing.Size(231, 38);
            this.txContactNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact No.";
            // 
            // txDone
            // 
            this.txDone.Location = new System.Drawing.Point(40, 348);
            this.txDone.Name = "txDone";
            this.txDone.Size = new System.Drawing.Size(212, 34);
            this.txDone.TabIndex = 5;
            this.txDone.Text = "Done";
            this.txDone.UseVisualStyleBackColor = true;
            this.txDone.Click += new System.EventHandler(this.txDone_Click);
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 394);
            this.Controls.Add(this.txDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txContactNo);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txName);
            this.Name = "PersonalInfo";
            this.Text = "PersonalInfo";
            this.Load += new System.EventHandler(this.PersonalInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txDone;
        public System.Windows.Forms.TextBox txName;
        public System.Windows.Forms.TextBox txAddress;
        public System.Windows.Forms.TextBox txContactNo;
    }
}