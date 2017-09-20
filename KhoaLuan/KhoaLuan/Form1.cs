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
        private int? ID_TREE_SELECTED;
        private int? ID_TYPE_SELECTED;
        private int? ID_PROVIDER_SELECTED;
        private int? BILL_ID_SELECTED;
        private int? IMPORT_ID_SELECTED;
        private int? USER_ID_SELECTED;

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
        }

        public bool callBackMain()
        {
            if (Login.USER_LOGIN.UserName != "admin")
            {
                tbcMain.TabPages.RemoveAt(0);
                tbcMain.TabPages.RemoveAt(0);
                tbcMain.TabPages.RemoveAt(1);
                tbcMain.TabPages.RemoveAt(1);
                tbcMain.TabPages.RemoveAt(1);

                #region init

                loadGridViewBill();

                #endregion
            }
            else
            {
                #region init

                loadGridViewTree();

                #endregion
            }

            tbcMain.Visible = true;
            tbcMain.SelectedTabPageIndex = 0;
            return true;
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
                newRow.Cells[3].Value = DbManager.convertToMoney(tree.Cost.ToString());
                newRow.Cells[4].Value = tree.Quantity;
                dgvTree.Rows.Add(newRow);
            }

            //  save ID_TREE_SELECTED
            if (listTree.Count > 0)
            {
                ID_TREE_SELECTED = listTree[0].TreeId;
            }

            refreshDgvTree();

            #endregion
        }

        private void refreshDgvTree()
        {
            dgvTree.Refresh();
            if (dgvTree.RowCount >= 2)
            {
                dgvTree.Rows[0].Selected = true;
                DataGridViewRow row = dgvTree.Rows[0];
                ID_TREE_SELECTED = (int)row.Cells[0].Value;
            }
            else
            {
                ID_TREE_SELECTED = null;
            }
        }

        private void dgvTree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
                {
                    ID_TREE_SELECTED = null;
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                ID_TREE_SELECTED = (int)row.Cells[0].Value;
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

        private void btnTreeUpdate_Click(object sender, EventArgs e)
        {
            if (ID_TREE_SELECTED == null)
            {
                MessageBox.Show("Bạn vui lòng chọn cây cần cập nhật.", "Cập nhật cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tree updateTree = DbManager.GetTreeById((int)ID_TREE_SELECTED);
            UpdateTree newForm = new UpdateTree(updateTree);
            newForm.Show();
        }

        private void btnTreeDelete_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn xóa cây đã chọn?", "Xóa cây", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //  check is selected tree
            if (ID_TREE_SELECTED == null)
            {
                MessageBox.Show("Xóa cây không thành công, chọn cây cần cập nhật.", "Xóa cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  desc
            if (DbManager.deleteTree((int)ID_TREE_SELECTED))
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
                newRow.Cells[3].Value = DbManager.convertToMoney(tree.Cost.ToString());
                newRow.Cells[4].Value = tree.Quantity;
                dgvTree.Rows.Add(newRow);
            }

            refreshDgvTree();

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
                newRow.Cells[2].Value = DbManager.convertToMoney(bill.TotalCost.ToString());
                Account currUser = DbManager.getUserByUserId((int)bill.UserId);
                if (currUser != null)
                {
                    newRow.Cells[3].Value = currUser.FullName;
                }

                Customer customer = DbManager.getCustomerByID(bill.CustomerId);
                newRow.Cells[4].Value = customer.CustomerName;
                newRow.Cells[5].Value = customer.CustomerId;
                newRow.Cells[6].Value = customer.CustomerPhone;

                dgvBill.Rows.Add(newRow);
            }

            refreshDgvBill();

            #endregion
        }

        private void refreshDgvBill()
        {
            dgvBill.Refresh();
            if (dgvBill.RowCount >= 2)
            {
                dgvBill.Rows[0].Selected = true;
                DataGridViewRow row = dgvBill.Rows[0];
                BILL_ID_SELECTED = (int)row.Cells[0].Value;
            }
            else
            {
                BILL_ID_SELECTED = null;
            }
        }

        private void loadGridUser()
        {
            txtUserSearch.Text = "";

            #region set dgv cat

            List<Account> listUser = DbManager.GetAllUser(Login.USER_LOGIN.UserName);

            dgvUser.DataSource = null;
            dgvUser.Rows.Clear();

            for (int i = 0; i < listUser.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvUser);  // this line was missing
                var user = listUser[i];

                newRow.Cells[0].Value = user.UserId;
                newRow.Cells[1].Value = user.UserName;
                newRow.Cells[2].Value = user.FullName;
                newRow.Cells[3].Value = user.BirthDay.ToString();

                dgvUser.Rows.Add(newRow);
            }

            refreshDgvUser();

            #endregion

            #region Role

            if (Login.USER_LOGIN.UserName != "admin")
            {
                btnUserAdd.Enabled = false;
                btnUserDelete.Enabled = false;
                txtUserSearch.Enabled = false;
            }

            #endregion
        }

        private void refreshDgvUser()
        {
            dgvUser.Refresh();
            if (dgvUser.RowCount >= 2)
            {
                dgvUser.Rows[0].Selected = true;
                DataGridViewRow row = dgvUser.Rows[0];
                USER_ID_SELECTED = (int)row.Cells[0].Value;
            }
            else
            {
                USER_ID_SELECTED = null;
            }
        }

        private void loadGridViewImport()
        {
            txtImportSearch.Text = "";

            #region set dgv cat

            List<Import> listImport = DbManager.getListImportByDate(dtpImport.Value);

            dgvImport.DataSource = null;
            dgvImport.Rows.Clear();

            for (int i = 0; i < listImport.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvImport);  // this line was missing
                var bill = listImport[i];

                newRow.Cells[0].Value = bill.ImportId;
                newRow.Cells[1].Value = bill.TimeChanged;
                Provider currPro = DbManager.GetProviderById((int)bill.ProviderId);
                if (currPro != null)
                {
                    newRow.Cells[2].Value = currPro.ProviderName;
                }
                newRow.Cells[3].Value = DbManager.convertToMoney(bill.TotalCost.ToString());
                Account currUser = DbManager.getUserByUserId((int)bill.UserId);
                if (currUser != null)
                {
                    newRow.Cells[4].Value = currUser.FullName;
                }

                dgvImport.Rows.Add(newRow);
            }

            refreshDgvImport();

            #endregion
        }

        private void refreshDgvImport()
        {
            dgvImport.Refresh();
            if (dgvImport.RowCount >= 2)
            {
                dgvImport.Rows[0].Selected = true;
                DataGridViewRow row = dgvImport.Rows[0];
                IMPORT_ID_SELECTED = (int)row.Cells[0].Value;
            }
            else
            {
                IMPORT_ID_SELECTED = null;
            }
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

            refreshDgvCat();

            #endregion
        }

        private void refreshDgvCat()
        {
            dgvType.Refresh();
            if (dgvType.RowCount >= 2)
            {
                dgvType.Rows[0].Selected = true;
                DataGridViewRow row = dgvType.Rows[0];
                ID_TYPE_SELECTED = (int)row.Cells[0].Value;
            }
            else
            {
                ID_TYPE_SELECTED = null;
            }
        }

        private void loadGridViewProvider(object sender, EventArgs e)
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

            refreshDgvProvider();

            #endregion
        }

        #endregion

        private void dgvType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
                {
                    ID_TYPE_SELECTED = null;
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                ID_TYPE_SELECTED = (int)row.Cells[0].Value;
                Category currCat = DbManager.GetCategoryById((int)row.Cells[0].Value);
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

            refreshDgvCat();

            #endregion
        }

        private void btnTypeDel_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn xóa nhóm cây đã chọn?", "Xóa nhóm cây", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //  check is selected tree
            if (ID_TYPE_SELECTED == null)
            {
                MessageBox.Show("Xóa loại cây không thành công, chọn loại cây cần xóa.", "Xóa loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  desc
            if (DbManager.deleteCat((int)ID_TYPE_SELECTED))
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
                newRow.Cells[2].Value = DbManager.convertToMoney(bill.TotalCost.ToString());
                Account currUser = DbManager.getUserByUserId((int)bill.UserId);
                if (currUser != null)
                {
                    newRow.Cells[3].Value = currUser.FullName;
                }

                Customer customer = DbManager.getCustomerByID(bill.CustomerId);
                newRow.Cells[4].Value = customer.CustomerName;
                newRow.Cells[5].Value = customer.CustomerId;
                newRow.Cells[6].Value = customer.CustomerPhone;

                dgvBill.Rows.Add(newRow);
            }

            refreshDgvBill();

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

            refreshDgvProvider();

            #endregion
        }

        private void btnProviderDelete_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp đã chọn?", "Xóa nhà cung cấp", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //  check is selected tree
            if (ID_PROVIDER_SELECTED == null)
            {
                MessageBox.Show("Xóa nhà cung cấp không thành công, chọn nhà cung cấp cần xóa.", "Xóa nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  desc
            if (DbManager.deletePro((int)ID_PROVIDER_SELECTED))
            {
                MessageBox.Show("Thành công", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.None);
                loadGridViewProvider();
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
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                ID_PROVIDER_SELECTED = (int)row.Cells[0].Value;
                Provider provider = DbManager.GetProviderById((int)row.Cells[0].Value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddImport newForm = new AddImport();
            newForm.Show();
        }

        private void txtImportSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv cat

            List<Import> listImport = DbManager.getListImportByDateAndSearch(dtpImport.Value, txtImportSearch.Text);

            dgvImport.DataSource = null;
            dgvImport.Rows.Clear();

            for (int i = 0; i < listImport.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvImport);  // this line was missing
                var bill = listImport[i];

                newRow.Cells[0].Value = bill.ImportId;
                newRow.Cells[1].Value = bill.TimeChanged;
                Provider currPro = DbManager.GetProviderById((int)bill.ProviderId);
                if (currPro != null)
                {
                    newRow.Cells[2].Value = currPro.ProviderName;
                }
                newRow.Cells[3].Value = bill.TotalCost;
                Account currUser = DbManager.getUserByUserId((int)bill.UserId);
                if (currUser != null)
                {
                    newRow.Cells[4].Value = currUser.FullName;
                }

                dgvImport.Rows.Add(newRow);
            }

            refreshDgvImport();

            #endregion
        }

        private void btnImportRefresh_Click(object sender, EventArgs e)
        {
            loadGridViewImport();
        }

        private void dtpImport_ValueChanged(object sender, EventArgs e)
        {
            loadGridViewImport();
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
            {
                BILL_ID_SELECTED = null;
                return;
            }

            DataGridViewRow row = dgvBill.Rows[e.RowIndex];
            BILL_ID_SELECTED = (int)row.Cells[0].Value;
        }

        private void btnBillDetail_Click(object sender, EventArgs e)
        {
            if (BILL_ID_SELECTED == null)
            {
                MessageBox.Show("Bạn vui lòng chọn hóa đơn cần xem.", "Chi tiết hóa đơn",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BillDetailView newForm = new BillDetailView((int)BILL_ID_SELECTED);
            newForm.Show();
        }

        private void btnImportDetail_Click(object sender, EventArgs e)
        {
            ImportDetailView newForm = new ImportDetailView((int)IMPORT_ID_SELECTED);
            newForm.Show();
        }

        private void dgvImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
            {
                return;
            }

            DataGridViewRow row = dgvImport.Rows[e.RowIndex];
            IMPORT_ID_SELECTED = (int)row.Cells[0].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTree newForm = new AddTree();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addCategory newForm = new addCategory();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ID_TYPE_SELECTED == null)
            {
                MessageBox.Show("Bạn vui lòng chọn nhóm cây cần cập nhật.", "Cập nhật nhóm cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Category update = DbManager.GetCategoryById((int)ID_TYPE_SELECTED);
            UpdateCategory newForm = new UpdateCategory(update);
            newForm.Show();
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

            refreshDgvProvider();

            #endregion
        }

        private void refreshDgvProvider()
        {
            dgvProvider.Refresh();
            if (dgvProvider.RowCount >= 2)
            {
                dgvProvider.Rows[0].Selected = true;
                DataGridViewRow row = dgvProvider.Rows[0];
                ID_PROVIDER_SELECTED = (int)row.Cells[0].Value;
            }
            else
            {
                ID_PROVIDER_SELECTED = null;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddProvider newForm = new AddProvider();
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Provider update = DbManager.GetProviderById((int)ID_PROVIDER_SELECTED);
            UpdateProvider newForm = new UpdateProvider(update);
            newForm.Show();
        }

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            loadGridUser();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            addUser newForm = new addUser();
            newForm.Show();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            Account updateUser = DbManager.getUserByUserId((int)USER_ID_SELECTED);
            updateUser newForm = new updateUser(updateUser);
            newForm.Show();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn xóa người dùng?", "Xóa người dùng", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            bool isDel = DbManager.deleteUser((int)USER_ID_SELECTED);
            if (!isDel)
            {
                MessageBox.Show("Xóa người dùng không thành công", "Xóa người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thành công", "Xóa người dùng");
            return;
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            #region set dgv

            List<Account> listUser = DbManager.GetUserByContentString(txtUserSearch.Text.ToUpper());

            dgvUser.DataSource = null;
            dgvUser.Rows.Clear();

            for (int i = 0; i < listUser.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvUser);
                var user = listUser[i];

                newRow.Cells[0].Value = user.UserId;
                newRow.Cells[1].Value = user.UserName;
                newRow.Cells[2].Value = user.FullName;
                newRow.Cells[3].Value = user.BirthDay.ToString();

                dgvUser.Rows.Add(newRow);
            }

            refreshDgvUser();

            #endregion
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
                {
                    USER_ID_SELECTED = null;
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                USER_ID_SELECTED = (int)row.Cells[0].Value;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tbcMain_SelectedIndexChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            if (tabControl.SelectedTabPageIndex == 0)
            {
                loadGridViewTree();
            }
            else if (tabControl.SelectedTabPageIndex == 1)
            {
                loadGridViewCategory();
            }
            else if (tabControl.SelectedTabPageIndex == 2)
            {
                dtpBill.Value = DateTime.Now;
                loadGridViewBill();
            }
            else if (tabControl.SelectedTabPageIndex == 3)
            {
                loadGridViewProvider();
                txtProviderSearch.Text = "";
            }
            else if (tabControl.SelectedTabPageIndex == 4)
            {
                dtpImport.Value = DateTime.Now;
                loadGridViewImport();
            }
            else if (tabControl.SelectedTabPageIndex == 5)
            {
                txtUserSearch.Text = "";
                loadGridUser();
            }
        }

    }
}
