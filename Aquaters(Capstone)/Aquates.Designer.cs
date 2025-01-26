namespace Aquaters_Capstone_
{
    partial class Aquaters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aquaters));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnAdsOrderNow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnRefill);
            this.panel2.Controls.Add(this.btnDeliver);
            this.panel2.Controls.Add(this.panel1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnAccount
            // 
            resources.ApplyResources(this.btnAccount, "btnAccount");
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProduct
            // 
            resources.ApplyResources(this.btnProduct, "btnProduct");
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnRefill
            // 
            resources.ApplyResources(this.btnRefill, "btnRefill");
            this.btnRefill.FlatAppearance.BorderSize = 0;
            this.btnRefill.ForeColor = System.Drawing.Color.White;
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDeliver
            // 
            resources.ApplyResources(this.btnDeliver, "btnDeliver");
            this.btnDeliver.FlatAppearance.BorderSize = 0;
            this.btnDeliver.ForeColor = System.Drawing.Color.White;
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.CausesValidation = false;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pnMain, "pnMain");
            this.pnMain.Controls.Add(this.button1);
            this.pnMain.Controls.Add(this.btnAdsOrderNow);
            this.pnMain.Name = "pnMain";
            // 
            // btnAdsOrderNow
            // 
            resources.ApplyResources(this.btnAdsOrderNow, "btnAdsOrderNow");
            this.btnAdsOrderNow.FlatAppearance.BorderSize = 0;
            this.btnAdsOrderNow.Name = "btnAdsOrderNow";
            this.btnAdsOrderNow.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Aquaters
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Aquaters";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdsOrderNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

