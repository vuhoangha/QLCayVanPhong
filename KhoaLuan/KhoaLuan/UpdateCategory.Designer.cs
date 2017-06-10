namespace KhoaLuan
{
    partial class UpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategory));
            this.btnImportAddTree = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnImportAddTree.Location = new System.Drawing.Point(392, 20);
            this.btnImportAddTree.Name = "btnImportAddTree";
            this.btnImportAddTree.Size = new System.Drawing.Size(35, 35);
            this.btnImportAddTree.TabIndex = 42;
            this.btnImportAddTree.UseVisualStyleBackColor = false;
            this.btnImportAddTree.Click += new System.EventHandler(this.btnImportAddTree_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(136, 92);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(258, 25);
            this.txtTypeName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên nhóm cây";
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 152);
            this.Controls.Add(this.btnImportAddTree);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhóm cây";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportAddTree;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label2;
    }
}