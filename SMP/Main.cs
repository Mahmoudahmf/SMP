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
    public partial class Main : Form
    {
        DB_SMPEntities1 Context = new DB_SMPEntities1();
        FRM_HOME frm_home = new FRM_HOME();
        FRM_CAT frm_cat = new FRM_CAT();
        FRM_SUP frm_sup = new FRM_SUP();
        frm_Add frm_buyers = new frm_Add();
        BuyersTable frm_buyers_table = new BuyersTable();
        Pn_SellTable frmsellsTable = new Pn_SellTable();
        DB_SMPEntities1 db = new DB_SMPEntities1();

        public Main()
        {
            InitializeComponent();
        }

   
        /// <summary>
        /// close
        /// </summary>
       
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // Min app
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // Max app  
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //Collapse
        private void btn_col_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 195)
            {
                pn_navbar.Width = 50;
                pn_titlenavbar.Visible = false;
                pn_headernavbar.Height = 70;
            }
            else
            {
                pn_navbar.Width = 195;
                pn_titlenavbar.Visible = true;
                pn_headernavbar.Height = 238;
            }
        }
        //home
        private void btn_home_Click(object sender, EventArgs e)
        {
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(frm_home.pn_home);
            labl_title.Text = btn_home.Text;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frm_home.lblSellNum.Text = Context.Sells.Count().ToString();
            frm_home.lblBuyerNum.Text = Context.Buyers.Count().ToString();
            frm_home.lblSupNum.Text = Context.TB_SUP.Count().ToString();
            frm_home.lblItemsNum.Text = Context.TB_CAT.Count().ToString();
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(frm_home.pn_home);
        }

        //Categories

        private void btn_cat_Click(object sender, EventArgs e)
        {
            pn_Container.Controls.Clear();
           pn_Container.Controls.Add(frm_cat.pn_cat);
            labl_title.Text = btn_cat.Text;
        }
        //suppliers
        private void btn_sup_Click(object sender, EventArgs e)
        {
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(frm_sup.pn_sup);
            labl_title.Text = btn_sup.Text;

        }

        private void btn_Buyers_Click(object sender, EventArgs e)
        {
            pn_Container.Controls.Clear();
           pn_Container.Controls.Add(frm_buyers_table.Pn_tableBuy);
            labl_title.Text = btn_Buyers.Text;

        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(frmsellsTable.pn_tablesell);
            labl_title.Text = btnSells.Text;
        }

        private void pn_Container_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void pn_Container_Leave(object sender, EventArgs e)
        {
            frm_home.lblSellNum.Text = Context.Sells.Count().ToString();
            frm_home.lblBuyerNum.Text = Context.Buyers.Count().ToString();
            frm_home.lblSupNum.Text = Context.TB_SUP.Count().ToString();
            frm_home.lblItemsNum.Text = Context.TB_CAT.Count().ToString();
        }
    }
}
