using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoaLuan.DB;

namespace KhoaLuan
{
    public partial class SelectTreeImport : Form
    {
        Tree SELECTED_TREE;
        Func<Tree, bool> callbackTree;

        public SelectTreeImport(Func<Tree, bool> callback)
        {
            InitializeComponent();
            callbackTree = callback;
        }

        private void SelectTreeImport_Load(object sender, EventArgs e)
        {
            loadGridViewTree();
        }

        private void loadGridViewTree()
        {
            txtSearch.Text = "";

            #region set dgv tree

            List<Tree> listTree = DbManager.GetAllTree();

            dgv.DataSource = null;
            dgv.Rows.Clear();

            for (int i = 0; i < listTree.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv);  // this line was missing
                var tree = listTree[i];
                newRow.Cells[0].Value = tree.TreeId;
                newRow.Cells[1].Value = tree.TreeName;
                dgv.Rows.Add(newRow);
            }

            dgv.Refresh();

            #endregion
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                Tree currTree = DbManager.GetTreeById((int)row.Cells[0].Value);
                SELECTED_TREE = currTree;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (SELECTED_TREE == null)
            {
                MessageBox.Show("Bạn vui lòng chọn nhà cung cấp", "Lựa chọn nhà cung cấp",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            callbackTree(SELECTED_TREE);
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadGridViewTree();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv tree

            List<Tree> listTree = DbManager.GetTreeByNameContentString(txtSearch.Text);

            dgv.DataSource = null;
            dgv.Rows.Clear();

            for (int i = 0; i < listTree.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv);  // this line was missing
                var tree = listTree[i];
                newRow.Cells[0].Value = tree.TreeId;
                newRow.Cells[1].Value = tree.TreeName;
                dgv.Rows.Add(newRow);
            }

            dgv.Refresh();

            #endregion
        }

    }
}
