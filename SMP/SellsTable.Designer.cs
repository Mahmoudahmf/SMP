
namespace SMP
{
    partial class Pn_SellTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pn_SellTable));
            this.pn_tablesells = new DevExpress.XtraEditors.PanelControl();
            this.pn_tablesell = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Panel();
            this.btn_renew = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dB_SMPDataSet41 = new SMP.DB_SMPDataSet4();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sellsTableAdapter1 = new SMP.DB_SMPDataSet4TableAdapters.SellsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pn_tablesells)).BeginInit();
            this.pn_tablesells.SuspendLayout();
            this.pn_tablesell.SuspendLayout();
            this.Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_tablesells
            // 
            this.pn_tablesells.AutoSize = true;
            this.pn_tablesells.Controls.Add(this.pn_tablesell);
            this.pn_tablesells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_tablesells.Location = new System.Drawing.Point(0, 0);
            this.pn_tablesells.MaximumSize = new System.Drawing.Size(825, 0);
            this.pn_tablesells.Name = "pn_tablesells";
            this.pn_tablesells.Size = new System.Drawing.Size(825, 440);
            this.pn_tablesells.TabIndex = 0;
            // 
            // pn_tablesell
            // 
            this.pn_tablesell.Controls.Add(this.Footer);
            this.pn_tablesell.Controls.Add(this.gridControl1);
            this.pn_tablesell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_tablesell.Location = new System.Drawing.Point(2, 2);
            this.pn_tablesell.Name = "pn_tablesell";
            this.pn_tablesell.Size = new System.Drawing.Size(821, 436);
            this.pn_tablesell.TabIndex = 0;
            // 
            // Footer
            // 
            this.Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Footer.Controls.Add(this.btn_renew);
            this.Footer.Controls.Add(this.btn_delete);
            this.Footer.Controls.Add(this.btn_edit);
            this.Footer.Controls.Add(this.btn_add);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 370);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(821, 66);
            this.Footer.TabIndex = 4;
            // 
            // btn_renew
            // 
            this.btn_renew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renew.Appearance.Options.UseFont = true;
            this.btn_renew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_renew.ImageOptions.Image")));
            this.btn_renew.Location = new System.Drawing.Point(612, 11);
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
            this.btn_delete.Location = new System.Drawing.Point(410, 11);
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
            this.btn_edit.Location = new System.Drawing.Point(230, 11);
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
            this.btn_add.Location = new System.Drawing.Point(63, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(111, 44);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "أضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.AccessibleName = "gridControl1";
            this.gridControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gridControl1.DataMember = "Sells";
            this.gridControl1.DataSource = this.dB_SMPDataSet41;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(821, 436);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // dB_SMPDataSet41
            // 
            this.dB_SMPDataSet41.DataSetName = "DB_SMPDataSet4";
            this.dB_SMPDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemName,
            this.colCustomerId,
            this.colSellDate,
            this.colSellPrice,
            this.colSellQuantity,
            this.colTotalPrrice,
            this.colInvoiceId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "ابحث هنا ";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemName
            // 
            this.colItemName.AppearanceCell.Options.UseTextOptions = true;
            this.colItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colItemName.Caption = "اسم الصنف";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colItemName.ImageOptions.Image")));
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            this.colItemName.Width = 102;
            // 
            // colCustomerId
            // 
            this.colCustomerId.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerId.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colCustomerId.AppearanceHeader.Options.UseBackColor = true;
            this.colCustomerId.Caption = "اسم العميل";
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerId.ImageOptions.Image")));
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 1;
            this.colCustomerId.Width = 102;
            // 
            // colSellDate
            // 
            this.colSellDate.AppearanceCell.Options.UseTextOptions = true;
            this.colSellDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSellDate.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSellDate.AppearanceHeader.Options.UseBackColor = true;
            this.colSellDate.Caption = "تاريخ البيع";
            this.colSellDate.FieldName = "SellDate";
            this.colSellDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSellDate.ImageOptions.Image")));
            this.colSellDate.Name = "colSellDate";
            this.colSellDate.Visible = true;
            this.colSellDate.VisibleIndex = 2;
            this.colSellDate.Width = 102;
            // 
            // colSellPrice
            // 
            this.colSellPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colSellPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSellPrice.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSellPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colSellPrice.Caption = "سعر البيع";
            this.colSellPrice.FieldName = "SellPrice";
            this.colSellPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSellPrice.ImageOptions.Image")));
            this.colSellPrice.Name = "colSellPrice";
            this.colSellPrice.Visible = true;
            this.colSellPrice.VisibleIndex = 3;
            this.colSellPrice.Width = 83;
            // 
            // colSellQuantity
            // 
            this.colSellQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colSellQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSellQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSellQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colSellQuantity.Caption = "العدد";
            this.colSellQuantity.FieldName = "SellQuantity";
            this.colSellQuantity.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSellQuantity.ImageOptions.Image")));
            this.colSellQuantity.Name = "colSellQuantity";
            this.colSellQuantity.Visible = true;
            this.colSellQuantity.VisibleIndex = 4;
            this.colSellQuantity.Width = 66;
            // 
            // colTotalPrrice
            // 
            this.colTotalPrrice.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colTotalPrrice.AppearanceHeader.Options.UseBackColor = true;
            this.colTotalPrrice.Caption = "إجمالى السعر";
            this.colTotalPrrice.FieldName = "TotalPrrice";
            this.colTotalPrrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTotalPrrice.ImageOptions.Image")));
            this.colTotalPrrice.Name = "colTotalPrrice";
            this.colTotalPrrice.Visible = true;
            this.colTotalPrrice.VisibleIndex = 5;
            this.colTotalPrrice.Width = 126;
            // 
            // colInvoiceId
            // 
            this.colInvoiceId.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colInvoiceId.AppearanceHeader.Options.UseBackColor = true;
            this.colInvoiceId.Caption = "رقم الفاتورة";
            this.colInvoiceId.FieldName = "InvoiceId";
            this.colInvoiceId.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colInvoiceId.ImageOptions.Image")));
            this.colInvoiceId.Name = "colInvoiceId";
            this.colInvoiceId.Visible = true;
            this.colInvoiceId.VisibleIndex = 6;
            this.colInvoiceId.Width = 101;
            // 
            // sellsTableAdapter1
            // 
            this.sellsTableAdapter1.ClearBeforeFill = true;
            // 
            // Pn_SellTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(863, 440);
            this.Controls.Add(this.pn_tablesells);
            this.Name = "Pn_SellTable";
            this.Text = "Sells";
            this.Load += new System.EventHandler(this.Pn_SellTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pn_tablesells)).EndInit();
            this.pn_tablesells.ResumeLayout(false);
            this.pn_tablesell.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl pn_tablesells;
        public System.Windows.Forms.Panel pn_tablesell;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colSellDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellQuantity;
        private System.Windows.Forms.Panel Footer;
        private DevExpress.XtraEditors.SimpleButton btn_renew;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DB_SMPDataSet4 dB_SMPDataSet41;
        private DB_SMPDataSet4TableAdapters.SellsTableAdapter sellsTableAdapter1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrrice;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceId;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
    }
}