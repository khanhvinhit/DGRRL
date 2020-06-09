namespace DGDRL.APP.GUI
{
    partial class FrmUpdateDiem
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
            this.numDiem = new DevExpress.XtraEditors.SpinEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // numDiem
            // 
            this.numDiem.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDiem.Location = new System.Drawing.Point(10, 9);
            this.numDiem.Name = "numDiem";
            this.numDiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numDiem.Properties.IsFloatValue = false;
            this.numDiem.Properties.Mask.EditMask = "N00";
            this.numDiem.Size = new System.Drawing.Size(62, 20);
            this.numDiem.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(78, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(33, 19);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmUpdateDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 39);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdateDiem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmUpdateDiem";
            ((System.ComponentModel.ISupportInitialize)(this.numDiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit numDiem;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}