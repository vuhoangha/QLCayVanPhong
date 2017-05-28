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
    public partial class addCategory : Form
    {
        public addCategory()
        {
            InitializeComponent();
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
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
                    this.Close();
                    MessageBox.Show("Thành công", "Thêm loại cây", MessageBoxButtons.OK, MessageBoxIcon.None);
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
    }
}
