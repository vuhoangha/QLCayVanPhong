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
    public partial class UpdateTree : Form
    {
        Tree TREE_SELECTED;

        public UpdateTree(Tree updateTree)
        {
            InitializeComponent();
            TREE_SELECTED = updateTree;

            //  init combobox tree type
            //  category
            cbTreeType.Items.Clear();
            List<Category> listCat = DbManager.GetListCategory();
            for (int i = 0; i < listCat.Count; i++)
            {
                cbTreeType.Items.Add(listCat[i].CatName);
                if (listCat[i].CatId == TREE_SELECTED.CatId)
                {
                    cbTreeType.SelectedIndex = i;
                }
            }

            //  load value to item
            txtTreeName.Text = TREE_SELECTED.TreeName;
            txtTreeCost.Text = TREE_SELECTED.Cost.ToString();
            txtTreeDesc.Text = TREE_SELECTED.Description.ToString();
            nudTreeQuantity.Value = (decimal)TREE_SELECTED.Quantity;
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn cập nhật cây?", "Cập nhật cây", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //  check validate
            if (txtTreeName.Text == string.Empty ||
                    cbTreeType.Text == string.Empty ||
                    txtTreeCost.Text == string.Empty)
            {
                MessageBox.Show("Cập nhật cây không thành công, bạn vui lòng nhập đủ thông tin.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check txt tree cost
            if (!txtTreeCost.Text.All(char.IsDigit))
            {
                MessageBox.Show("Cập nhật cây không thành công, giá cây phải là số nguyên.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Int32.Parse(txtTreeCost.Text) <= 0)
            {
                MessageBox.Show("Cập nhật cây không thành công, giá cây phải lớn hơn 0.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check id is valid ?
            Tree treeById = DbManager.GetTreeById(TREE_SELECTED.TreeId);
            if (treeById == null)
            {
                MessageBox.Show("Cập nhật cây không thành công, cây bạn muốn cập nhật không tồn tại trong hệ thống.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check name is valid ?
            Tree treeTemp = DbManager.GetTreeByNameNotId(TREE_SELECTED.TreeId, txtTreeName.Text.ToUpper());
            if (treeTemp != null)
            {
                MessageBox.Show("Cập nhật cây không thành công, cây bạn muốn thêm đã tồn tại trong hệ thống.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tree updateTree = new Tree();
            //  tree id
            updateTree.TreeId = TREE_SELECTED.TreeId;
            //  tree name
            updateTree.TreeName = txtTreeName.Text.ToUpper();
            //  catId
            Category cat = DbManager.GetCategoryByName(cbTreeType.Text);
            if (cat != null)
            {
                updateTree.CatId = cat.CatId;
            }
            else
            {
                MessageBox.Show("Cập nhật cây không thành công, không tồn tại loại cây bạn nhập.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //  quantity
            updateTree.Quantity = (int)nudTreeQuantity.Value;
            //  cost
            updateTree.Cost = Int32.Parse(txtTreeCost.Text);
            //  desc
            updateTree.Description = txtTreeDesc.Text;
            if (DbManager.updateTree(updateTree, TREE_SELECTED.TreeId))
            {
                this.Close();
                MessageBox.Show("Thành công", "Cập nhật cây", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Cập nhật cây không thành công, bạn vui lòng chỉnh sửa lại thông tin cây muốn cập nhật.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
