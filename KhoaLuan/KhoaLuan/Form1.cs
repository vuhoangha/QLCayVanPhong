using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoaLuan.DB;

namespace KhoaLuan
{
    public partial class Form1 : Form
    {

        private Login login;
        private int ID_TREE_SELECTED;

        public Form1()
        {
            InitializeComponent();

            login = new KhoaLuan.Login(callBackMain);
            // 
            // login
            // 
            login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            login.Location = new System.Drawing.Point(350, 160);
            login.Name = "login";
            login.Size = new System.Drawing.Size(464, 208);
            login.TabIndex = 0;
            this.Controls.Add(login);

            //using (Image image = Image.FromFile("10-dithering-opt.jpg"))
            //{
            //    using (MemoryStream m = new MemoryStream())
            //    {
            //        image.Save(m, image.RawFormat);
            //        byte[] imageBytes = m.ToArray();

            //        // Convert byte[] to Base64 String
            //        string base64String = Convert.ToBase64String(imageBytes);

            //        var b = Convert.FromBase64String(base64String);
            //        using (var mem = new MemoryStream(b))
            //        {
            //            pictureBox1.Image = Image.FromStream(mem);
            //        }

            //    }
            //}

        }

        public bool callBackMain()
        {
            tbcMain.Visible = true;

            #region init
            loadGridViewTree();
            #endregion

            return true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnTreeAdd.BackColor = Color.LightCyan;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl.SelectedIndex == 0)
            {
                loadGridViewTree();
            }
        }


        #region TREE

        private void loadGridViewTree()
        {
            txtTreeSearch.Text = "";

            #region set dgv tree

            List<Tree> listTree = DbManager.GetAllTree();
            Dictionary<int, Category> DicCategory = DbManager.GetDicCategory();

            dgvTree.DataSource = null;
            dgvTree.Rows.Clear();

            for (int i = 0; i < listTree.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvTree);  // this line was missing
                var tree = listTree[i];
                newRow.Cells[0].Value = tree.TreeId;
                newRow.Cells[1].Value = tree.TreeName;
                newRow.Cells[2].Value = DicCategory[(int)tree.CatId].CatName;
                newRow.Cells[3].Value = tree.Cost;
                newRow.Cells[4].Value = tree.Quantity;
                dgvTree.Rows.Add(newRow);
            }

            dgvTree.Refresh();

