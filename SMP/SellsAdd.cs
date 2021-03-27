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
            this.Close();
        }
        void PriceCalculation()
        {
            try
            {
                sellprice = Convert.ToDouble(txtSell.Text);

                // quatity = int.Parse(TxtItemNumber.Text);
                quatity = int.Parse(numericUpDown1.Value.ToString());
                totalPrice = sellprice * quatity;
                txtTotalPrice.Text = totalPrice.ToString();
            }
            catch
            {
                Toast toast = new Toast();
                toast.labl_caption.Text = "برجاء إختيار اسم  الصنف أ,لا ";
                toast.Show();
            }

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

            if (txtitemName.Text == "" || TxtCustomerName.Text == "" || numericUpDown1.Value == 0)
            {
                toast.labl_caption.Text = "يجيب ان تدخل البيانات";
                toast.Show();

                
            }
            
            else
            {

                if (BtnAdd.Text == "إضافة")
                {
                    sel_add.ItemName = txtitemName.Text;
                    sel_add.CustomerId = TxtCustomerName.Text;
                    sel_add.SellDate = DateTime.Parse(txtSellDate.Text);
                    // sel_add.InvoiceId = Convert.ToInt32( txtInvoiceName.Text);
                    sel_add.SellPrice = float.Parse(txtSell.Text);
                    sel_add.SellQuantity = int.Parse(numericUpDown1.Value.ToString());
                    sel_add.TotalPrrice = float.Parse(txtTotalPrice.Text);
                    db.Sells.Add(sel_add);

                    int i = int.Parse(txtitemName.SelectedValue.ToString());
                    TB_CAT tb_cat = db.TB_CAT.Where(x => x.ID == i).FirstOrDefault();
                    tb_cat.ItemQuantity -= int.Parse(numericUpDown1.Value.ToString());
                  
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
                    sel_add.ItemName = txtitemName.Text;
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




            private void SellsAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SMPDataSet8.TB_CAT' table. You can move, or remove it, as needed.
            this.tB_CATTableAdapter.Fill(this.dB_SMPDataSet8.TB_CAT);

        }

        private void txtitemName_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = Convert.ToInt32( txtitemName.SelectedValue.ToString());

            TB_CAT tb1_cat = db.TB_CAT.Where(x => x.ID == i).FirstOrDefault();
            txtSell.Text = tb1_cat.CAT_Price_sale.ToString();


        }


    }
}

 
