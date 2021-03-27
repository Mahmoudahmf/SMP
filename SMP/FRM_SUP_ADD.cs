using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class FRM_SUP_ADD : Form
    {
        DB_SMPEntities1 db = new DB_SMPEntities1();
        TB_SUP tb_sup = new TB_SUP();


        public int id;
        public FRM_SUP_ADD()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();


            if (txt_name.Text == "" && txt_phone.Text == "")
            {
                toast.labl_caption.Text = "  يجيب ان تدخل البيانات صحيحة";
                toast.Show();
               

            }

            else if (txt_phone.Text.Length < 11)
            {
                toast.labl_caption.Text = " يجيب ان يكون رقم الهاتف صحيح";
                toast.Show();
                

            }
            else
            {
                if (id == 0)
                {
                    //add
                    tb_sup.Sup_Name = txt_name.Text;
                    tb_sup.Sup_Phone = txt_phone.Text;
                    //tb_sup.Sup_Start_Date = DateTime.Parse(txt_start.Text.ToString());
                    tb_sup.Sup_Start_Date = dateTimePicker1.Value;
                    db.TB_SUP.Add(tb_sup);
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم اضافة مورد جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    //edit
                    tb_sup.ID = id;
                    tb_sup.Sup_Name = txt_name.Text;
                    tb_sup.Sup_Phone = txt_phone.Text;
                    tb_sup.Sup_Start_Date = DateTime.Parse(dateTimePicker1.Text);


                    db.Entry(tb_sup).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم تعديل مورد جديد";
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
