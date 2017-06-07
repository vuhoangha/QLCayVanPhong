namespace KhoaLuan
{
    partial class AddBill
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddBill = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnBillDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbAddBillToTalBill = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddBillExport = new System.Windows.Forms.Button();
            this.btnBillAddTree = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBillUpdateTree = new System.Windows.Forms.Button();
            this.dgvPdf = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddBill
            // 
            this.dgvAddBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvAddBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.TotalCost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvAddBill.Location = new System.Drawing.Point(24, 53);
            this.dgvAddBill.MultiSelect = false;
            this.dgvAddBill.Name = "dgvAddBill";
            this.dgvAddBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAddBill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAddBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvAddBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAddBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvAddBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAddBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddBill.Size = new System.Drawing.Size(457, 167);
            this.dgvAddBill.TabIndex = 6;
            this.dgvAddBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddBill_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã cây";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên cây";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalCost.HeaderText = "Thành tiền(VND)";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CMT";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(627, 50);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(218, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(627, 106);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(218, 20);
            this.txtCustomerId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(627, 164);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // btnBillDel
            // 
            this.btnBillDel.BackColor = System.Drawing.Color.Transparent;
            this.btnBillDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillDel.FlatAppearance.BorderSize = 0;
            this.btnBillDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBillDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBillDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillDel.Image = ((System.Drawing.Image)(resources.GetObject("btnBillDel.Image")));
            this.btnBillDel.Location = new System.Drawing.Point(444, 11);
            this.btnBillDel.Name = "btnBillDel";
            this.btnBillDel.Size = new System.Drawing.Size(35, 35);
            this.btnBillDel.TabIndex = 2;
            this.btnBillDel.UseVisualStyleBackColor = false;
            this.btnBillDel.Click += new System.EventHandler(this.btnBillDel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(564, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tổng tiền";
            // 
            // lbAddBillToTalBill
            // 
            this.lbAddBillToTalBill.AutoSize = true;
            this.lbAddBillToTalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddBillToTalBill.ForeColor = System.Drawing.Color.Gray;
            this.lbAddBillToTalBill.Location = new System.Drawing.Point(685, 308);
            this.lbAddBillToTalBill.Name = "lbAddBillToTalBill";
            this.lbAddBillToTalBill.Size = new System.Drawing.Size(27, 29);
            this.lbAddBillToTalBill.TabIndex = 19;
            this.lbAddBillToTalBill.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(802, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "VND";
            // 
            // btnAddBillExport
            // 
            this.btnAddBillExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillExport.Location = new System.Drawing.Point(728, 379);
            this.btnAddBillExport.Name = "btnAddBillExport";
            this.btnAddBillExport.Size = new System.Drawing.Size(129, 44);
            this.btnAddBillExport.TabIndex = 21;
            this.btnAddBillExport.Text = "Xuất hóa đơn";
            this.btnAddBillExport.UseVisualStyleBackColor = true;
            this.btnAddBillExport.Click += new System.EventHandler(this.btnAddBillExport_Click);
            // 
            // btnBillAddTree
            // 
            this.btnBillAddTree.BackColor = System.Drawing.Color.Transparent;
            this.btnBillAddTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillAddTree.FlatAppearance.BorderSize = 0;
            this.btnBillAddTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBillAddTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBillAddTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAddTree.Image = ((System.Drawing.Image)(resources.GetObject("btnBillAddTree.Image")));
            this.btnBillAddTree.Location = new System.Drawing.Point(348, 11);
            this.btnBillAddTree.Name = "btnBillAddTree";
            this.btnBillAddTree.Size = new System.Drawing.Size(35, 35);
            this.btnBillAddTree.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnBillAddTree, "Thêm cây");
            this.btnBillAddTree.UseVisualStyleBackColor = false;
            this.btnBillAddTree.Click += new System.EventHandler(this.btnBillAddTree_Click);
            // 
            // btnBillUpdateTree
            // 
            this.btnBillUpdateTree.BackColor = System.Drawing.Color.Transparent;
            this.btnBillUpdateTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillUpdateTree.FlatAppearance.BorderSize = 0;
            this.btnBillUpdateTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBillUpdateTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBillUpdateTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillUpdateTree.Image = ((System.Drawing.Image)(resources.GetObject("btnBillUpdateTree.Image")));
            this.btnBillUpdateTree.Location = new System.Drawing.Point(397, 11);
            this.btnBillUpdateTree.Name = "btnBillUpdateTree";
            this.btnBillUpdateTree.Size = new System.Drawing.Size(35, 35);
            this.btnBillUpdateTree.TabIndex = 23;
            this.btnBillUpdateTree.UseVisualStyleBackColor = false;
            this.btnBillUpdateTree.Click += new System.EventHandler(this.btnBillUpdateTree_Click);
            // 
            // dgvPdf
            // 
            this.dgvPdf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPdf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPdf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPdf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPdf.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPdf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvPdf.Location = new System.Drawing.Point(22, 246);
            this.dgvPdf.MultiSelect = false;
            this.dgvPdf.Name = "dgvPdf";
            this.dgvPdf.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPdf.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPdf.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPdf.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPdf.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPdf.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPdf.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPdf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPdf.Size = new System.Drawing.Size(457, 289);
            this.dgvPdf.TabIndex = 6;
            this.dgvPdf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddBill_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 547);
            this.Controls.Add(this.btnBillDel);
            this.Controls.Add(this.btnBillUpdateTree);
            this.Controls.Add(this.btnBillAddTree);
            this.Controls.Add(this.btnAddBillExport);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbAddBillToTalBill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPdf);
            this.Controls.Add(this.dgvAddBill);
            this.Name = "AddBill";
            this.Text = "AddBill";
            this.Load += new System.EventHandler(this.AddBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnBillDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbAddBillToTalBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddBillExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.Button btnBillAddTree;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBillUpdateTree;
        private System.Windows.Forms.DataGridView dgvPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}