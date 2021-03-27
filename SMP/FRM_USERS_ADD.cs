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
    public partial class FRM_USERS_ADD : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_user = new TB_Users();


        public int id;
        public FRM_USERS_ADD()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            //check
            if (txt_username.Text == "" || txt_pass.Text == "")
            {
                toast.labl_caption.Text = "يجيب ان تدخل البيانات المطلوبة";
                toast.Show();

            }
            else
            {
                if (id == 0)
                {
                    //add
                    tb_user.User_Name = txt_username.Text;
                    tb_user.User_Password = txt_pass.Text;
                    tb_user.User_Rol = txt_rol.Text;
                    tb_user.User_State = "false";

                    db.TB_Users.Add(tb_user);
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم اضافة مستخدم جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    //edit
                    tb_user.ID = id;
                    tb_user.User_Name = txt_username.Text;
                    tb_user.User_Password = txt_pass.Text;
                    tb_user.User_Rol = txt_rol.Text;
                    tb_user.User_State = "false";

                    db.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم تعديل المستخدم";
                    toast.Show();
                    this.Close();
                }
            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
