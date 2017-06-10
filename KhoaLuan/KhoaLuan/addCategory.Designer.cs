namespace KhoaLuan
{
    partial class addCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCategory));
            this.btnImportAddTree = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.btnImportAddTree.Location = new System.Drawing.Point(400, 21);
            this.btnImportAddTree.Name = "btnImportAddTree";
            this.btnImportAddTree.Size = new System.Drawing.Size(35, 35);
            this.btnImportAddTree.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnImportAddTree, "Thêm");
            this.btnImportAddTree.UseVisualStyleBackColor = false;
            this.btnImportAddTree.Click += new System.EventHandler(this.btnImportAddTree_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(145, 96);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(258, 25);
            this.txtTypeName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên loại cây";
            // 
            // addCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 160);
            this.Controls.Add(this.btnImportAddTree);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại cây";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportAddTree;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}