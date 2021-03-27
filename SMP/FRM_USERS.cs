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
    public partial class FRM_USERS : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_user = new TB_Users();
        int id;
        public FRM_USERS()
        {
            InitializeComponent();



            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        //add
        private void btn_add_Click(object sender, EventArgs e)
        {
            FRM_USERS_ADD frm_add = new FRM_USERS_ADD();
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
                    tb_user = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_user).State = EntityState.Deleted;
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم حذف مستخدم";
                    toast.Show();
                    this.Close();
                    //renew tale
                    update_data();
                }
            }
            catch
            {
                MessageBox.Show("لا يمكنك اتمام عملية الحذف ");
            }


        }
        //renew function
        private void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Users.ToList();
        }
        //edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            FRM_USERS_ADD frm_add = new FRM_USERS_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_user = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();

            frm_add.txt_username.Text = tb_user.User_Name;
            frm_add.txt_pass.Text = tb_user.User_Password;
            frm_add.txt_rol.Text = tb_user.User_Rol;

            frm_add.id = id;
            frm_add.btn_add.Text = "تعديل";
            frm_add.Show();
        }

        //private void btn_search_Click(object sender, EventArgs e)
        //{
        //    var _search = txt_search.Text;
        //    gridControl1.DataSource = db.TB_CAT.Where(x => x.CAT_Name.Contains(_search)).ToList();
        //}

      
    }
}
