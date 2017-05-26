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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectTreeLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectTreeSearch = new System.Windows.Forms.TextBox();
            this.dgvSelectTree = new System.Windows.Forms.DataGridView();
            this.btnBillAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectTreeQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Honeydew;
            this.flowLayoutPanel2.Controls.Add(this.btnSelectTreeLoad);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(713, 43);
            this.flowLayoutPanel2.TabIndex = 4;
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
            this.btnSelectTreeLoad.Location = new System.Drawing.Point(675, 3);
            this.btnSelectTreeLoad.Name = "btnSelectTreeLoad";
            this.btnSelectTreeLoad.Size = new System.Drawing.Size(35, 35);
            this.btnSelectTreeLoad.TabIndex = 0;
            this.btnSelectTreeLoad.UseVisualStyleBackColor = false;
            this.btnSelectTreeLoad.Click += new System.EventHandler(this.btnSelectTreeLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSelectTreeSearch);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 35);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtSelectTreeSearch
            // 
            this.txtSelectTreeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectTreeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectTreeSearch.Location = new System.Drawing.Point(437, 6);
            this.txtSelectTreeSearch.Name = "txtSelectTreeSearch";
            this.txtSelectTreeSearch.Size = new System.Drawing.Size(223, 24);
            this.txtSelectTreeSearch.TabIndex = 3;
            this.txtSelectTreeSearch.TextChanged += new System.EventHandler(this.txtTreeSearch_TextChanged);
            // 
            // dgvSelectTree
            // 
            this.dgvSelectTree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSelectTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectTree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcId,
            this.dtcTreeName,
            this.dtcTreeType,
            this.dtcTreeCost,
            this.dtcQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectTree.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelectTree.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvSelectTree.Location = new System.Drawing.Point(1, 47);
            this.dgvSelectTree.Name = "dgvSelectTree";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectTree.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSelectTree.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvSelectTree.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSelectTree.Size = new System.Drawing.Size(713, 358);
            this.dgvSelectTree.TabIndex = 3;
            this.dgvSelectTree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectTree_CellClick);
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
            this.btnBillAdd.Location = new System.Drawing.Point(1044, 414);
            this.btnBillAdd.Name = "btnBillAdd";
            this.btnBillAdd.Size = new System.Drawing.Size(50, 50);
            this.btnBillAdd.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnBillAdd, "Thêm mới");
            this.btnBillAdd.UseVisualStyleBackColor = false;
            this.btnBillAdd.Click += new System.EventHandler(this.btnBillAdd_Click);
            // 
            // dtcQuantity
            // 
            this.dtcQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcQuantity.HeaderText = "Số lượng";
            this.dtcQuantity.Name = "dtcQuantity";
            // 
            // dtcTreeCost
            // 
            this.dtcTreeCost.HeaderText = "Giá tiền";
            this.dtcTreeCost.Name = "dtcTreeCost";
            this.dtcTreeCost.Width = 110;
            // 
            // dtcTreeType
            // 
            this.dtcTreeType.HeaderText = "Loại cây";
            this.dtcTreeType.Name = "dtcTreeType";
            this.dtcTreeType.Width = 150;
            // 
            // dtcTreeName
            // 
            this.dtcTreeName.HeaderText = "Tên cây";
            this.dtcTreeName.Name = "dtcTreeName";
            this.dtcTreeName.Width = 200;
            // 
            // dtcId
            // 
            this.dtcId.HeaderText = "Mã cây";
            this.dtcId.Name = "dtcId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "cây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã cây";
            // 
            // lbSelectTreeId
            // 
            this.lbSelectTreeId.AutoSize = true;
            this.lbSelectTreeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTreeId.ForeColor = System.Drawing.Color.Gray;
            this.lbSelectTreeId.Location = new System.Drawing.Point(95, 187);
            this.lbSelectTreeId.Name = "lbSelectTreeId";
            this.lbSelectTreeId.Size = new System.Drawing.Size(0, 16);
            this.lbSelectTreeId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(18, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên cây";
            // 
            // nudSelectTreeQuantity
            // 
            this.nudSelectTreeQuantity.Location = new System.Drawing.Point(98, 117);
            this.nudSelectTreeQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSelectTreeQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectTreeQuantity.Name = "nudSelectTreeQuantity";
            this.nudSelectTreeQuantity.Size = new System.Drawing.Size(167, 20);
            this.nudSelectTreeQuantity.TabIndex = 16;
            this.nudSelectTreeQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectTreeQuantity.ValueChanged += new System.EventHandler(this.nudSelectTreeQuantity_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(20, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thành tiền";
            // 
            // lbSelectTreeTotalCost
            // 
            this.lbSelectTreeTotalCost.AutoSize = true;
            this.lbSelectTreeTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTreeTotalCost.ForeColor = System.Drawing.Color.Gray;
            this.lbSelectTreeTotalCost.Location = new System.Drawing.Point(95, 248);
            this.lbSelectTreeTotalCost.Name = "lbSelectTreeTotalCost";
            this.lbSelectTreeTotalCost.Size = new System.Drawing.Size(16, 16);
            this.lbSelectTreeTotalCost.TabIndex = 17;
            this.lbSelectTreeTotalCost.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(155, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "VND";
            // 
            // lbSelectTreeName
            // 
            this.lbSelectTreeName.AutoSize = true;
            this.lbSelectTreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTreeName.ForeColor = System.Drawing.Color.Gray;
            this.lbSelectTreeName.Location = new System.Drawing.Point(95, 46);
            this.lbSelectTreeName.Name = "lbSelectTreeName";
            this.lbSelectTreeName.Size = new System.Drawing.Size(0, 16);
            this.lbSelectTreeName.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbSelectTreeName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbSelectTreeTotalCost);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nudSelectTreeQuantity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbSelectTreeId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(740, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 358);
            this.panel2.TabIndex = 18;
            // 
            // SelectTreeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 472);
            this.Controls.Add(this.btnBillAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dgvSelectTree);
            this.Name = "SelectTreeBill";
            this.Text = "SelectTreeBill";
            this.Load += new System.EventHandler(this.SelectTreeBill_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectTreeQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSelectTreeLoad;
        private System.Windows.Forms.Panel panel1;
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
    }
}