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
    public partial class BillDetailView : Form
    {
        private int BILL_ID;

        public BillDetailView(int billId)
        {
            InitializeComponent();
            BILL_ID = billId;
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            #region set dgv

            List<BillDetail> listBillDetail = DbManager.getBillDetailByBillId(BILL_ID);

            Dictionary<int, Tree> DicTree = DbManager.GetDicTreeAll();

            dgv.DataSource = null;
            dgv.Rows.Clear();

            for (int i = 0; i < listBillDetail.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv);  // this line was missing
                var billDetail = listBillDetail[i];
                newRow.Cells[0].Value = billDetail.TreeId;
                newRow.Cells[1].Value = DicTree[(int)billDetail.TreeId].TreeName;
                newRow.Cells[2].Value = billDetail.Cost;
                newRow.Cells[3].Value = billDetail.Quantity;
                newRow.Cells[4].Value = billDetail.Cost * billDetail.Quantity;
                dgv.Rows.Add(newRow);
            }

            dgv.Refresh();

            #endregion
        }

    }
}
