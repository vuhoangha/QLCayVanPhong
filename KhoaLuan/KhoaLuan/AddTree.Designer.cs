namespace KhoaLuan
{
    partial class AddTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTree));
            this.cbTreeType = new System.Windows.Forms.ComboBox();
            this.txtTreeCost = new System.Windows.Forms.TextBox();
            this.txtTreeDesc = new System.Windows.Forms.TextBox();
            this.txtTreeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportAddTree = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cbTreeType
            // 
            this.cbTreeType.BackColor = System.Drawing.Color.Gainsboro;
            this.cbTreeType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTreeType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTreeType.FormattingEnabled = true;
            this.cbTreeType.Location = new System.Drawing.Point(110, 107);
            this.cbTreeType.Name = "cbTreeType";
            this.cbTreeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTreeType.Size = new System.Drawing.Size(258, 23);
            this.cbTreeType.TabIndex = 14;
            // 
            // txtTreeCost
            // 
            this.txtTreeCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeCost.Location = new System.Drawing.Point(110, 151);
            this.txtTreeCost.Name = "txtTreeCost";
            this.txtTreeCost.Size = new System.Drawing.Size(214, 25);
            this.txtTreeCost.TabIndex = 11;
            // 
            // txtTreeDesc
            // 
            this.txtTreeDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeDesc.Location = new System.Drawing.Point(110, 197);
            this.txtTreeDesc.Multiline = true;
            this.txtTreeDesc.Name = "txtTreeDesc";
            this.txtTreeDesc.Size = new System.Drawing.Size(257, 101);
            this.txtTreeDesc.TabIndex = 12;
            // 
            // txtTreeName
            // 
            this.txtTreeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTreeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreeName.Location = new System.Drawing.Point(110, 64);
            this.txtTreeName.Name = "txtTreeName";
            this.txtTreeName.Size = new System.Drawing.Size(258, 25);
            this.txtTreeName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(30, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(30, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(330, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại cây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên cây";
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
            this.btnImportAddTree.Location = new System.Drawing.Point(333, 12);
            this.btnImportAddTree.Name = "btnImportAddTree";
            this.btnImportAddTree.Size = new System.Drawing.Size(35, 35);
            this.btnImportAddTree.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnImportAddTree, "Thêm cây");
            this.btnImportAddTree.UseVisualStyleBackColor = false;
            this.btnImportAddTree.Click += new System.EventHandler(this.btnImportAddTree_Click);
            // 
            // AddTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 315);
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
            this.Name = "AddTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm cây";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTreeType;
        private System.Windows.Forms.TextBox txtTreeCost;
        private System.Windows.Forms.TextBox txtTreeDesc;
        private System.Windows.Forms.TextBox txtTreeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportAddTree;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}