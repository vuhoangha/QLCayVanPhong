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
    public partial class UpdateProvider : Form
    {
        Provider PROVIDER_UPDATE;

        public UpdateProvider(Provider update)
        {
            InitializeComponent();
            PROVIDER_UPDATE = update;

            //  load data
            txtProviderAddress.Text = PROVIDER_UPDATE.Address;
            txtProviderEmail.Text = PROVIDER_UPDATE.Email;
            txtProviderName.Text = PROVIDER_UPDATE.ProviderName;
            txtProviderPhone.Text = PROVIDER_UPDATE.Phone;
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
        {
            //  check validate
            if (txtProviderName.Text == string.Empty
                || txtProviderAddress.Text == string.Empty
                || txtProviderEmail.Text == string.Empty
                || txtProviderPhone.Text == string.Empty)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, bạn vui lòng nhập đủ thông tin.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check id is valid ?
            Provider proById = DbManager.GetProviderById(PROVIDER_UPDATE.ProviderId);
            if (proById == null)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, nhà cung cấp bạn muốn cập nhật không tồn tại trong hệ thống.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check name is valid ?
            Provider proTemp = DbManager.GetProByNameNotId(PROVIDER_UPDATE.ProviderId, txtProviderName.Text.ToUpper());
            if (proTemp != null)
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, nhà cung cấp bạn muốn thêm đã tồn tại trong hệ thống.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Provider updateProvider = new Provider();
            //  pro id
            updateProvider.ProviderId = PROVIDER_UPDATE.ProviderId;
            //  pro name
            updateProvider.ProviderName = txtProviderName.Text.ToUpper();

            //  address
            updateProvider.Address = txtProviderAddress.Text;

            //  phone
            updateProvider.Phone = txtProviderPhone.Text;

            //  phone
            updateProvider.Email = txtProviderEmail.Text;

            //  add to db
            if (DbManager.updateProvider(updateProvider, PROVIDER_UPDATE.ProviderId))
            {
                this.Close();
                MessageBox.Show("Thành công", "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công, bạn vui lòng chỉnh sửa lại thông tin nhà cung cấp muốn cập nhật.", "Cập nhật nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
