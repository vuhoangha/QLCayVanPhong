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
        private int ID_TYPE_SELECTED;
        private int ID_PROVIDER_SELECTED;

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
                txtTreeName.Text = "";
                cbTreeType.Text = "";
                nudTreeQuantity.Value = 0;
                txtTreeCost.Text = "";
                txtTreeDesc.Text = "";
            }
            else if (tabControl.SelectedIndex == 1)
            {
                loadGridViewCategory();
                txtTypeName.Text = "";
            }
            else if (tabControl.SelectedIndex == 2)
            {
                dtpBill.Value = DateTime.Now;
                loadGridViewBill();
            }
            else if (tabControl.SelectedIndex == 3)
            {
                loadGridViewProvider();

                txtProviderAddress.Text = "";
                txtProviderEmail.Text = "";
                txtProviderName.Text = "";
                txtProviderPhone.Text = "";
                txtProviderSearch.Text = "";
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
            ID_TREE_SELECTED = 0;
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

        private void loadGridViewBill()
        {
            txtBillSearch.Text = "";

            #region set dgv cat

            List<Bill> listBill = DbManager.getListBillByDate(dtpBill.Value);

            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();

            for (int i = 0; i < listBill.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvBill);  // this line was missing
                var bill = listBill[i];

                newRow.Cells[0].Value = bill.BillId;
                newRow.Cells[1].Value = bill.TimeChanged;
                newRow.Cells[2].Value = bill.TotalCost;
                User currUser = DbManager.getUserByUserId((int)bill.UserId);
                if (currUser != null)
                {
                    newRow.Cells[3].Value = currUser.FullName;
                }
                newRow.Cells[4].Value = bill.CustomerName;
                newRow.Cells[5].Value = bill.CustomerId;
                newRow.Cells[6].Value = bill.CustomerAddress;

                dgvBill.Rows.Add(newRow);
            }

            dgvBill.Refresh();

            #endregion
        }

        private void loadGridViewCategory()
        {
            txtTypeSearch.Text = "";

            #region set dgv cat

            List<Category> listCat = DbManager.GetListCategory();
            Dictionary<int, Category> DicCategory = DbManager.GetDicCategory();

            dgvType.DataSource = null;
            dgvType.Rows.Clear();

            for (int i = 0; i < listCat.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvType);  // this line was missing
                var cat = listCat[i];
                newRow.Cells[0].Value = cat.CatId;
                newRow.Cells[1].Value = cat.CatName;
                newRow.Cells[2].Value = DbManager.countTree(cat.CatId);
                dgvType.Rows.Add(newRow);
            }

            dgvType.Refresh();

            #endregion
        }

        private void loadGridViewProvider()
        {
            txtProviderSearch.Text = "";

            #region set dgv provider

            List<Provider> listProvider = DbManager.GetListProvider();

            dgvProvider.DataSource = null;
            dgvProvider.Rows.Clear();

            for (int i = 0; i < listProvider.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvProvider);  // this line was missing
                var provider = listProvider[i];
                newRow.Cells[0].Value = provider.ProviderId;
                newRow.Cells[1].Value = provider.ProviderName;
                newRow.Cells[2].Value = provider.Address;
                newRow.Cells[3].Value = provider.Phone;
                newRow.Cells[4].Value = provider.Email;
                dgvProvider.Rows.Add(newRow);
            }

            dgvProvider.Refresh();

            #endregion
        }

        #endregion

        private void dgvType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.CurrentCell.RowIndex < 0 || dgv.CurrentCell.ColumnIndex < 0 || dgv.CurrentCell.RowIndex >= dgv.RowCount - 1)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                ID_TYPE_SELECTED = (int)row.Cells[0].Value;
                Category currCat = DbManager.GetCategoryById((int)row.Cells[0].Value);
                //  name
                txtTypeName.Text = currCat.CatName;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            loadGridViewCategory();
        }

        private void txtTypeSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv category

            List<Category> listCat = DbManager.GetCatByNameContentString(txtTypeSearch.Text.ToUpper());

            dgvType.DataSource = null;
            dgvType.Rows.Clear();

            for (int i = 0; i < listCat.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvType);  // this line was missing
                var cat = listCat[i];
                newRow.Cells[0].Value = cat.CatId;
                newRow.Cells[1].Value = cat.CatName;
                newRow.Cells[2].Value = DbManager.countTree(cat.CatId);
                dgvType.Rows.Add(newRow);
            }

            dgvType.Refresh();

            #endregion
        }

        private void btnTypeClean_Click(object sender, EventArgs e)
        {
            txtTypeName.Text = "";
            ID_TYPE_SELECTED = 0;
        }

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //  check validate
                if (txtTypeName.Text == string.Empty)
                {
                    MessageBox.Show("Thêm loại cây không thành công, bạn vui lòng nhập đủ thông tin.", "Thêm loại cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //  check cat existing
                Category catTemp = DbManager.GetCategoryByName(txtTypeName.Text.ToUpper());
                if (catTemp != null)
                {
                    MessageBox.Show("Thêm loại cây không thành công, loại cây bạn muốn thêm đã tồn tại trong hệ thống.", "Thêm loại cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Category newCat = new Category();
                //  cat name
                newCat.CatName = txtTypeName.Text.ToUpper();

                //  them loại cay
                if (DbManager.addCat(newCat))
                {
                    MessageBox.Show("Thành công", "Thêm loại cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                    loadGridViewCategory();
                }
                else
                {
                    MessageBox.Show("Thêm loại cây không thành công, bạn vui lòng chỉnh sửa lại thông tin loại cây muốn thêm.", "Thêm loại cây",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnTypeUpdate_Click(object sender, EventArgs e)
        {
            //  check is selected category
            if (ID_TYPE_SELECTED == null)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, chọn loại cây cần cập nhật.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check validate
            if (txtTypeName.Text == string.Empty)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, bạn vui lòng nhập đủ thông tin.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check id is valid ?
            Category catById = DbManager.GetCategoryById(ID_TYPE_SELECTED);
            if (catById == null)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, loại cây bạn muốn cập nhật không tồn tại trong hệ thống.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check name is valid ?
            Category catTemp = DbManager.GetCatByNameNotId(ID_TYPE_SELECTED, txtTypeName.Text.ToUpper());
            if (catTemp != null)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, loại cây bạn muốn thêm đã tồn tại trong hệ thống.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category updateCat = new Category();
            //  cat id
            updateCat.CatId = ID_TYPE_SELECTED;
            //  cat name
            updateCat.CatName = txtTypeName.Text.ToUpper();

            //  add to db
            if (DbManager.updateCat(updateCat, ID_TYPE_SELECTED))
            {
                MessageBox.Show("Thành công", "Cập nhật loại cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewCategory();
            }
            else
            {
                MessageBox.Show("Cập nhật loại cây không thành công, bạn vui lòng chỉnh sửa lại thông tin loại cây muốn cập nhật.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTypeDel_Click(object sender, EventArgs e)
        {
            //  check is selected tree
            if (ID_TYPE_SELECTED == null)
            {
                MessageBox.Show("Xóa loại cây không thành công, chọn loại cây cần xóa.", "Xóa loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  desc
            if (DbManager.deleteCat(ID_TYPE_SELECTED))
            {
                MessageBox.Show("Thành công", "Xóa loại cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewCategory();
            }
            else
            {
                MessageBox.Show("Xóa loại cây không thành công, bạn vui lòng chọn lại loại cây cần xóa.", "Xóa loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBill addBill = new AddBill();
            addBill.Show();
        }

        private void dtpBill_ValueChanged(object sender, EventArgs e)
        {
            loadGridViewBill();
        }

        private void btnBillRefresh_Click(object sender, EventArgs e)
        {
            loadGridViewBill();
        }

        private void txtBillSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv cat

            List<Bill> listBill = DbManager.getListBillByDateAndSearch(dtpBill.Value, txtBillSearch.Text);

            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();

            for (int i = 0; i < listBill.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvBill);  // this line was missing
                var bill = listBill[i];

                newRow.Cells[0].Value = bill.BillId;
                newRow.Cells[1].Value = bill.TimeChanged;
                newRow.Cells[2].Value = bill.TotalCost;
                User currUser = DbManager.getUserByUserId((int)bill.UserId);
                if (currUser != null)
                {
                    newRow.Cells[3].Value = currUser.FullName;
                }
                newRow.Cells[4].Value = bill.CustomerName;
                newRow.Cells[5].Value = bill.CustomerId;
                newRow.Cells[6].Value = bill.CustomerAddress;

                dgvBill.Rows.Add(newRow);
            }

            dgvBill.Refresh();

            #endregion
        }

        private void btnProviderRefresh_Click(object sender, EventArgs e)
        {
            loadGridViewProvider();
        }

        private void txtProviderSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv provider

            List<Provider> listProvider = DbManager.GetListProviderByContainName(txtProviderSearch.Text);

            dgvProvider.DataSource = null;
            dgvProvider.Rows.Clear();

            for (int i = 0; i < listProvider.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvProvider);  // this line was missing
                var provider = listProvider[i];
                newRow.Cells[0].Value = provider.ProviderId;
                newRow.Cells[1].Value = provider.ProviderName;
                newRow.Cells[2].Value = provider.Address;
                newRow.Cells[3].Value = provider.Phone;
                newRow.Cells[4].Value = provider.Email;
                dgvProvider.Rows.Add(newRow);
            }

            dgvProvider.Refresh();

            #endregion
        }

        private void btnProviderClear_Click(object sender, EventArgs e)
        {
            txtProviderAddress.Text = "";
            txtProviderEmail.Text = "";
            txtProviderName.Text = "";
            txtProviderPhone.Text = "";
            ID_PROVIDER_SELECTED = 0;
        }

        private void btnProviderAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //  check validate
                if (txtProviderName.Text == string.Empty)
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công, bạn vui lòng nhập đủ thông tin.", "Thêm nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //  check pro existing
                Provider proTemp = DbManager.GetProviderByName(txtProviderName.Text.ToUpper());
                if (proTemp != null)
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công, nhà cung cấp bạn muốn thêm đã tồn tại trong hệ thống.", "Thêm nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Provider newProvider = new Provider();
                //  pro name
                newProvider.ProviderName = txtProviderName.Text.ToUpper();
                //  address
                newProvider.Address = txtProviderAddress.Text;
                //  email
                newProvider.Email = txtProviderEmail.Text;
                //  phone
                newProvider.Phone = txtProviderPhone.Text;

                //  them loại cay
                if (DbManager.addProvider(newProvider))
                {
                    MessageBox.Show("Thành công", "Thêm nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.None);
                    loadGridViewCategory();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công, bạn vui lòng chỉnh sửa lại thông tin nhà cung cấp muốn thêm.", "Thêm nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnProviderUpdate_Click(object sender, EventArgs e)
        {
            //  check is selected
            if (ID_PROVIDER_SELECTED == null)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, chọn nhà cung cấp cần cập nhật.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check validate
            if (txtProviderName.Text == string.Empty)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, bạn vui lòng nhập đủ thông tin.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check id is valid ?
            Provider proById = DbManager.GetProviderById(ID_PROVIDER_SELECTED);
            if (proById == null)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, nhà cung cấp bạn muốn cập nhật không tồn tại trong hệ thống.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check name is valid ?
            Provider proTemp = DbManager.GetProByNameNotId(ID_PROVIDER_SELECTED, txtProviderName.Text.ToUpper());
            if (proTemp != null)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, nhà cung cấp bạn muốn thêm đã tồn tại trong hệ thống.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Provider updateProvider = new Provider();
            //  pro id
            updateProvider.ProviderId = ID_PROVIDER_SELECTED;
            //  pro name
            updateProvider.ProviderName = txtProviderName.Text.ToUpper();

            //  address
            updateProvider.Address = txtProviderAddress.Text;

            //  phone
            updateProvider.Phone = txtProviderPhone.Text;

            //  phone
            updateProvider.Email = txtProviderEmail.Text;

            //  add to db
            if (DbManager.updateProvider(updateProvider, ID_PROVIDER_SELECTED))
            {
                MessageBox.Show("Thành công", "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewCategory();
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, bạn vui lòng chỉnh sửa lại thông tin nhà cung cấp muốn cập nhật.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProviderDelete_Click(object sender, EventArgs e)
        {
            //  check is selected tree
            if (ID_PROVIDER_SELECTED == null)
            {
                MessageBox.Show("Xóa nhà cung cấp không thành công, chọn nhà cung cấp cần xóa.", "Xóa nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  desc
            if (DbManager.deletePro(ID_PROVIDER_SELECTED))
            {
                MessageBox.Show("Thành công", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewCategory();
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp không thành công, bạn vui lòng chọn lại nhà cung cấp cần xóa.", "Xóa nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.CurrentCell.RowIndex < 0 || dgv.CurrentCell.ColumnIndex < 0 || dgv.CurrentCell.RowIndex >= dgv.RowCount - 1)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                ID_PROVIDER_SELECTED = (int)row.Cells[0].Value;
                Provider provider = DbManager.GetProviderById((int)row.Cells[0].Value);

                //  address
                txtProviderAddress.Text = provider.Address;

                //  email
                txtProviderEmail.Text = provider.Email;

                //  name
                txtProviderName.Text = provider.ProviderName;

                //  phone
                txtProviderPhone.Text = provider.Phone;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
