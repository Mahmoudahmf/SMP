using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SMP
{
    public partial class FRM_SUP : Form
    {
        DB_SMPEntities1 db = new DB_SMPEntities1();
        TB_SUP tb_sup = new TB_SUP();
        int id;
        public FRM_SUP()
        {
            InitializeComponent();


            SMP.DB_SMPEntities1 dbContext = new SMP.DB_SMPEntities1();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_SUP.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_SUP.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        //add
        private void btn_add_Click(object sender, EventArgs e)
        {
            FRM_SUP_ADD frm_add = new FRM_SUP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        //renew
        private void btn_renew_Click(object sender, EventArgs e)
        {
            update_data();
        }

        //delete

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                var res = MessageBox.Show("هل انت متاكد من عملية الحذف", "حذف", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    tb_sup = db.TB_SUP.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_sup).State = EntityState.Deleted;
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم حذف المورد بنجاح";
                    toast.Show();
                    this.Close();
                    //renew tale
                    update_data();
                }
            }
            catch
            {
                MessageBox.Show("يجب تحديد مورد للحذف");
            }


        }
        //renew function
        private void update_data()
        {
            db = new DB_SMPEntities1();
            gridControl1.DataSource = db.TB_SUP.ToList();
        }
        //edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            FRM_SUP_ADD frm_add = new FRM_SUP_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_sup = db.TB_SUP.Where(x => x.ID == id).FirstOrDefault();

            frm_add.txt_name.Text = tb_sup.Sup_Name.ToString();
            frm_add.txt_phone.Text = tb_sup.Sup_Phone.ToString();
            frm_add.txt_start.Text = tb_sup.Sup_Start_Date.ToString();
            
            frm_add.id = id;
            frm_add.btn_add.Text = "تعديل";
            frm_add.Show();
        }

      

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
