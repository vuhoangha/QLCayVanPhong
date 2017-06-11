namespace KhoaLuan
{
    partial class SelectTreeBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTreeBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelectTreeLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectTreeSearch = new System.Windows.Forms.TextBox();
            this.dgvSelectTree = new System.Windows.Forms.DataGridView();
            this.dtcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBillAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSelectTreeId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSelectTreeQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSelectTreeTotalCost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSelectTreeName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectTreeQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectTreeLoad
            // 
            this.btnSelectTreeLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectTreeLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTreeLoad.FlatAppearance.BorderSize = 0;
            this.btnSelectTreeLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectTreeLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectTreeLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTreeLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectTreeLoad.Image")));
            this.btnSelectTreeLoad.Location = new System.Drawing.Point(677, 31);
            this.btnSelectTreeLoad.Name = "btnSelectTreeLoad";
            this.btnSelectTreeLoad.Size = new System.Drawing.Size(35, 35);
            this.btnSelectTreeLoad.TabIndex = 0;
            this.btnSelectTreeLoad.UseVisualStyleBackColor = false;
            this.btnSelectTreeLoad.Click += new System.EventHandler(this.btnSelectTreeLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtSelectTreeSearch
            // 
            this.txtSelectTreeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectTreeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectTreeSearch.Location = new System.Drawing.Point(436, 38);
            this.txtSelectTreeSearch.Name = "txtSelectTreeSearch";
            this.txtSelectTreeSearch.Size = new System.Drawing.Size(223, 24);
            this.txtSelectTreeSearch.TabIndex = 3;
            this.txtSelectTreeSearch.TextChanged += new System.EventHandler(this.txtTreeSearch_TextChanged);
            // 
            // dgvSelectTree
            // 
            this.dgvSelectTree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSelectTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectTree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSelectTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcId,
            this.dtcTreeName,
            this.dtcTreeType,
            this.dtcTreeCost,
            this.dtcQuantity});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectTree.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSelectTree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSelectTree.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvSelectTree.Location = new System.Drawing.Point(7, 74);
            this.dgvSelectTree.MultiSelect = false;
            this.dgvSelectTree.Name = "dgvSelectTree";
            this.dgvSelectTree.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectTree.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSelectTree.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSelectTree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectTree.Size = new System.Drawing.Size(713, 358);
            this.dgvSelectTree.TabIndex = 3;
            this.dgvSelectTree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectTree_CellClick);
            // 
            // dtcId
            // 
            this.dtcId.HeaderText = "Mã cây";
            this.dtcId.Name = "dtcId";
            this.dtcId.ReadOnly = true;
            // 
            // dtcTreeName
            // 
            this.dtcTreeName.HeaderText = "Tên cây";
            this.dtcTreeName.Name = "dtcTreeName";
            this.dtcTreeName.ReadOnly = true;
            this.dtcTreeName.Width = 200;
            // 
            // dtcTreeType
            // 
            this.dtcTreeType.HeaderText = "Loại cây";
            this.dtcTreeType.Name = "dtcTreeType";
            this.dtcTreeType.ReadOnly = true;
            this.dtcTreeType.Width = 150;
            // 
            // dtcTreeCost
            // 
            this.dtcTreeCost.HeaderText = "Giá tiền";
            this.dtcTreeCost.Name = "dtcTreeCost";
            this.dtcTreeCost.ReadOnly = true;
            this.dtcTreeCost.Width = 110;
            // 
            // dtcQuantity
            // 
            this.dtcQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcQuantity.HeaderText = "Số lượng";
            this.dtcQuantity.Name = "dtcQuantity";
            this.dtcQuantity.ReadOnly = true;
            // 
            // btnBillAdd
            // 
            this.btnBillAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnBillAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillAdd.FlatAppearance.BorderSize = 0;
            this.btnBillAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBillAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBillAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBillAdd.Image")));
            this.btnBillAdd.Location = new System.Drawing.Point(271, 11);
            this.btnBillAdd.Name = "btnBillAdd";
            this.btnBillAdd.Size = new System.Drawing.Size(35, 35);
            this.btnBillAdd.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnBillAdd, "Lựa chọn");
            this.btnBillAdd.UseVisualStyleBackColor = false;
            this.btnBillAdd.Click += new System.EventHandler(this.btnBillAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(272, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "cây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã cây";
            // 
            // lbSelectTreeId
            // 
            this.lbSelectTreeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTreeId.ForeColor = System.Drawing.Color.Black;
            this.lbSelectTreeId.Location = new System.Drawing.Point(95, 239);
            this.lbSelectTreeId.Name = "lbSelectTreeId";
            this.lbSelectTreeId.Size = new System.Drawing.Size(208, 25);
            this.lbSelectTreeId.TabIndex = 12;
            this.lbSelectTreeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên cây";
            // 
            // nudSelectTreeQuantity
            // 
            this.nudSelectTreeQuantity.ForeColor = System.Drawing.Color.Black;
            this.nudSelectTreeQuantity.Location = new System.Drawing.Point(98, 167);
            this.nudSelectTreeQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSelectTreeQuantity.Name = "nudSelectTreeQuantity";
            this.nudSelectTreeQuantity.Size = new System.Drawing.Size(167, 20);
            this.nudSelectTreeQuantity.TabIndex = 16;
            this.nudSelectTreeQuantity.ValueChanged += new System.EventHandler(this.nudSelectTreeQuantity_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thành tiền";
            // 
            // lbSelectTreeTotalCost
            // 
            this.lbSelectTreeTotalCost.AutoSize = true;
            this.lbSelectTreeTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTreeTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lbSelectTreeTotalCost.Location = new System.Drawing.Point(3, 0);
            this.lbSelectTreeTotalCost.Name = "lbSelectTreeTotalCost";
            this.lbSelectTreeTotalCost.Size = new System.Drawing.Size(16, 16);
            this.lbSelectTreeTotalCost.TabIndex = 17;
            this.lbSelectTreeTotalCost.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(25, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "VND";
            // 
            // lbSelectTreeName
            // 
            this.lbSelectTreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTreeName.ForeColor = System.Drawing.Color.Black;
            this.lbSelectTreeName.Location = new System.Drawing.Point(95, 85);
            this.lbSelectTreeName.Name = "lbSelectTreeName";
            this.lbSelectTreeName.Size = new System.Drawing.Size(208, 30);
            this.lbSelectTreeName.TabIndex = 18;
            this.lbSelectTreeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lbSelectTreeName);
            this.panel2.Controls.Add(this.btnBillAdd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nudSelectTreeQuantity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbSelectTreeId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(758, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 439);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.dgvSelectTree);
            this.panel1.Controls.Add(this.txtSelectTreeSearch);
            this.panel1.Controls.Add(this.btnSelectTreeLoad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(727, 439);
            this.panel1.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbSelectTreeTotalCost);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 321);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 37);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // SelectTreeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectTreeBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn thanh toán - Chọn cây";
            this.Load += new System.EventHandler(this.SelectTreeBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectTreeQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectTreeLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectTreeSearch;
        private System.Windows.Forms.DataGridView dgvSelectTree;
        private System.Windows.Forms.Button btnBillAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTreeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTreeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTreeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSelectTreeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSelectTreeQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSelectTreeTotalCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSelectTreeName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}