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
    public partial class AddProvider : Form
    {
        public AddProvider()
        {
            InitializeComponent();
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
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
                    this.Close();
                    MessageBox.Show("Thành công", "Thêm nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.None);
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
    }
}
