﻿namespace DGDRL.APP.GUI
{
    partial class FrmAddNewEditLuaChonChiTiet
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
            this.txtNoiDung = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.numDiemMax = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numDiemMin = new DevExpress.XtraEditors.SpinEdit();
            this.cbbDanhSachTC = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMS = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDanhSachTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(12, 63);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(304, 110);
            this.txtNoiDung.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtMS);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.numDiemMax);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.numDiemMin);
            this.panelControl1.Controls.Add(this.txtNoiDung);
            this.panelControl1.Controls.Add(this.cbbDanhSachTC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(331, 366);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 224);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Điểm tối đa";
            // 
            // numDiemMax
            // 
            this.numDiemMax.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDiemMax.Location = new System.Drawing.Point(12, 243);
            this.numDiemMax.Name = "numDiemMax";
            this.numDiemMax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numDiemMax.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numDiemMax.Properties.Mask.EditMask = "n0";
            this.numDiemMax.Size = new System.Drawing.Size(304, 20);
            this.numDiemMax.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 269);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nội Dung Chi Tiêu";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 179);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Điểm tối thiểu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mô tả";
            // 
            // numDiemMin
            // 
            this.numDiemMin.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDiemMin.Location = new System.Drawing.Point(12, 198);
            this.numDiemMin.Name = "numDiemMin";
            this.numDiemMin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numDiemMin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numDiemMin.Properties.Mask.EditMask = "n0";
            this.numDiemMin.Size = new System.Drawing.Size(304, 20);
            this.numDiemMin.TabIndex = 3;
            // 
            // cbbDanhSachTC
            // 
            this.cbbDanhSachTC.Location = new System.Drawing.Point(12, 288);
            this.cbbDanhSachTC.Name = "cbbDanhSachTC";
            this.cbbDanhSachTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDanhSachTC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoiDung", "Nội Dung")});
            this.cbbDanhSachTC.Properties.NullText = "";
            this.cbbDanhSachTC.Size = new System.Drawing.Size(304, 20);
            this.cbbDanhSachTC.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "STT";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Nội Dung";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(13, 21);
            this.txtMS.Name = "txtMS";
            this.txtMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMS.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtMS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtMS.Size = new System.Drawing.Size(304, 20);
            this.txtMS.TabIndex = 11;
            // 
            // FrmAddNewEditLuaChonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 366);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewEditLuaChonChiTiet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewEditLuaChonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDanhSachTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMS.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtNoiDung;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit numDiemMin;
        private DevExpress.XtraEditors.LookUpEdit cbbDanhSachTC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit numDiemMax;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit txtMS;
    }
}