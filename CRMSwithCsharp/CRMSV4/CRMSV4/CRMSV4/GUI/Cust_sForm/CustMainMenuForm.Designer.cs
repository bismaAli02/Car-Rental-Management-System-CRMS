namespace CRMSV4.GUI.Cust_sForm
{
    partial class CustMainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustMainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.InvoiceBtn = new System.Windows.Forms.Button();
            this.SortedBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.AllCarBtn = new System.Windows.Forms.Button();
            this.CarUnBudBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReturnBtn);
            this.panel1.Controls.Add(this.InvoiceBtn);
            this.panel1.Controls.Add(this.SortedBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.AllCarBtn);
            this.panel1.Controls.Add(this.CarUnBudBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBtn.Location = new System.Drawing.Point(0, 298);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(200, 44);
            this.ReturnBtn.TabIndex = 19;
            this.ReturnBtn.Text = "Return Car";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // InvoiceBtn
            // 
            this.InvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceBtn.Location = new System.Drawing.Point(0, 236);
            this.InvoiceBtn.Name = "InvoiceBtn";
            this.InvoiceBtn.Size = new System.Drawing.Size(200, 44);
            this.InvoiceBtn.TabIndex = 18;
            this.InvoiceBtn.Text = "Generate Invoice";
            this.InvoiceBtn.UseVisualStyleBackColor = true;
            this.InvoiceBtn.Click += new System.EventHandler(this.InvoiceBtn_Click);
            // 
            // SortedBtn
            // 
            this.SortedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SortedBtn.Location = new System.Drawing.Point(0, 175);
            this.SortedBtn.Name = "SortedBtn";
            this.SortedBtn.Size = new System.Drawing.Size(200, 44);
            this.SortedBtn.TabIndex = 17;
            this.SortedBtn.Text = "Sorted Cars";
            this.SortedBtn.UseVisualStyleBackColor = true;
            this.SortedBtn.Click += new System.EventHandler(this.SortedBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.Location = new System.Drawing.Point(0, 363);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(200, 44);
            this.logoutBtn.TabIndex = 16;
            this.logoutBtn.Text = "LogOut";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AllCarBtn
            // 
            this.AllCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCarBtn.Location = new System.Drawing.Point(0, 113);
            this.AllCarBtn.Name = "AllCarBtn";
            this.AllCarBtn.Size = new System.Drawing.Size(200, 44);
            this.AllCarBtn.TabIndex = 15;
            this.AllCarBtn.Text = "All Cars";
            this.AllCarBtn.UseVisualStyleBackColor = true;
            this.AllCarBtn.Click += new System.EventHandler(this.AllCarBtn_Click);
            // 
            // CarUnBudBtn
            // 
            this.CarUnBudBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CarUnBudBtn.Location = new System.Drawing.Point(0, 44);
            this.CarUnBudBtn.Name = "CarUnBudBtn";
            this.CarUnBudBtn.Size = new System.Drawing.Size(200, 44);
            this.CarUnBudBtn.TabIndex = 14;
            this.CarUnBudBtn.Text = "Car Under Budget";
            this.CarUnBudBtn.UseVisualStyleBackColor = true;
            this.CarUnBudBtn.Click += new System.EventHandler(this.CarUnBudBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustMainMenuForm";
            this.Text = "CustMainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustMainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.CustMainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button InvoiceBtn;
        private System.Windows.Forms.Button SortedBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button AllCarBtn;
        private System.Windows.Forms.Button CarUnBudBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}