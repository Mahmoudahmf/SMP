//using SMP.dat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class frm_Add : Form
    {

        DB_SMPEntities1 db = new DB_SMPEntities1();

        double totalPrice;
        double buyprice;
        double sellprice;
        int quatity;
     
        Toast toast = new Toast();

        public frm_Add()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
        private void PriceCalculation()
        {
            sellprice = Convert.ToDouble(txtSell.Text);
            buyprice = Convert.ToDouble(txtBuy.Text);
            // quatity = int.Parse(TxtItemNumber.Text);
            quatity = int.Parse(numericUpDown1.Value.ToString());
            totalPrice = buyprice * quatity;
            txtTotalPrice.Text = totalPrice.ToString();
        }






        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            if (txtitemName.Text == "" || txtSuppliersName.Text == "")
            {
                toast.labl_caption.Text = "يجيب ان تدخل البيانات";
                toast.Show();

            }
            else
            {
                if (BtnAdd.Text == "إضافة")
                {
                    Buyer bu = new Buyer()

                    {

                        name = (txtitemName.Text),

                        SuppliersName = txtSuppliersName.Text,
                        BuyingDate = this.dateTimePicker1.Value.Date,
                        BuyingPrice = float.Parse(txtBuy.Text),
                        SellingPrice = float.Parse(txtSell.Text),
                        Profit = float.Parse(txtTotalPrice.Text),
                        itemsNumbers = int.Parse(numericUpDown1.Value.ToString())

                    };
                    db.Buyers.Add(bu);
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم اضافة صنق جديد";
                    toast.Show();
                    this.Close();

                }
                else
                {
                    Buyer buyer_add = new Buyer();
                    int i = int.Parse(txtid.Text);
                    buyer_add = db.Buyers.Where(s => s.Id == i).FirstOrDefault();

                    //sel_add.Id = id;
                    buyer_add.name = (txtitemName.Text);

                    buyer_add. SuppliersName = txtSuppliersName.Text;
                    buyer_add. BuyingDate = this.dateTimePicker1.Value.Date;
                    buyer_add. BuyingPrice = float.Parse(txtBuy.Text);
                    buyer_add.SellingPrice = float.Parse(txtSell.Text);
                    buyer_add.Profit = float.Parse(txtTotalPrice.Text);
                    buyer_add.itemsNumbers = int.Parse(numericUpDown1.Value.ToString());
                    db.SaveChanges();
                    toast.labl_caption.Text = "تم تعديل صنف مبيع جديد";
                    toast.Show();
                    this.Close();
                }
            }
        }
            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void btn_close_Click(object sender, EventArgs e)
            {

            }

            private void btn_close_Click_1(object sender, EventArgs e)
            {
                frm_Add.ActiveForm.Close();
            }
            private void txtTotalPrice_TextChanged_1(object sender, EventArgs e)
            {
                PriceCalculation();
            }



            private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
            {
                PriceCalculation();
            }

            private void Buyers_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'dB_SMPDataSet3.TB_SUP' table. You can move, or remove it, as needed.
                this.tB_SUPTableAdapter.Fill(this.dB_SMPDataSet3.TB_SUP);
                // TODO: This line of code loads data into the 'dB_SMPDataSet2.TB_CAT' table. You can move, or remove it, as needed.
                this.tB_CATTableAdapter1.Fill(this.dB_SMPDataSet2.TB_CAT);
                // TODO: This line of code loads data into the 'dB_SMPDataSet1.TB_CAT' table. You can move, or remove it, as needed.
                this.tB_CATTableAdapter.Fill(this.dB_SMPDataSet1.TB_CAT);

            }
        }
    }

