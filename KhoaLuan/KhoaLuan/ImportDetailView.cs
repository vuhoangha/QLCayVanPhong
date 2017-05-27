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
    public partial class ImportDetailView : Form
    {
        private int IMPORT_ID;

        public ImportDetailView(int importId)
        {
            InitializeComponent();
            IMPORT_ID = importId;
        }

        private void loadGrid()
        {
            #region set dgv

            List<ImportDetail> listBillDetail = DbManager.getImportDetailByBillId(IMPORT_ID);

            Dictionary<int, Tree> DicTree = DbManager.GetDicTree();

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

        private void ImportDetailView_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

    }
}
