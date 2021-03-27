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
        
        double buyprice;
        
        int quatity;
        double totalPrice;
        public int id;
        public FRM_CAT_ADD()
        {
            InitializeComponent();
        }
      
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();

            try
            {


              
                //check
                if (txt_name.Text == "" || txt_price_buy.Text == "" || txt_price_sell.Text == "")
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
                        tb_cat.ItemQuantity = int.Parse(numericUpDown1.Value.ToString());
                        tb_cat.TotalBuy = Convert.ToDouble(txtTotalprice.Text);
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
                        tb_cat.ItemQuantity = int.Parse(numericUpDown1.Value.ToString());
                        tb_cat.TotalBuy = Convert.ToDouble(txtTotalprice.Text);
                        db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.labl_caption.Text = "تم تعديل صنق جديد";
                        toast.Show();

                        this.Close();
                    }

                }
            }
            catch 
            {

                toast.labl_caption.Text = " برجاء ادخال البيانات صحيحة";
                toast.Show();


            }

        }
        void PriceCalculation()
        {
            try
            {
                quatity = int.Parse(numericUpDown1.Value.ToString());

                buyprice = Convert.ToDouble(txt_price_buy.Text);
                // quatity = int.Parse(TxtItemNumber.Text);

                totalPrice = buyprice * quatity;
                txtTotalprice.Text = totalPrice.ToString();
            }catch
            {
                Toast toast = new Toast();

                toast.labl_caption.Text = " برجاء ادخال سعر الصنف أولا";
                toast.Show();
            }
          
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_price_buy_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotalprice_TextChanged(object sender, EventArgs e)
        {
            PriceCalculation();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PriceCalculation();
        }
    }
}
