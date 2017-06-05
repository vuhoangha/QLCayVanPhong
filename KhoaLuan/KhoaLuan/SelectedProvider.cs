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
    public partial class SelectedProvider : Form
    {
        Provider PROVIDER_SELECTED;
        Func<Provider, bool> callBackImport = null;

        public SelectedProvider(Func<Provider, bool> callback)
        {
            InitializeComponent();
            callBackImport = callback;
        }

        private void SelectedProvider_Load(object sender, EventArgs e)
        {

            #region set dgv provider

            List<Provider> listProvider = DbManager.GetListProvider();

            dgv.DataSource = null;
            dgv.Rows.Clear();

            for (int i = 0; i < listProvider.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv);  // this line was missing
                var provider = listProvider[i];
                newRow.Cells[0].Value = provider.ProviderId;
                newRow.Cells[1].Value = provider.ProviderName;
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
                PROVIDER_SELECTED = DbManager.GetProviderById((int)row.Cells[0].Value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            if (PROVIDER_SELECTED == null)
            {
                MessageBox.Show("Bạn vui lòng chọn nhà cung cấp", "Lựa chọn nhà cung cấp",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            callBackImport(PROVIDER_SELECTED);
            this.Close();
        }
    }
}
