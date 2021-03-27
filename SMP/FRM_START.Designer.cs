
namespace SMP
{
    partial class FRM_START
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
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(6, 104);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarControl.Properties.Appearance.BackColor2 = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarControl.Properties.Appearance.BorderColor = System.Drawing.Color.Red;
            this.progressBarControl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarControl.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.progressBarControl.Properties.Appearance.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarControl.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarControl.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarControl.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Red;
            this.progressBarControl.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.progressBarControl.Properties.AppearanceDisabled.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarControl.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarControl.Properties.AppearanceFocused.BackColor2 = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarControl.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Red;
            this.progressBarControl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.progressBarControl.Properties.AppearanceFocused.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarControl.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarControl.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarControl.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Red;
            this.progressBarControl.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.progressBarControl.Properties.AppearanceReadOnly.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarControl.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            this.progressBarControl.Size = new System.Drawing.Size(420, 26);
            this.progressBarControl.TabIndex = 5;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(12, 175);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(47, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Location = new System.Drawing.Point(140, 31);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(191, 39);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "....بدا البرنامج ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FRM_START
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 226);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.progressBarControl);
            this.Name = "FRM_START";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_START_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private System.Windows.Forms.Timer timer1;
    }
}
