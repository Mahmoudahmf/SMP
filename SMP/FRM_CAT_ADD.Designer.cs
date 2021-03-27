
namespace SMP
{
    partial class FRM_CAT_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAT_ADD));
            this.labl_title = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price_buy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_price_sell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labl_title
            // 
            this.labl_title.AutoSize = true;
            this.labl_title.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labl_title.Location = new System.Drawing.Point(219, 30);
            this.labl_title.Name = "labl_title";
            this.labl_title.Size = new System.Drawing.Size(102, 32);
            this.labl_title.TabIndex = 2;
            this.labl_title.Text = "اسم الصنف";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txt_name.Location = new System.Drawing.Point(147, 80);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(253, 48);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(425, 278);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(115, 55);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "أضافة ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(12, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(52, 29);
            this.btn_close.TabIndex = 5;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(219, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "سعر الشراء";
            // 
            // txt_price_buy
            // 
            this.txt_price_buy.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txt_price_buy.Location = new System.Drawing.Point(147, 166);
            this.txt_price_buy.Name = "txt_price_buy";
            this.txt_price_buy.Size = new System.Drawing.Size(253, 48);
            this.txt_price_buy.TabIndex = 3;
            this.txt_price_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(223, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "سعر البيع";
            // 
            // txt_price_sell
            // 
            this.txt_price_sell.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txt_price_sell.Location = new System.Drawing.Point(147, 252);
            this.txt_price_sell.Name = "txt_price_sell";
            this.txt_price_sell.Size = new System.Drawing.Size(253, 48);
            this.txt_price_sell.TabIndex = 3;
            this.txt_price_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(552, 345);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_price_sell);
            this.Controls.Add(this.txt_price_buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.labl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CAT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labl_title;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_price_buy;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_price_sell;
    }
}