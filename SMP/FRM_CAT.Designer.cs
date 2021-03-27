
namespace SMP
{
    partial class FRM_CAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAT));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAT_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAT_Price_buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAT_Price_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Footer = new System.Windows.Forms.Panel();
            this.btn_renew = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.colItemQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Controls.Add(this.Footer);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(845, 563);
            this.pn_cat.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP.TB_CAT);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(845, 497);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAT_Name,
            this.colCAT_Price_buy,
            this.colCAT_Price_sale,
            this.colItemQuantity,
            this.colTotalBuy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "ادخل الكلمة التي تريد البحث عنها";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCAT_Name
            // 
            this.colCAT_Name.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colCAT_Name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colCAT_Name.AppearanceCell.BorderColor = System.Drawing.Color.White;
            this.colCAT_Name.AppearanceCell.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCAT_Name.AppearanceCell.Options.UseBackColor = true;
            this.colCAT_Name.AppearanceCell.Options.UseBorderColor = true;
            this.colCAT_Name.AppearanceCell.Options.UseFont = true;
            this.colCAT_Name.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colCAT_Name.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCAT_Name.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colCAT_Name.AppearanceHeader.Options.UseBackColor = true;
            this.colCAT_Name.AppearanceHeader.Options.UseFont = true;
            this.colCAT_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCAT_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAT_Name.Caption = "اسم الصنف";
            this.colCAT_Name.FieldName = "CAT_Name";
            this.colCAT_Name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCAT_Name.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCAT_Name.ImageOptions.Image")));
            this.colCAT_Name.Name = "colCAT_Name";
            this.colCAT_Name.Visible = true;
            this.colCAT_Name.VisibleIndex = 0;
            this.colCAT_Name.Width = 178;
            // 
            // colCAT_Price_buy
            // 
            this.colCAT_Price_buy.AppearanceCell.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.colCAT_Price_buy.AppearanceCell.Options.UseFont = true;
            this.colCAT_Price_buy.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colCAT_Price_buy.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCAT_Price_buy.AppearanceHeader.Options.UseBackColor = true;
            this.colCAT_Price_buy.AppearanceHeader.Options.UseFont = true;
            this.colCAT_Price_buy.AppearanceHeader.Options.UseTextOptions = true;
            this.colCAT_Price_buy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAT_Price_buy.Caption = "سعر الشراء(جنية) ";
            this.colCAT_Price_buy.FieldName = "CAT_Price_buy";
            this.colCAT_Price_buy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCAT_Price_buy.ImageOptions.Image")));
            this.colCAT_Price_buy.Name = "colCAT_Price_buy";
            this.colCAT_Price_buy.Visible = true;
            this.colCAT_Price_buy.VisibleIndex = 1;
            this.colCAT_Price_buy.Width = 169;
            // 
            // colCAT_Price_sale
            // 
            this.colCAT_Price_sale.AppearanceCell.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.colCAT_Price_sale.AppearanceCell.Options.UseFont = true;
            this.colCAT_Price_sale.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colCAT_Price_sale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCAT_Price_sale.AppearanceHeader.Options.UseBackColor = true;
            this.colCAT_Price_sale.AppearanceHeader.Options.UseFont = true;
            this.colCAT_Price_sale.AppearanceHeader.Options.UseTextOptions = true;
            this.colCAT_Price_sale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAT_Price_sale.Caption = "سعر البيع(جنية) ";
            this.colCAT_Price_sale.FieldName = "CAT_Price_sale";
            this.colCAT_Price_sale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCAT_Price_sale.ImageOptions.Image")));
            this.colCAT_Price_sale.Name = "colCAT_Price_sale";
            this.colCAT_Price_sale.Visible = true;
            this.colCAT_Price_sale.VisibleIndex = 2;
            this.colCAT_Price_sale.Width = 186;
            // 
            // Footer
            // 
            this.Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Footer.Controls.Add(this.btn_renew);
            this.Footer.Controls.Add(this.btn_delete);
            this.Footer.Controls.Add(this.btn_edit);
            this.Footer.Controls.Add(this.btn_add);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 497);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(845, 66);
            this.Footer.TabIndex = 2;
            // 
            // btn_renew
            // 
            this.btn_renew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renew.Appearance.Options.UseFont = true;
            this.btn_renew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_renew.ImageOptions.Image")));
            this.btn_renew.Location = new System.Drawing.Point(681, 9);
            this.btn_renew.Name = "btn_renew";
            this.btn_renew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_renew.Size = new System.Drawing.Size(111, 44);
            this.btn_renew.TabIndex = 1;
            this.btn_renew.Text = "تحديث";
            this.btn_renew.Click += new System.EventHandler(this.btn_renew_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(460, 9);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delete.Size = new System.Drawing.Size(111, 44);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(266, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_edit.Size = new System.Drawing.Size(111, 44);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(64, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(111, 44);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "أضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colItemQuantity.AppearanceHeader.FontSizeDelta = 2;
            this.colItemQuantity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colItemQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colItemQuantity.AppearanceHeader.Options.UseFont = true;
            this.colItemQuantity.Caption = "عدد الأصناف";
            this.colItemQuantity.FieldName = "ItemQuantity";
            this.colItemQuantity.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colItemQuantity.ImageOptions.Image")));
            this.colItemQuantity.Name = "colItemQuantity";
            this.colItemQuantity.Visible = true;
            this.colItemQuantity.VisibleIndex = 3;
            this.colItemQuantity.Width = 120;
            // 
            // colTotalBuy
            // 
            this.colTotalBuy.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colTotalBuy.AppearanceHeader.FontSizeDelta = 1;
            this.colTotalBuy.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTotalBuy.AppearanceHeader.Options.UseBackColor = true;
            this.colTotalBuy.AppearanceHeader.Options.UseFont = true;
            this.colTotalBuy.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalBuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalBuy.Caption = "اجمالى الشراء(جنية)";
            this.colTotalBuy.FieldName = "TotalBuy";
            this.colTotalBuy.Name = "colTotalBuy";
            this.colTotalBuy.Visible = true;
            this.colTotalBuy.VisibleIndex = 4;
            this.colTotalBuy.Width = 165;
            // 
            // FRM_CAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CAT";
            this.Text = "FRM_CAT";
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cat;
        private System.Windows.Forms.Panel Footer;
        private DevExpress.XtraEditors.SimpleButton btn_renew;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAT_Name;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAT_Price_buy;
        private DevExpress.XtraGrid.Columns.GridColumn colCAT_Price_sale;
        private DevExpress.XtraGrid.Columns.GridColumn colItemQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalBuy;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}