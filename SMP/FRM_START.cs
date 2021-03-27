
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMP
{
    public partial class FRM_START : SplashScreen
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_user = new TB_Users();
        Main main = new Main();
        FRM_LOGIN login = new FRM_LOGIN();
        public FRM_START()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void FRM_START_Load(object sender, EventArgs e)
        {

        }

     

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            tb_user = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            if (tb_user != null)
            {
                main.label_username.Text = tb_user.User_Name;
                main.label_rol.Text = tb_user.User_Rol;
                main.Show();
            }
            else
            {
                login.Show();
            }
            this.Hide();
            timer1.Enabled = false;

        }
    }
}