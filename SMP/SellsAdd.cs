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

    public partial class SellsAdd : Form
    {

        DB_SMPEntities1 db = new DB_SMPEntities1();
        
        double totalPrice;
       
        double sellprice;
        int quatity;
         public int id;
       
        public SellsAdd()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            SellsAdd.ActiveForm.Close();
        }
         void PriceCalculation()
        {
            sellprice =Convert.ToDouble(txtSell.Text);
           
            // quatity = int.Parse(TxtItemNumber.Text);
            quatity = int.Parse(numericUpDown1.Value.ToString());
            totalPrice = sellprice * quatity;
            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            PriceCalculation();
        }

        private void txtSell_TextChanged(object sender, EventArgs e)
        {
            PriceCalculation();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PriceCalculation();
        }
       
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Sell sel_add = new Sell();
           
            if (txtItemName.Text == "" || TxtCustomerName.Text == "")
            {
                toast.labl_caption.Text = "يجيب ان تدخل البيانات";
                toast.Show();

            }
            else
            {
               if(BtnAdd.Text== "إضافة") 
                {
                    sel_add.ItemName = txtItemName.Text;
                    sel_add.CustomerId = TxtCustomerName.Text;
                    sel_add.SellDate = DateTime.Parse(txtSellDate.Text);
                   // sel_add.InvoiceId = Convert.ToInt32( txtInvoiceName.Text);
                    sel_add.SellPrice = float.Parse(txtSell.Text);
                    sel_add.SellQuantity = int.Parse(numericUpDown1.Value.ToString());
                    sel_add.TotalPrrice = float.Parse(txtTotalPrice.Text);
                    db.Sells.Add(sel_add);
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم اضافة صنف بيع جديد";
                    toast.Show();
                    this.Close();
                  
                }
                else
                {
                    int i = int.Parse(txtid.Text);
                    sel_add = db.Sells.Where(s => s.Id == i).FirstOrDefault();
                  
                    //sel_add.Id = id;
                    sel_add.ItemName = txtItemName.Text;
                    sel_add.CustomerId = TxtCustomerName.Text;
                    sel_add.SellDate = DateTime.Parse(txtSellDate.Text);
                    // sel_add.InvoiceId = int.Parse(txtInvoiceName.Text);
                    sel_add.SellPrice = float.Parse(txtSell.Text);
                    sel_add.SellQuantity = int.Parse(numericUpDown1.Value.ToString());
                    sel_add.TotalPrrice = float.Parse(txtTotalPrice.Text);
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم تعديل صنف مبيع جديد";
                    toast.Show();
                    this.Close();
                  
                }

            }



        }
               
      
    }
}

 
