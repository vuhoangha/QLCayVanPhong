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
            SelectTreeBill addTree = new SelectTreeBill();
            addTree.Show();
        }
    }
}
