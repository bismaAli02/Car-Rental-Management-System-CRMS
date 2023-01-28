namespace CRMSV4.GUI.Cust_sForm
{
    partial class CarsUnderBudgetForm
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
            this.RentBnum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CarShowGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.InvoiceBtn = new System.Windows.Forms.Button();
            this.SortedBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.AllCarBtn = new System.Windows.Forms.Button();
            this.MainBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentBnum)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarShowGV)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.Controls.Add(this.RentBnum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadBtn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(193, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 96);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // RentBnum
            // 
            this.RentBnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RentBnum.Location = new System.Drawing.Point(161, 38);
            this.RentBnum.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.RentBnum.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.RentBnum.Name = "RentBnum";
            this.RentBnum.Size = new System.Drawing.Size(153, 20);
            this.RentBnum.TabIndex = 5;
            this.RentBnum.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Budget";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoadBtn.Location = new System.Drawing.Point(416, 55);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(91, 38);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Load Cars";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.CarShowGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(193, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 354);
            this.panel3.TabIndex = 1;
            // 
            // CarShowGV
            // 
            this.CarShowGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarShowGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CarShowGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarShowGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarShowGV.Location = new System.Drawing.Point(0, 0);
            this.CarShowGV.Name = "CarShowGV";
            this.CarShowGV.ReadOnly = true;
            this.CarShowGV.Size = new System.Drawing.Size(607, 354);
            this.CarShowGV.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.ReturnBtn);
            this.panel2.Controls.Add(this.InvoiceBtn);
            this.panel2.Controls.Add(this.SortedBtn);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.AllCarBtn);
            this.panel2.Controls.Add(this.MainBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 450);
            this.panel2.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBtn.Location = new System.Drawing.Point(1, 298);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(190, 44);
            this.ReturnBtn.TabIndex = 19;
            this.ReturnBtn.Text = "Return Car";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // InvoiceBtn
            // 
            this.InvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceBtn.Location = new System.Drawing.Point(1, 236);
            this.InvoiceBtn.Name = "InvoiceBtn";
            this.InvoiceBtn.Size = new System.Drawing.Size(190, 44);
            this.InvoiceBtn.TabIndex = 18;
            this.InvoiceBtn.Text = "Generate Invoice";
            this.InvoiceBtn.UseVisualStyleBackColor = true;
            this.InvoiceBtn.Click += new System.EventHandler(this.InvoiceBtn_Click);
            // 
            // SortedBtn
            // 
            this.SortedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SortedBtn.Location = new System.Drawing.Point(1, 175);
            this.SortedBtn.Name = "SortedBtn";
            this.SortedBtn.Size = new System.Drawing.Size(190, 44);
            this.SortedBtn.TabIndex = 17;
            this.SortedBtn.Text = "Sorted Cars";
            this.SortedBtn.UseVisualStyleBackColor = true;
            this.SortedBtn.Click += new System.EventHandler(this.SortedBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.Location = new System.Drawing.Point(1, 363);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(190, 44);
            this.logoutBtn.TabIndex = 16;
            this.logoutBtn.Text = "LogOut";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AllCarBtn
            // 
            this.AllCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCarBtn.Location = new System.Drawing.Point(1, 113);
            this.AllCarBtn.Name = "AllCarBtn";
            this.AllCarBtn.Size = new System.Drawing.Size(190, 44);
            this.AllCarBtn.TabIndex = 15;
            this.AllCarBtn.Text = "All Cars";
            this.AllCarBtn.UseVisualStyleBackColor = true;
            this.AllCarBtn.Click += new System.EventHandler(this.AllCarBtn_Click);
            // 
            // MainBtn
            // 
            this.MainBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBtn.Location = new System.Drawing.Point(1, 44);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(190, 44);
            this.MainBtn.TabIndex = 14;
            this.MainBtn.Text = "Main Menu";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // CarsUnderBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CarsUnderBudgetForm";
            this.Text = "CarsUnderBudgetForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarsUnderBudgetForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentBnum)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarShowGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView CarShowGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown RentBnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button InvoiceBtn;
        private System.Windows.Forms.Button SortedBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button AllCarBtn;
        private System.Windows.Forms.Button MainBtn;
    }
}