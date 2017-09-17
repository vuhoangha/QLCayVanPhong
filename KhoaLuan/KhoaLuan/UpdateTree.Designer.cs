namespace KhoaLuan
{
    partial class UpdateTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTree));
            this.btnImportAddTree = new System.Windows.Forms.Button();
            this.cbTreeType = new System.Windows.Forms.ComboBox();
            this.txtTreeCost = new System.Windows.Forms.TextBox();
            this.txtTreeDesc = new System.Windows.Forms.TextBox();
            this.txtTreeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTreeQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTreeQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportAddTree
            // 
            this.btnImportAddTree.BackColor = System.Drawing.Color.Transparent;
            this.btnImportAddTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportAddTree.FlatAppearance.BorderSize = 0;
            this.btnImportAddTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnImportAddTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImportAddTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportAddTree.Image = ((System.Drawing.Image)(resources.GetObject("btnImportAddTree.Image")));
            this.btnImportAddTree.Location = new System.Drawing.Point(315, 7);
            this.btnImportAddTree.Name = "btnImportAddTree";
            this.btnImportAddTree.Size = new System.Drawing.Size(35, 35);
            this.btnImportAddTree.TabIndex = 46;
            this.btnImportAddTree.UseVisualStyleBackColor = false;
            this.btnImportAddTree.Click += new System.EventHandler(this.btnImportAddTree_Click);
            // 
            // cbTreeType
            // 
            this.cbTreeType.BackColor = System.Drawing.Color.Gainsboro;
            this.cbTreeType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTreeType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTreeType.FormattingEnabled = true;
            this.cbTreeType.Location = new System.Drawing.Point(92, 102);
            this.cbTreeType.Name = "cbTreeType";
            this.cbTreeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTreeType.Size = new System.Drawing.Size(258, 23);
            this.cbTreeType.TabIndex = 45;
            // 
            // txtTreeCost
            // 
            this.txtTreeCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeCost.Location = new System.Drawing.Point(92, 146);
            this.txtTreeCost.Name = "txtTreeCost";
            this.txtTreeCost.Size = new System.Drawing.Size(214, 25);
            this.txtTreeCost.TabIndex = 42;
            // 
            // txtTreeDesc
            // 
            this.txtTreeDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeDesc.Location = new System.Drawing.Point(90, 241);
            this.txtTreeDesc.Multiline = true;
            this.txtTreeDesc.Name = "txtTreeDesc";
            this.txtTreeDesc.Size = new System.Drawing.Size(257, 101);
            this.txtTreeDesc.TabIndex = 43;
            // 
            // txtTreeName
            // 
            this.txtTreeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTreeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeName.Location = new System.Drawing.Point(92, 59);
            this.txtTreeName.Name = "txtTreeName";
            this.txtTreeName.Size = new System.Drawing.Size(258, 25);
            this.txtTreeName.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Loại cây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên cây";
            // 
            // nudTreeQuantity
            // 
            this.nudTreeQuantity.Location = new System.Drawing.Point(92, 195);
            this.nudTreeQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTreeQuantity.Name = "nudTreeQuantity";
            this.nudTreeQuantity.Size = new System.Drawing.Size(167, 20);
            this.nudTreeQuantity.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "cây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Số lượng";
            // 
            // UpdateTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 354);
            this.Controls.Add(this.nudTreeQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImportAddTree);
            this.Controls.Add(this.cbTreeType);
            this.Controls.Add(this.txtTreeCost);
            this.Controls.Add(this.txtTreeDesc);
            this.Controls.Add(this.txtTreeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật cây";
            ((System.ComponentModel.ISupportInitialize)(this.nudTreeQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportAddTree;
        private System.Windows.Forms.ComboBox cbTreeType;
        private System.Windows.Forms.TextBox txtTreeCost;
        private System.Windows.Forms.TextBox txtTreeDesc;
        private System.Windows.Forms.TextBox txtTreeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTreeQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
    }
}