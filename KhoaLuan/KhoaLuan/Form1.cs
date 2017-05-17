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

            //using (Image image = Image.FromFile("10-dithering-opt.jpg"))
            //{
            //    using (MemoryStream m = new MemoryStream())
            //    {
            //        image.Save(m, image.RawFormat);
            //        byte[] imageBytes = m.ToArray();

            //        // Convert byte[] to Base64 String
            //        string base64String = Convert.ToBase64String(imageBytes);

            //        var b = Convert.FromBase64String(base64String);
            //        using (var mem = new MemoryStream(b))
            //        {
            //            pictureBox1.Image = Image.FromStream(mem);
            //        }

            //    }
            //}

        }

        public bool callBackMain()
        {
            tbcMain.Visible = true;

            #region init
            loadTabTree();
            #endregion

            return true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnTreeAdd.BackColor = Color.LightCyan;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl.SelectedIndex == 0)
            {
                loadTabTree();
            }
        }


        #region TREE

        private void loadTabTree()
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
                newRow.Cells[3].Value = tree.Cost;
                newRow.Cells[4].Value = tree.Quantity;
                dgvTree.Rows.Add(newRow);
            }

            dgvTree.Refresh();

            #endregion
        }

        private void dgvTree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.CurrentCell.RowIndex < 0 || dgv.CurrentCell.ColumnIndex < 0 || dgv.CurrentCell.RowIndex >= dgv.RowCount - 1)
                {
                    return;
                }

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                Tree currTree = DbManager.GetTreeById((int)row.Cells[0].Value);
                //  id
                lbTreeId.Text = currTree.TreeId.ToString();
                //  name
                txtTreeName.Text = currTree.TreeName;
                //  category
                cbTreeType.Items.Clear();
                List<Category> listCat = DbManager.GetListCategory();
                for (int i = 0; i < listCat.Count; i++)
                {
                    cbTreeType.Items.Add(listCat[i].CatName);
                    if (listCat[i].CatId == currTree.CatId)
                    {
                        cbTreeType.SelectedIndex = i;
                    }
                }
                //  so luong
                nudTreeQuantity.Value = (int)currTree.Quantity;
                //  gia
                txtTreeCost.Text = currTree.Cost.ToString();
                //  mo ta
                txtTreeDesc.Text = currTree.Description;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadTabTree();
        }

        #endregion

    }
}
