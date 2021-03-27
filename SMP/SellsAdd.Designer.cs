
namespace SMP
{
    partial class SellsAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellsAdd));
            this.pn_SellAdd = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSell = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItemName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtSellDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtCustomerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pn_SellAdd)).BeginInit();
            this.pn_SellAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_SellAdd
            // 
            this.pn_SellAdd.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pn_SellAdd.Appearance.Options.UseBackColor = true;
            this.pn_SellAdd.Controls.Add(this.btn_close);
            this.pn_SellAdd.Controls.Add(this.BtnAdd);
            this.pn_SellAdd.Controls.Add(this.groupBox2);
            this.pn_SellAdd.Controls.Add(this.groupBox1);
            this.pn_SellAdd.Location = new System.Drawing.Point(12, 12);
            this.pn_SellAdd.Name = "pn_SellAdd";
            this.pn_SellAdd.Size = new System.Drawing.Size(776, 465);
            this.pn_SellAdd.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.btn_close.Appearance.Options.UseForeColor = true;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(9, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(64, 47);
            this.btn_close.TabIndex = 13;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.AppearanceDisabled.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnAdd.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.BtnAdd.Location = new System.Drawing.Point(294, 391);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(111, 58);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "إضافة";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.Controls.Add(this.txtSell);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(762, 164);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملية البيع";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(17, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 22);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(217, 118);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(231, 29);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(493, 123);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(108, 18);
            this.bunifuCustomLabel9.TabIndex = 15;
            this.bunifuCustomLabel9.Text = "إجمالى السعر";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(285, 40);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(83, 18);
            this.bunifuCustomLabel8.TabIndex = 13;
            this.bunifuCustomLabel8.Text = "الكمية";
            // 
            // txtSell
            // 
            this.txtSell.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Location = new System.Drawing.Point(409, 31);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(231, 26);
            this.txtSell.TabIndex = 12;
            this.txtSell.Text = "0";
            this.txtSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSell.TextChanged += new System.EventHandler(this.txtSell_TextChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(641, 37);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 18);
            this.bunifuCustomLabel7.TabIndex = 11;
            this.bunifuCustomLabel7.Text = "سعر القطعة";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.txtSellDate);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.TxtCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(762, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات الأساسية ";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtItemName.Location = new System.Drawing.Point(409, 20);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(231, 22);
            this.txtItemName.TabIndex = 20;
            // 
            // txtSellDate
            // 
            this.txtSellDate.Location = new System.Drawing.Point(233, 87);
            this.txtSellDate.Name = "txtSellDate";
            this.txtSellDate.Size = new System.Drawing.Size(231, 22);
            this.txtSellDate.TabIndex = 19;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(493, 87);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 18);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "تاريخ البيع";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(679, 25);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(70, 18);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "اسم الصنف";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(285, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 18);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "اسم العميل";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCustomerName.Location = new System.Drawing.Point(17, 21);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(231, 22);
            this.TxtCustomerName.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(39, 87);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 21;
            this.txtid.Visible = false;
            // 
            // SellsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.pn_SellAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellsAdd";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pn_SellAdd)).EndInit();
            this.pn_SellAdd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pn_SellAdd;
        public System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCustomerName;
        private System.Windows.Forms.GroupBox groupBox2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotalPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtSell;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        public DevExpress.XtraEditors.SimpleButton BtnAdd;
        public DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtItemName;
        public System.Windows.Forms.DateTimePicker txtSellDate;
        public System.Windows.Forms.TextBox txtid;
    }
}