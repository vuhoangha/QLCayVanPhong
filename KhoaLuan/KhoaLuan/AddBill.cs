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
    public partial class AddBill : Form
    {
        SelectTreeBill addTree;
        int ID_TREE_SELECTED;
        DataGridViewRow ROW_SELECTED;

        public AddBill()
        {
            InitializeComponent();
        }

        private void AddBill_Load(object sender, EventArgs e)
        {
            #region Load data

            #region load combobox treename

            List<Tree> listTree = DbManager.GetAllTree();


            #endregion

            #endregion
        }

        private void btnBillAddTree_Click(object sender, EventArgs e)
        {
            addTree = new SelectTreeBill(addTreeCallBack);
            addTree.Show();
        }

        private bool updateTreeCallBack(int count)
        {
            Tree currTree = DbManager.GetTreeById(ID_TREE_SELECTED);
            ROW_SELECTED.Cells[2].Value = count;
            ROW_SELECTED.Cells[3].Value = (count * currTree.Cost).ToString();
            dgvAddBill.Refresh();
            calculateTotalCost();
            return true;
        }

        private bool addTreeCallBack(Tree selected, int count)
        {
            try
            {
                Tree currTree = DbManager.GetTreeById(selected.TreeId);
                if (dgvAddBill.RowCount > 1)
                {
                    //  check tree duplicate
                    foreach (DataGridViewRow row in dgvAddBill.Rows)
                    {
                        if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1 && (int)row.Cells[0].Value == selected.TreeId)
                        {
                            var totalTreeBuy = Int32.Parse(row.Cells[2].Value.ToString()) + count;
                            if (currTree.Quantity < totalTreeBuy)
                            {
                                MessageBox.Show("Thêm cây không thành công, cửa hàng chỉ còn " + currTree.Quantity + " cây", "Chọn cây",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else
                            {
                                row.Cells[2].Value = totalTreeBuy;
                                row.Cells[3].Value = totalTreeBuy * currTree.Cost;
                                addTree.Close();
                            }
                            calculateTotalCost();
                            return true;
                        }
                    }
                }

                //  add new tree
                if (count > currTree.Quantity)
                {
                    MessageBox.Show("Thêm cây không thành công, cửa hàng chỉ còn " + currTree.Quantity + " cây", "Chọn cây",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvAddBill);  // this line was missing
                newRow.Cells[0].Value = selected.TreeId;
                newRow.Cells[1].Value = selected.TreeName;
                newRow.Cells[2].Value = count;
                newRow.Cells[3].Value = selected.Cost * count;
                dgvAddBill.Rows.Add(newRow);
                dgvAddBill.Refresh();

                addTree.Close();
                calculateTotalCost();
                return true;
            }
            catch (Exception)
            {
                addTree.Close();
                return false;
                throw;
            }
        }

        private void dgvAddBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  check row valid
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
            {
                return;
            }

            DataGridViewRow row = dgvAddBill.Rows[e.RowIndex];
            ROW_SELECTED = dgvAddBill.Rows[e.RowIndex];
            ID_TREE_SELECTED = (int)row.Cells[0].Value;
        }

        private void calculateTotalCost()
        {
            var totalCost = 0;
            foreach (DataGridViewRow row in dgvAddBill.Rows)
            {
                if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1)
                {
                    totalCost += Int32.Parse(row.Cells[3].Value.ToString());
                }
            }
            lbAddBillToTalBill.Text = totalCost.ToString();
        }

        private void btnBillDel_Click(object sender, EventArgs e)
        {
            dgvAddBill.Rows.RemoveAt(ROW_SELECTED.Index);
            dgvAddBill.Refresh();
            calculateTotalCost();
        }

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                //  create new bill
                Bill newBill = new Bill();
                newBill.TimeChanged = DateTime.Now;
                newBill.TotalCost = Int32.Parse(lbAddBillToTalBill.Text);
                newBill.UserId = Login.USER_LOGIN.UserId;
                newBill.CustomerId = txtCustomerId.Text;
                newBill.CustomerName = txtCustomerName.Text;
                newBill.CustomerAddress = txtAddress.Text;

                //  add to db
                newBill = DbManager.addBill(newBill);

                //  add to bill detail
                List<BillDetail> listBillDetail = new List<BillDetail>();
                foreach (DataGridViewRow row in dgvAddBill.Rows)
                {
                    if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1)
                    {
                        //  create bill detail
                        BillDetail billDetail = new BillDetail();
                        billDetail.BillId = newBill.BillId;
                        Tree currTree = DbManager.GetTreeById(Int32.Parse(row.Cells[0].Value.ToString()));
                        billDetail.TreeId = currTree.TreeId;
                        billDetail.Quantity = Int32.Parse(row.Cells[2].Value.ToString());
                        billDetail.Cost = currTree.Cost;

                        //  add bill detail to list
                        listBillDetail.Add(billDetail);
                    }
                }

                //  save to db
                DbManager.addListBillDetail(listBillDetail);

                this.Close();

                MessageBox.Show("Tạo hóa đơn thành công", "Thêm hóa đơn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBillUpdateTree_Click(object sender, EventArgs e)
        {
            if (ROW_SELECTED == null)
            {
                MessageBox.Show("Vui lòng chọn cây cần cập nhật", "Cập nhật cây",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  get current tree
            Tree currTree = DbManager.GetTreeById(ID_TREE_SELECTED);

            int quantity = Int32.Parse(ROW_SELECTED.Cells[2].Value.ToString());

            UpdateTreeBill newFrom = new UpdateTreeBill(currTree, quantity, updateTreeCallBack);
            newFrom.Show();
        }

    }
}