            #endregion
        }

        private void dgvTree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.CurrentCell.RowIndex < 0 || dgv.CurrentCell.ColumnIndex < 0 || dgv.CurrentCell.RowIndex >= dgv.RowCount - 1)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                ID_TREE_SELECTED = (int)row.Cells[0].Value;
                Tree currTree = DbManager.GetTreeById((int)row.Cells[0].Value);
                //  name
                txtTreeName.Text = currTree.TreeName;
                //  category
                cbTreeType.Items.Clear();
                List<Category> listCat = DbManager.GetListCategory();
                for (int i = 0; i < listCat.Count; i++)
                {
                    cbTreeType.Items.Add(listCat[i].CatName);
                    if (listCat[i].CatId == currTree.CatId)
                    {
                        cbTreeType.SelectedIndex = i;
                    }
                }
                //  so luong
                nudTreeQuantity.Value = (int)currTree.Quantity;
                //  gia
                txtTreeCost.Text = currTree.Cost.ToString();
                //  mo ta
                txtTreeDesc.Text = currTree.Description;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadGridViewTree();
        }

        private void txtTreeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTreeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //  check validate
                if (txtTreeName.Text == string.Empty ||
                    cbTreeType.Text == string.Empty ||
                    txtTreeCost.Text == string.Empty)
                {
                    MessageBox.Show("Thêm cây không thành công, bạn vui lòng nhập đủ thông tin.", "Thêm cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //  check tree existing
                Tree treeTemp = DbManager.GetTreeByName(txtTreeName.Text.ToUpper());
                if (treeTemp != null)
                {
                    MessageBox.Show("Thêm cây không thành công, cây bạn muốn thêm đã tồn tại trong hệ thống.", "Thêm cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Tree newTree = new Tree();
                //  tree name
                newTree.TreeName = txtTreeName.Text.ToUpper();
                //  catId
                Category cat = DbManager.GetCategoryByName(cbTreeType.Text);
                if (cat != null)
                {
                    newTree.CatId = cat.CatId;
                }
                else
                {
                    MessageBox.Show("Thêm cây không thành công, không tồn tại loại cây bạn nhập.", "Thêm cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //  quantity
                newTree.Quantity = (int)nudTreeQuantity.Value;
                //  cost
                newTree.Cost = Int32.Parse(txtTreeCost.Text);
                //  desc
                newTree.Description = txtTreeDesc.Text;
                if (DbManager.addTree(newTree))
                {
                    MessageBox.Show("Thành công", "Thêm cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                    loadGridViewTree();
                }
                else
                {
                    MessageBox.Show("Thêm cây không thành công, bạn vui lòng chỉnh sửa lại thông tin cây muốn thêm.", "Thêm cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnClearTree_Click(object sender, EventArgs e)
        {
            txtTreeName.Text = "";
            cbTreeType.SelectedIndex = 0;
            nudTreeQuantity.Value = 0;
            txtTreeCost.Text = "";
            txtTreeDesc.Text = "";
        }

        private void btnTreeSearch_Click(object sender, EventArgs e)
        {
            #region set dgv tree

            List<Tree> listTree = DbManager.GetTreeByNameContentString(txtTreeSearch.Text.ToUpper());
            Dictionary<int, Category> DicCategory = DbManager.GetDicCategory();

            dgvTree.DataSource = null;
            dgvTree.Rows.Clear();

            for (int i = 0; i < listTree.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvTree);  // this line was missing
                var tree = listTree[i];
                newRow.Cells[0].Value = tree.TreeId;
                newRow.Cells[1].Value = tree.TreeName;
                newRow.Cells[2].Value = DicCategory[(int)tree.CatId].CatName;
                newRow.Cells[3].Value = tree.Cost;
                newRow.Cells[4].Value = tree.Quantity;
                dgvTree.Rows.Add(newRow);
            }

            dgvTree.Refresh();

            #endregion
        }

        private void btnTreeUpdate_Click(object sender, EventArgs e)
        {
            //  check is selected tree
            if (ID_TREE_SELECTED == null)
            {
                MessageBox.Show("Cập nhật cây không thành công, chọn cây cần cập nhật.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //  check id is valid ?
            Tree treeById = DbManager.GetTreeById(ID_TREE_SELECTED);
            if (treeById == null)
            {
                MessageBox.Show("Cập nhật cây không thành công, cây bạn muốn cập nhật không tồn tại trong hệ thống.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check name is valid ?
            Tree treeTemp = DbManager.GetTreeByNameNotId(ID_TREE_SELECTED, txtTreeName.Text.ToUpper());
            if (treeTemp != null)
            {
                MessageBox.Show("Cập nhật cây không thành công, cây bạn muốn thêm đã tồn tại trong hệ thống.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tree updateTree = new Tree();
            //  tree id
            updateTree.TreeId = ID_TREE_SELECTED;
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
            if (DbManager.updateTree(updateTree, ID_TREE_SELECTED))
            {
                MessageBox.Show("Thành công", "Cập nhật cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewTree();
            }
            else
            {
                MessageBox.Show("Cập nhật cây không thành công, bạn vui lòng chỉnh sửa lại thông tin cây muốn cập nhật.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTreeDelete_Click(object sender, EventArgs e)
        {
            //  check is selected tree
            if (ID_TREE_SELECTED == null)
            {
                MessageBox.Show("Xóa cây không thành công, chọn cây cần cập nhật.", "Xóa cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  desc
            if (DbManager.deleteTree(ID_TREE_SELECTED))
            {
                MessageBox.Show("Thành công", "Xóa cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewTree();
            }
            else
            {
                MessageBox.Show("Xóa cây không thành công, bạn vui lòng chọn lại cây cần xóa.", "Xóa cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTreeSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv tree

            List<Tree> listTree = DbManager.GetTreeByNameContentString(txtTreeSearch.Text.ToUpper());
            Dictionary<int, Category> DicCategory = DbManager.GetDicCategory();

            dgvTree.DataSource = null;
            dgvTree.Rows.Clear();

            for (int i = 0; i < listTree.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvTree);  // this line was missing
                var tree = listTree[i];
                newRow.Cells[0].Value = tree.TreeId;
                newRow.Cells[1].Value = tree.TreeName;
                newRow.Cells[2].Value = DicCategory[(int)tree.CatId].CatName;
                newRow.Cells[3].Value = tree.Cost;
                newRow.Cells[4].Value = tree.Quantity;
                dgvTree.Rows.Add(newRow);
            }

            dgvTree.Refresh();

            #endregion
        }

        #endregion
    }
}
