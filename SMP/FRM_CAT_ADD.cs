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
    public partial class FRM_CAT_ADD : Form
    {
        DB_SMPEntities1 db = new DB_SMPEntities1();
        TB_CAT tb_cat = new TB_CAT();


        public int id;
        public FRM_CAT_ADD()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            //check
            if (txt_name.Text == "" || txt_price_buy.Text == "")
            {
                toast.labl_caption.Text = "يجيب ان تدخل البيانات";
                toast.Show();

            }
            else
            {
                if (id == 0)
                {
                    //add
                    tb_cat.CAT_Name = txt_name.Text;
                    tb_cat.CAT_Price_buy = Convert.ToDouble(txt_price_buy.Text);
                    tb_cat.CAT_Price_sale = Convert.ToDouble(txt_price_sell.Text);
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم اضافة صنق جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    //edit
                    tb_cat.ID = id;
                    tb_cat.CAT_Name = txt_name.Text;
                    tb_cat.CAT_Price_buy = Convert.ToDouble(txt_price_buy.Text);
                    tb_cat.CAT_Price_sale = Convert.ToDouble(txt_price_sell.Text);
                   
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم تعديل صنق جديد";
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
