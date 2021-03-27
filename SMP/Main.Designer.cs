
namespace SMP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Buyers = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sup = new DevExpress.XtraEditors.SimpleButton();
            this.btnSells = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Report = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.pn_titlenavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_rol = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_col = new DevExpress.XtraEditors.SimpleButton();
            this.pn_top = new System.Windows.Forms.Panel();
            this.labl_title = new System.Windows.Forms.Label();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_logout = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.pn_titlenavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navbar.Location = new System.Drawing.Point(845, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pn_navbar.Size = new System.Drawing.Size(195, 597);
            this.pn_navbar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_cat);
            this.flowLayoutPanel1.Controls.Add(this.btn_Buyers);
            this.flowLayoutPanel1.Controls.Add(this.btn_sup);
            this.flowLayoutPanel1.Controls.Add(this.btnSells);
            this.flowLayoutPanel1.Controls.Add(this.btn_Report);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(195, 359);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_home.Appearance.Options.UseFont = true;
            this.btn_home.Appearance.Options.UseForeColor = true;
            this.btn_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.ImageOptions.Image")));
            this.btn_home.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_home.Location = new System.Drawing.Point(-17, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_home.Size = new System.Drawing.Size(209, 37);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "الرئيسية";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_cat.Appearance.Options.UseFont = true;
            this.btn_cat.Appearance.Options.UseForeColor = true;
            this.btn_cat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cat.ImageOptions.Image")));
            this.btn_cat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_cat.Location = new System.Drawing.Point(-17, 46);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_cat.Size = new System.Drawing.Size(209, 37);
            this.btn_cat.TabIndex = 1;
            this.btn_cat.Text = "الاصناف";
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_Buyers
            // 
            this.btn_Buyers.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buyers.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Buyers.Appearance.Options.UseFont = true;
            this.btn_Buyers.Appearance.Options.UseForeColor = true;
            this.btn_Buyers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buyers.ImageOptions.Image")));
            this.btn_Buyers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Buyers.Location = new System.Drawing.Point(-17, 89);
            this.btn_Buyers.Name = "btn_Buyers";
            this.btn_Buyers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Buyers.Size = new System.Drawing.Size(209, 37);
            this.btn_Buyers.TabIndex = 2;
            this.btn_Buyers.Text = "المشتريات ";
            this.btn_Buyers.Click += new System.EventHandler(this.btn_Buyers_Click);
            // 
            // btn_sup
            // 
            this.btn_sup.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_sup.Appearance.Options.UseFont = true;
            this.btn_sup.Appearance.Options.UseForeColor = true;
            this.btn_sup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sup.ImageOptions.Image")));
            this.btn_sup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_sup.Location = new System.Drawing.Point(-17, 132);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_sup.Size = new System.Drawing.Size(209, 37);
            this.btn_sup.TabIndex = 3;
            this.btn_sup.Text = "الموردين";
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btnSells
            // 
            this.btnSells.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSells.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSells.Appearance.Options.UseFont = true;
            this.btnSells.Appearance.Options.UseForeColor = true;
            this.btnSells.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSells.ImageOptions.Image")));
            this.btnSells.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSells.Location = new System.Drawing.Point(-17, 175);
            this.btnSells.Name = "btnSells";
            this.btnSells.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSells.Size = new System.Drawing.Size(209, 37);
            this.btnSells.TabIndex = 4;
            this.btnSells.Text = "المبيعات";
            this.btnSells.Click += new System.EventHandler(this.btnSells_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Report.Appearance.Options.UseFont = true;
            this.btn_Report.Appearance.Options.UseForeColor = true;
            this.btn_Report.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.btn_Report.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Report.Location = new System.Drawing.Point(-17, 218);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Report.Size = new System.Drawing.Size(209, 37);
            this.btn_Report.TabIndex = 5;
            this.btn_Report.Text = "التقارير";
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.Appearance.Options.UseForeColor = true;
            this.btn_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.btn_users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_users.Location = new System.Drawing.Point(-17, 261);
            this.btn_users.Name = "btn_users";
            this.btn_users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_users.Size = new System.Drawing.Size(209, 37);
            this.btn_users.TabIndex = 6;
            this.btn_users.Text = "المستخدمين";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click_1);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.Controls.Add(this.pn_titlenavbar);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel2);
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(195, 238);
            this.pn_headernavbar.TabIndex = 0;
            // 
            // pn_titlenavbar
            // 
            this.pn_titlenavbar.Controls.Add(this.pictureBox1);
            this.pn_titlenavbar.Controls.Add(this.label_rol);
            this.pn_titlenavbar.Controls.Add(this.label_username);
            this.pn_titlenavbar.Location = new System.Drawing.Point(52, 3);
            this.pn_titlenavbar.Name = "pn_titlenavbar";
            this.pn_titlenavbar.Size = new System.Drawing.Size(140, 176);
            this.pn_titlenavbar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_rol
            // 
            this.label_rol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rol.AutoSize = true;
            this.label_rol.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_rol.Location = new System.Drawing.Point(52, 152);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(29, 19);
            this.label_rol.TabIndex = 1;
            this.label_rol.Text = "ادمن";
            // 
            // label_username
            // 
            this.label_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_username.AutoSize = true;
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_username.Location = new System.Drawing.Point(76, 133);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(52, 19);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "ابرام ايمن";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_col);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(40, 176);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btn_col
            // 
            this.btn_col.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_col.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_col.ImageOptions.Image")));
            this.btn_col.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_col.Location = new System.Drawing.Point(4, 3);
            this.btn_col.Name = "btn_col";
            this.btn_col.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_col.Size = new System.Drawing.Size(33, 35);
            this.btn_col.TabIndex = 0;
            this.btn_col.Click += new System.EventHandler(this.btn_col_Click);
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_top.Controls.Add(this.btn_logout);
            this.pn_top.Controls.Add(this.labl_title);
            this.pn_top.Controls.Add(this.btn_min);
            this.pn_top.Controls.Add(this.btn_max);
            this.pn_top.Controls.Add(this.btn_close);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(845, 55);
            this.pn_top.TabIndex = 1;
            // 
            // labl_title
            // 
            this.labl_title.AutoSize = true;
            this.labl_title.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl_title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labl_title.Location = new System.Drawing.Point(414, 13);
            this.labl_title.Name = "labl_title";
            this.labl_title.Size = new System.Drawing.Size(69, 27);
            this.labl_title.TabIndex = 1;
            this.labl_title.Text = "الرئيسية";
            // 
            // btn_min
            // 
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(95, 10);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_min.Size = new System.Drawing.Size(33, 30);
            this.btn_min.TabIndex = 0;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.ImageOptions.Image")));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(49, 10);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(40, 30);
            this.btn_max.TabIndex = 0;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(3, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(40, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_Container
            // 
            this.pn_Container.BackColor = System.Drawing.Color.White;
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 55);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(845, 542);
            this.pn_Container.TabIndex = 2;
            this.pn_Container.LocationChanged += new System.EventHandler(this.pn_Container_LocationChanged);
            this.pn_Container.Leave += new System.EventHandler(this.pn_Container_Leave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Appearance.Options.UseFont = true;
            this.btn_logout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_logout.ImageOptions.SvgImage")));
            this.btn_logout.Location = new System.Drawing.Point(167, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(157, 49);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "تسجيل الخروج";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 597);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_titlenavbar.ResumeLayout(false);
            this.pn_titlenavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_home;
        private System.Windows.Forms.Panel pn_headernavbar;
        private DevExpress.XtraEditors.SimpleButton btn_col;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labl_title;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Panel pn_Container;
        private DevExpress.XtraEditors.SimpleButton btn_cat;
        private DevExpress.XtraEditors.SimpleButton btn_sup;
        private DevExpress.XtraEditors.SimpleButton btnSells;
        private System.Windows.Forms.Panel pn_titlenavbar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public DevExpress.XtraEditors.SimpleButton btn_Buyers;
        private DevExpress.XtraEditors.SimpleButton btn_logout;
        public System.Windows.Forms.Label label_rol;
        public System.Windows.Forms.Label label_username;
        public DevExpress.XtraEditors.SimpleButton btn_users;
        public DevExpress.XtraEditors.SimpleButton btn_Report;
    }
}

