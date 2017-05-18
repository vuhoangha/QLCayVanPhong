namespace KhoaLuan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tpTree = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudTreeQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbTreeType = new System.Windows.Forms.ComboBox();
            this.txtTreeCost = new System.Windows.Forms.TextBox();
            this.txtTreeDesc = new System.Windows.Forms.TextBox();
            this.txtTreeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTreeSearch = new System.Windows.Forms.TextBox();
            this.dgvTree = new System.Windows.Forms.DataGridView();
            this.dtcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTreeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTreeDelete = new System.Windows.Forms.Button();
            this.btnTreeUpdate = new System.Windows.Forms.Button();
            this.btnTreeAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tpTree.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTreeQuantity)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tpTree);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.ItemSize = new System.Drawing.Size(72, 30);
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1161, 578);
            this.tbcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcMain.TabIndex = 0;
            this.tbcMain.Visible = false;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tpTree
            // 
            this.tpTree.BackColor = System.Drawing.Color.White;
            this.tpTree.Controls.Add(this.panel2);
            this.tpTree.Controls.Add(this.flowLayoutPanel2);
            this.tpTree.Controls.Add(this.dgvTree);
            this.tpTree.Controls.Add(this.flowLayoutPanel1);
            this.tpTree.Location = new System.Drawing.Point(4, 34);
            this.tpTree.Name = "tpTree";
            this.tpTree.Size = new System.Drawing.Size(1153, 540);
            this.tpTree.TabIndex = 0;
            this.tpTree.Text = "Cây";
            this.tpTree.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.nudTreeQuantity);
            this.panel2.Controls.Add(this.cbTreeType);
            this.panel2.Controls.Add(this.txtTreeCost);
            this.panel2.Controls.Add(this.txtTreeDesc);
            this.panel2.Controls.Add(this.txtTreeName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(732, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 483);
            this.panel2.TabIndex = 3;
            // 
            // nudTreeQuantity
            // 
            this.nudTreeQuantity.Location = new System.Drawing.Point(147, 190);
            this.nudTreeQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTreeQuantity.Name = "nudTreeQuantity";
            this.nudTreeQuantity.Size = new System.Drawing.Size(167, 20);
            this.nudTreeQuantity.TabIndex = 3;
            // 
            // cbTreeType
            // 
            this.cbTreeType.FormattingEnabled = true;
            this.cbTreeType.Location = new System.Drawing.Point(147, 133);
            this.cbTreeType.Name = "cbTreeType";
            this.cbTreeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTreeType.Size = new System.Drawing.Size(239, 21);
            this.cbTreeType.TabIndex = 2;
            // 
            // txtTreeCost
            // 
            this.txtTreeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeCost.Location = new System.Drawing.Point(147, 246);
            this.txtTreeCost.Name = "txtTreeCost";
            this.txtTreeCost.Size = new System.Drawing.Size(167, 22);
            this.txtTreeCost.TabIndex = 1;
            // 
            // txtTreeDesc
            // 
            this.txtTreeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeDesc.Location = new System.Drawing.Point(147, 304);
            this.txtTreeDesc.Multiline = true;
            this.txtTreeDesc.Name = "txtTreeDesc";
            this.txtTreeDesc.Size = new System.Drawing.Size(239, 101);
            this.txtTreeDesc.TabIndex = 1;
            // 
            // txtTreeName
            // 
            this.txtTreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeName.Location = new System.Drawing.Point(147, 78);
            this.txtTreeName.Name = "txtTreeName";
            this.txtTreeName.Size = new System.Drawing.Size(239, 22);
            this.txtTreeName.TabIndex = 1;
            this.txtTreeName.TextChanged += new System.EventHandler(this.txtTreeName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(67, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(67, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "cây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(67, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại cây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(67, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên cây";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Honeydew;
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(713, 43);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(675, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button3, "Làm mới");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTreeSearch);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 35);
            this.panel1.TabIndex = 4;
            // 
            // txtTreeSearch
            // 
            this.txtTreeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTreeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeSearch.Location = new System.Drawing.Point(437, 6);
            this.txtTreeSearch.Name = "txtTreeSearch";
            this.txtTreeSearch.Size = new System.Drawing.Size(223, 24);
            this.txtTreeSearch.TabIndex = 3;
            this.txtTreeSearch.TextChanged += new System.EventHandler(this.txtTreeSearch_TextChanged);
            // 
            // dgvTree
            // 
            this.dgvTree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcId,
            this.dtcTreeName,
            this.dtcTreeType,
            this.dtcTreeCost,
            this.dtcQuantity});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTree.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTree.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvTree.Location = new System.Drawing.Point(3, 48);
            this.dgvTree.Name = "dgvTree";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTree.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTree.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTree.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvTree.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTree.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTree.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTree.Size = new System.Drawing.Size(713, 486);
            this.dgvTree.TabIndex = 1;
            this.dgvTree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTree_CellClick);
            // 
            // dtcId
            // 
            this.dtcId.HeaderText = "Mã cây";
            this.dtcId.Name = "dtcId";
            // 
            // dtcTreeName
            // 
            this.dtcTreeName.HeaderText = "Tên cây";
            this.dtcTreeName.Name = "dtcTreeName";
            this.dtcTreeName.Width = 200;
            // 
            // dtcTreeType
            // 
            this.dtcTreeType.HeaderText = "Loại cây";
            this.dtcTreeType.Name = "dtcTreeType";
            this.dtcTreeType.Width = 150;
            // 
            // dtcTreeCost
            // 
            this.dtcTreeCost.HeaderText = "Giá tiền";
            this.dtcTreeCost.Name = "dtcTreeCost";
            this.dtcTreeCost.Width = 110;
            // 
            // dtcQuantity
            // 
            this.dtcQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcQuantity.HeaderText = "Số lượng";
            this.dtcQuantity.Name = "dtcQuantity";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.flowLayoutPanel1.Controls.Add(this.btnTreeDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnTreeUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnTreeAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnClearTree);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(732, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 43);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTreeDelete
            // 
            this.btnTreeDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnTreeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreeDelete.FlatAppearance.BorderSize = 0;
            this.btnTreeDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTreeDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTreeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreeDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnTreeDelete.Image")));
            this.btnTreeDelete.Location = new System.Drawing.Point(383, 3);
            this.btnTreeDelete.Name = "btnTreeDelete";
            this.btnTreeDelete.Size = new System.Drawing.Size(35, 35);
            this.btnTreeDelete.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnTreeDelete, "Xóa");
            this.btnTreeDelete.UseVisualStyleBackColor = false;
            this.btnTreeDelete.Click += new System.EventHandler(this.btnTreeDelete_Click);
            // 
            // btnTreeUpdate
            // 
            this.btnTreeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnTreeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreeUpdate.FlatAppearance.BorderSize = 0;
            this.btnTreeUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTreeUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTreeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreeUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnTreeUpdate.Image")));
            this.btnTreeUpdate.Location = new System.Drawing.Point(342, 3);
            this.btnTreeUpdate.Name = "btnTreeUpdate";
            this.btnTreeUpdate.Size = new System.Drawing.Size(35, 35);
            this.btnTreeUpdate.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnTreeUpdate, "Lưu");
            this.btnTreeUpdate.UseVisualStyleBackColor = false;
            this.btnTreeUpdate.Click += new System.EventHandler(this.btnTreeUpdate_Click);
            // 
            // btnTreeAdd
            // 
            this.btnTreeAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnTreeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreeAdd.FlatAppearance.BorderSize = 0;
            this.btnTreeAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTreeAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTreeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreeAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnTreeAdd.Image")));
            this.btnTreeAdd.Location = new System.Drawing.Point(301, 3);
            this.btnTreeAdd.Name = "btnTreeAdd";
            this.btnTreeAdd.Size = new System.Drawing.Size(35, 35);
            this.btnTreeAdd.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnTreeAdd, "Thêm mới");
            this.btnTreeAdd.UseVisualStyleBackColor = false;
            this.btnTreeAdd.Click += new System.EventHandler(this.btnTreeAdd_Click);
            this.btnTreeAdd.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại cây";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearTree
            // 
            this.btnClearTree.BackColor = System.Drawing.Color.Transparent;
            this.btnClearTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTree.FlatAppearance.BorderSize = 0;
            this.btnClearTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTree.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTree.Image")));
            this.btnClearTree.Location = new System.Drawing.Point(260, 3);
            this.btnClearTree.Name = "btnClearTree";
            this.btnClearTree.Size = new System.Drawing.Size(35, 35);
            this.btnClearTree.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClearTree, "Làm mới");
            this.btnClearTree.UseVisualStyleBackColor = false;
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1161, 578);
            this.Controls.Add(this.tbcMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.tbcMain.ResumeLayout(false);
            this.tpTree.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTreeQuantity)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tpTree;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTreeAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTreeUpdate;
        private System.Windows.Forms.Button btnTreeDelete;
        private System.Windows.Forms.DataGridView dgvTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTreeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTreeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTreeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTreeSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudTreeQuantity;
        private System.Windows.Forms.ComboBox cbTreeType;
        private System.Windows.Forms.TextBox txtTreeCost;
        private System.Windows.Forms.TextBox txtTreeDesc;
        private System.Windows.Forms.TextBox txtTreeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearTree;
        private System.Windows.Forms.Label label1;

    }
}

