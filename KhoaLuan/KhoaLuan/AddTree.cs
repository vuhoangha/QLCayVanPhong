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
    public partial class AddTree : Form
    {
        public AddTree()
        {
            InitializeComponent();

            //  init combobox tree type
            //  category
            cbTreeType.Items.Clear();
            List<Category> listCat = DbManager.GetListCategory();
            for (int i = 0; i < listCat.Count; i++)
            {
                cbTreeType.Items.Add(listCat[i].CatName);
            }
            if (listCat.Count > 0)
            {
                cbTreeType.SelectedIndex = 0;
            }
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
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
                newTree.Quantity = 0;
                //  cost
                newTree.Cost = Int32.Parse(txtTreeCost.Text);
                //  desc
                newTree.Description = txtTreeDesc.Text;
                if (DbManager.addTree(newTree))
                {
                    MessageBox.Show("Thành công", "Thêm cây", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
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

    }
}
