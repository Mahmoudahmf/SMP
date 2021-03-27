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
    public partial class FRM_LOGIN : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_user = new TB_Users();
        Main main = new Main();



        public FRM_LOGIN()
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

                //Login

                tb_user = db.TB_Users.Where(x => x.User_Name == txt_username.Text && x.User_Password == txt_pass.Text).FirstOrDefault();
                if (tb_user != null)
                {
                    tb_user.User_State = "True";
                    db.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                    main.label_username.Text = tb_user.User_Name;
                    main.label_rol.Text = tb_user.User_Rol;
                    main.Enabled = true;
                    db.SaveChanges();
                    main.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("your username or your password not correct.. ");
                }



            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
