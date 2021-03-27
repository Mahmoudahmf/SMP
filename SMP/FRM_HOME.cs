using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class FRM_HOME : Form
    {
        DB_SMPEntities1 Context = new DB_SMPEntities1();

        public FRM_HOME()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.ShowDialog();
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            FRM_SUP_ADD frm_addcat = new FRM_SUP_ADD();
            frm_addcat.ShowDialog();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            frm_Add frm_addbuyer = new frm_Add();
            frm_addbuyer.ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            
            SellsAdd frmselladd = new SellsAdd();
            frmselladd.ShowDialog();
            
        }

        private void lblItemsNum_Click(object sender, EventArgs e)
        {

        }
    }
}
