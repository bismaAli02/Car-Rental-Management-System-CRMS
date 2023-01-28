namespace CRMSV4.GUI.Cust_sForm
{
    partial class ReturnCarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AllCarBtn = new System.Windows.Forms.Button();
            this.InvoiceBtn = new System.Windows.Forms.Button();
            this.SortedBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.CarUnBudBtn = new System.Windows.Forms.Button();
            this.MainBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(193, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 113);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Car";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(193, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 337);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(116, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car On Rent";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.AllCarBtn);
            this.panel2.Controls.Add(this.InvoiceBtn);
            this.panel2.Controls.Add(this.SortedBtn);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.CarUnBudBtn);
            this.panel2.Controls.Add(this.MainBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 450);
            this.panel2.TabIndex = 0;
            // 
            // AllCarBtn
            // 
            this.AllCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCarBtn.Location = new System.Drawing.Point(3, 178);
            this.AllCarBtn.Name = "AllCarBtn";
            this.AllCarBtn.Size = new System.Drawing.Size(190, 44);
            this.AllCarBtn.TabIndex = 13;
            this.AllCarBtn.Text = "All Cars";
            this.AllCarBtn.UseVisualStyleBackColor = true;
            this.AllCarBtn.Click += new System.EventHandler(this.AllCarBtn_Click);
            // 
            // InvoiceBtn
            // 
            this.InvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceBtn.Location = new System.Drawing.Point(3, 306);
            this.InvoiceBtn.Name = "InvoiceBtn";
            this.InvoiceBtn.Size = new System.Drawing.Size(190, 44);
            this.InvoiceBtn.TabIndex = 12;
            this.InvoiceBtn.Text = "Generate Invoice";
            this.InvoiceBtn.UseVisualStyleBackColor = true;
            this.InvoiceBtn.Click += new System.EventHandler(this.InvoiceBtn_Click);
            // 
            // SortedBtn
            // 
            this.SortedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SortedBtn.Location = new System.Drawing.Point(3, 241);
            this.SortedBtn.Name = "SortedBtn";
            this.SortedBtn.Size = new System.Drawing.Size(190, 44);
            this.SortedBtn.TabIndex = 11;
            this.SortedBtn.Text = "Sorted Cars";
            this.SortedBtn.UseVisualStyleBackColor = true;
            this.SortedBtn.Click += new System.EventHandler(this.SortedBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.Location = new System.Drawing.Point(3, 371);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(190, 44);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "LogOut";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // CarUnBudBtn
            // 
            this.CarUnBudBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CarUnBudBtn.Location = new System.Drawing.Point(3, 113);
            this.CarUnBudBtn.Name = "CarUnBudBtn";
            this.CarUnBudBtn.Size = new System.Drawing.Size(190, 44);
            this.CarUnBudBtn.TabIndex = 9;
            this.CarUnBudBtn.Text = "Car Under Budget";
            this.CarUnBudBtn.UseVisualStyleBackColor = true;
            this.CarUnBudBtn.Click += new System.EventHandler(this.CarUnBudBtn_Click);
            // 
            // MainBtn
            // 
            this.MainBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBtn.Location = new System.Drawing.Point(3, 52);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(190, 44);
            this.MainBtn.TabIndex = 8;
            this.MainBtn.Text = "Main Menu";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // ReturnCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnCarForm";
            this.Text = "ReturnCarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnCarForm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AllCarBtn;
        private System.Windows.Forms.Button InvoiceBtn;
        private System.Windows.Forms.Button SortedBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button CarUnBudBtn;
        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}