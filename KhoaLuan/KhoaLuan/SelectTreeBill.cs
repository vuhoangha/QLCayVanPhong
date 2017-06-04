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
    public partial class SelectTreeBill : Form
    {
        Tree TREE_SELECTED;
        Func<Tree, int, bool> callBackTree = null;

        public SelectTreeBill(Func<Tree, int, bool> callBack)
        {
            callBackTree = callBack;
            InitializeComponent();
        }

        private void SelectTreeBill_Load(object sender, EventArgs e)
        {
            loadGridViewTree();
        }

        private void loadGridViewTree()
        {
            txtSelectTreeSearch.Text = "";

            #region set dgv tree

            List<Tree> listTree = DbManager.GetAllTree();
            Dictionary<int, Category> DicCategory = DbManager.GetDicCategory();

            dgvSelectTree.DataSource = null;
            dgvSelectTree.Rows.Clear();

            for (int i = 0; i < listTree.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvSelectTree);  // this line was missing
                var tree = listTree[i];
                newRow.Cells[0].Value = tree.TreeId;
                newRow.Cells[1].Value = tree.TreeName;
                newRow.Cells[2].Value = DicCategory[(int)tree.CatId].CatName;
                newRow.Cells[3].Value = tree.Cost;
                newRow.Cells[4].Value = tree.Quantity;
                dgvSelectTree.Rows.Add(newRow);
            }

            dgvSelectTree.Refresh();

            #endregion
        }

        private void txtTreeSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv category

            List<Category> listCat = DbManager.GetCatByNameContentString(txtSelectTreeSearch.Text.ToUpper());

            dgvSelectTree.DataSource = null;
            dgvSelectTree.Rows.Clear();

            for (int i = 0; i < listCat.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvSelectTree);  // this line was missing
                var cat = listCat[i];
                newRow.Cells[0].Value = cat.CatId;
                newRow.Cells[1].Value = cat.CatName;
                newRow.Cells[2].Value = DbManager.countTree(cat.CatId);
                dgvSelectTree.Rows.Add(newRow);
            }

            dgvSelectTree.Refresh();

            #endregion
        }

        private void btnSelectTreeLoad_Click(object sender, EventArgs e)
        {
            loadGridViewTree();
        }

        private void dgvSelectTree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.CurrentCell.RowIndex < 0 || dgv.CurrentCell.ColumnIndex < 0 || dgv.CurrentCell.RowIndex >= dgv.RowCount - 1)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                Tree currTree = DbManager.GetTreeById((int)row.Cells[0].Value);
                TREE_SELECTED = currTree;
                //  name
                lbSelectTreeName.Text = currTree.TreeName;
                //  so luong
                nudSelectTreeQuantity.Value = 0;
                //  max so luong
                nudSelectTreeQuantity.Maximum = (decimal)currTree.Quantity;
                //  ma cay
                lbSelectTreeId.Text = currTree.TreeId.ToString();
                //  thanh tien
                lbSelectTreeTotalCost.Text = currTree.Cost.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void nudSelectTreeQuantity_ValueChanged(object sender, EventArgs e)
        {
            //  thanh tien
            lbSelectTreeTotalCost.Text = (TREE_SELECTED.Cost * nudSelectTreeQuantity.Value).ToString();
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            callBackTree(TREE_SELECTED, Int32.Parse(nudSelectTreeQuantity.Value.ToString()));
        }

    }
}
