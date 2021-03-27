
namespace SMP
{
    partial class BuyersTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyersTable));
            this.Pn_tableBuy = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dB_SMPDataSet1 = new SMP.DB_SMPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemsNumbers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliersName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Footer = new System.Windows.Forms.Panel();
            this.btn_renew = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.buyersTableAdapter1 = new SMP.DB_SMPDataSetTableAdapters.BuyersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Pn_tableBuy)).BeginInit();
            this.Pn_tableBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pn_tableBuy
            // 
            this.Pn_tableBuy.Controls.Add(this.gridControl1);
            this.Pn_tableBuy.Controls.Add(this.Footer);
            this.Pn_tableBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_tableBuy.Location = new System.Drawing.Point(0, 0);
            this.Pn_tableBuy.Name = "Pn_tableBuy";
            this.Pn_tableBuy.Size = new System.Drawing.Size(854, 349);
            this.Pn_tableBuy.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Buyers";
            this.gridControl1.DataSource = this.dB_SMPDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(850, 279);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // dB_SMPDataSet1
            // 
            this.dB_SMPDataSet1.DataSetName = "DB_SMPDataSet";
            this.dB_SMPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Cyan;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colBuyingDate,
            this.colBuyingPrice,
            this.colSellingPrice,
            this.colitemsNumbers,
            this.colProfit,
            this.colSuppliersName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "قم بالبحث هنا";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.AppearanceCell.Options.UseTextOptions = true;
            this.colname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colname.AppearanceHeader.Options.UseBackColor = true;
            this.colname.AppearanceHeader.Options.UseTextOptions = true;
            this.colname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname.Caption = "اسم الصنف";
            this.colname.FieldName = "name";
            this.colname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colname.ImageOptions.Image")));
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 117;
            // 
            // colBuyingDate
            // 
            this.colBuyingDate.AppearanceCell.Options.UseTextOptions = true;
            this.colBuyingDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBuyingDate.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colBuyingDate.AppearanceHeader.Options.UseBackColor = true;
            this.colBuyingDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBuyingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBuyingDate.Caption = "تاريخ الشراء";
            this.colBuyingDate.FieldName = "BuyingDate";
            this.colBuyingDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colBuyingDate.ImageOptions.Image")));
            this.colBuyingDate.Name = "colBuyingDate";
            this.colBuyingDate.Visible = true;
            this.colBuyingDate.VisibleIndex = 1;
            this.colBuyingDate.Width = 117;
            // 
            // colBuyingPrice
            // 
            this.colBuyingPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colBuyingPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBuyingPrice.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colBuyingPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colBuyingPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colBuyingPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBuyingPrice.Caption = "سعر الشراء(جنية)";
            this.colBuyingPrice.FieldName = "BuyingPrice";
            this.colBuyingPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colBuyingPrice.ImageOptions.Image")));
            this.colBuyingPrice.Name = "colBuyingPrice";
            this.colBuyingPrice.Visible = true;
            this.colBuyingPrice.VisibleIndex = 2;
            this.colBuyingPrice.Width = 117;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colSellingPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSellingPrice.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSellingPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colSellingPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colSellingPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSellingPrice.Caption = "سعر البيع(جنية)";
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSellingPrice.ImageOptions.Image")));
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.VisibleIndex = 3;
            this.colSellingPrice.Width = 117;
            // 
            // colitemsNumbers
            // 
            this.colitemsNumbers.AppearanceCell.Options.UseTextOptions = true;
            this.colitemsNumbers.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colitemsNumbers.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colitemsNumbers.AppearanceHeader.Options.UseBackColor = true;
            this.colitemsNumbers.AppearanceHeader.Options.UseTextOptions = true;
            this.colitemsNumbers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colitemsNumbers.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colitemsNumbers.Caption = "العدد";
            this.colitemsNumbers.FieldName = "itemsNumbers";
            this.colitemsNumbers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colitemsNumbers.ImageOptions.Image")));
            this.colitemsNumbers.Name = "colitemsNumbers";
            this.colitemsNumbers.Visible = true;
            this.colitemsNumbers.VisibleIndex = 4;
            this.colitemsNumbers.Width = 95;
            // 
            // colProfit
            // 
            this.colProfit.AppearanceCell.Options.UseTextOptions = true;
            this.colProfit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colProfit.AppearanceHeader.Options.UseBackColor = true;
            this.colProfit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProfit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit.Caption = "إجمالى الشراء(جنية)";
            this.colProfit.FieldName = "Profit";
            this.colProfit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colProfit.ImageOptions.Image")));
            this.colProfit.Name = "colProfit";
            this.colProfit.Visible = true;
            this.colProfit.VisibleIndex = 5;
            this.colProfit.Width = 127;
            // 
            // colSuppliersName
            // 
            this.colSuppliersName.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliersName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliersName.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSuppliersName.AppearanceHeader.Options.UseBackColor = true;
            this.colSuppliersName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliersName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliersName.Caption = "اسم المورد";
            this.colSuppliersName.FieldName = "SuppliersName";
            this.colSuppliersName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSuppliersName.ImageOptions.Image")));
            this.colSuppliersName.Name = "colSuppliersName";
            this.colSuppliersName.Visible = true;
            this.colSuppliersName.VisibleIndex = 6;
            this.colSuppliersName.Width = 135;
            // 
            // Footer
            // 
            this.Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Footer.Controls.Add(this.btn_renew);
            this.Footer.Controls.Add(this.btn_delete);
            this.Footer.Controls.Add(this.btn_edit);
            this.Footer.Controls.Add(this.btn_add);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(2, 281);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(850, 66);
            this.Footer.TabIndex = 3;
            // 
            // btn_renew
            // 
            this.btn_renew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renew.Appearance.Options.UseFont = true;
            this.btn_renew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_renew.ImageOptions.Image")));
            this.btn_renew.Location = new System.Drawing.Point(647, 9);
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
            this.btn_delete.Location = new System.Drawing.Point(428, 9);
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
            this.btn_edit.Location = new System.Drawing.Point(237, 9);
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
            this.btn_add.Location = new System.Drawing.Point(40, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(111, 44);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "أضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // buyersTableAdapter1
            // 
            this.buyersTableAdapter1.ClearBeforeFill = true;
            // 
            // BuyersTable
            // 
            this.ClientSize = new System.Drawing.Size(854, 349);
            this.Controls.Add(this.Pn_tableBuy);
            this.Name = "BuyersTable";
            ((System.ComponentModel.ISupportInitialize)(this.Pn_tableBuy)).EndInit();
            this.Pn_tableBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.PanelControl Pn_tableBuy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel Footer;
        private DevExpress.XtraEditors.SimpleButton btn_renew;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DB_SMPDataSet dB_SMPDataSet1;
        private DB_SMPDataSetTableAdapters.BuyersTableAdapter buyersTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colitemsNumbers;
        private DevExpress.XtraGrid.Columns.GridColumn colProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliersName;
    }
}