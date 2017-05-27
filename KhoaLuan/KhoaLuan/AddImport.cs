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
    public partial class AddImport : Form
    {
        Provider PROVIDER_SELECTED;
        int ID_TREE_SELECTED;
        DataGridViewRow ROW_SELECTED;

        public AddImport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedProvider newForm = new SelectedProvider(callbackSelectedProvider);
            newForm.Show();
        }

        private bool callbackSelectedProvider(Provider selected)
        {
            PROVIDER_SELECTED = selected;
            lbProviderName.Text = selected.ProviderName;
            return true;
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
        {
            SelectTreeImport newForm = new SelectTreeImport(addTreeCallBack);
            newForm.Show();
        }

        private bool addTreeCallBack(Tree selected)
        {
            try
            {
                Tree currTree = selected;
                if (dgvAddImport.RowCount > 1)
                {
                    //  check tree duplicate
                    foreach (DataGridViewRow row in dgvAddImport.Rows)
                    {
                        if (row.Index >= 0 && row.Index < dgvAddImport.RowCount - 1 && (int)row.Cells[0].Value == selected.TreeId)
                        {
                            return true;
                        }
                    }
                }

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvAddImport);  // this line was missing
                newRow.Cells[0].Value = selected.TreeId;
                newRow.Cells[1].Value = selected.TreeName;
                newRow.Cells[2].Value = 0;
                newRow.Cells[3].Value = 0;
                newRow.Cells[4].Value = 0;
                dgvAddImport.Rows.Add(newRow);
                dgvAddImport.Refresh();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private void dgvAddImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  check row valid
            if (e.RowIndex < 0
                || e.ColumnIndex < 0
                || e.RowIndex >= dgvAddImport.RowCount - 1
                || e.ColumnIndex == -1 && e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dgvAddImport.Rows[e.RowIndex];
            ROW_SELECTED = dgvAddImport.Rows[e.RowIndex];
            ID_TREE_SELECTED = (int)row.Cells[0].Value;
            Tree currTree = DbManager.GetTreeById(ID_TREE_SELECTED);

            //  tree name
            lbImportTreeName.Text = currTree.TreeName;
            //  tree id
            lbImportTreeId.Text = currTree.TreeId.ToString();
            //  quantity
            nudImportTreeQuantity.Value = Int32.Parse(row.Cells[2].Value.ToString());
            //  cost
            txtCost.Text = row.Cells[3].Value.ToString();
            //  total cost
            lbTotalCost.Text = row.Cells[4].Value.ToString();
        }

        private void btnBillUpdate_Click(object sender, EventArgs e)
        {
            Tree currTree = DbManager.GetTreeById(ID_TREE_SELECTED);
            ROW_SELECTED.Cells[2].Value = nudImportTreeQuantity.Value;
            ROW_SELECTED.Cells[3].Value = txtCost.Text;
            ROW_SELECTED.Cells[4].Value = (nudImportTreeQuantity.Value * Int32.Parse(txtCost.Text)).ToString();
            dgvAddImport.Refresh();
            calculateTotalCost();
        }

        private void calculateTotalCost()
        {
            var totalCost = 0;
            foreach (DataGridViewRow row in dgvAddImport.Rows)
            {
                if (row.Index >= 0 && row.Index < dgvAddImport.RowCount - 1)
                {
                    totalCost += Int32.Parse(row.Cells[4].Value.ToString());
                }
            }
            lbAddImportToTalBill.Text = totalCost.ToString();
        }

        private void btnBillDel_Click(object sender, EventArgs e)
        {
            dgvAddImport.Rows.RemoveAt(ROW_SELECTED.Index);
            dgvAddImport.Refresh();
            calculateTotalCost();
        }

        private void nudImportTreeQuantity_ValueChanged(object sender, EventArgs e)
        {
            Tree currTree = DbManager.GetTreeById(ID_TREE_SELECTED);
            lbTotalCost.Text = (nudImportTreeQuantity.Value * Int32.Parse(txtCost.Text)).ToString();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            Tree currTree = DbManager.GetTreeById(ID_TREE_SELECTED);
            lbTotalCost.Text = (nudImportTreeQuantity.Value * Int32.Parse(txtCost.Text)).ToString();
        }

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                #region Create Import

                //  create new bill
                Import newImport = new Import();
                newImport.TimeChanged = DateTime.Now;
                newImport.TotalCost = Int32.Parse(lbAddImportToTalBill.Text);
                newImport.UserId = Login.USER_LOGIN.UserId;
                newImport.ProviderId = PROVIDER_SELECTED.ProviderId;

                //  add to db
                newImport = DbManager.addImport(newImport);

                #endregion

                //  add to import detail
                List<ImportDetail> listImportDetail = new List<ImportDetail>();
                List<Tree> listTree = new List<Tree>();

                foreach (DataGridViewRow row in dgvAddImport.Rows)
                {
                    if (row.Index >= 0 && row.Index < dgvAddImport.RowCount - 1)
                    {
                        //  create bill detail
                        ImportDetail billDetail = new ImportDetail();
                        billDetail.ImportId = newImport.ImportId;
                        Tree currTree = DbManager.GetTreeById(Int32.Parse(row.Cells[0].Value.ToString()));
                        billDetail.TreeId = currTree.TreeId;
                        billDetail.Quantity = Int32.Parse(row.Cells[2].Value.ToString());
                        billDetail.Cost = Int32.Parse(row.Cells[3].Value.ToString());

                        //  add bill detail to list
                        listImportDetail.Add(billDetail);

                        //  add tree
                        Tree newTree = new Tree();
                        newTree.Quantity = currTree.Quantity + billDetail.Quantity;
                        newTree.TreeId = currTree.TreeId;
                        listTree.Add(newTree);
                    }
                }

                //  save to db
                DbManager.addListImportDetail(listImportDetail);

                //  update quantity tree
                DbManager.updateListTree(listTree);

                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
