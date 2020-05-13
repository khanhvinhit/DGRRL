namespace DGDRL.APP.GUI
{
    partial class usDanhSachDanhGiaDiemRenLuyen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbbNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.griditem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhoa_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TenKhoa_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MucDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SVDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LTDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GVDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcDanhSach);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbbHocKy);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.cbbNamHoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(952, 485);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(315, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Học Kỳ";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.Location = new System.Drawing.Point(315, 24);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbHocKy.Properties.NullText = "";
            this.cbbHocKy.Properties.PopupSizeable = false;
            this.cbbHocKy.Size = new System.Drawing.Size(304, 20);
            this.cbbHocKy.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Năm Học";
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.Location = new System.Drawing.Point(5, 24);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNamHoc.Properties.NullText = "";
            this.cbbNamHoc.Properties.PopupSizeable = false;
            this.cbbNamHoc.Size = new System.Drawing.Size(304, 20);
            this.cbbNamHoc.TabIndex = 13;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSach.Location = new System.Drawing.Point(5, 50);
            this.gcDanhSach.MainView = this.griditem;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MaKhoa_Edit,
            this.TenKhoa_Edit});
            this.gcDanhSach.Size = new System.Drawing.Size(942, 430);
            this.gcDanhSach.TabIndex = 14;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griditem});
            // 
            // griditem
            // 
            this.griditem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.NoiDung,
            this.MucDiem,
            this.SVDiem,
            this.DiemThuc,
            this.LTDiem,
            this.GVDiem,
            this.GhiChu});
            this.griditem.GridControl = this.gcDanhSach;
            this.griditem.Name = "griditem";
            this.griditem.OptionsView.ShowGroupPanel = false;
            // 
            // MaKhoa_Edit
            // 
            this.MaKhoa_Edit.AutoHeight = false;
            this.MaKhoa_Edit.Name = "MaKhoa_Edit";
            // 
            // TenKhoa_Edit
            // 
            this.TenKhoa_Edit.AutoHeight = false;
            this.TenKhoa_Edit.Name = "TenKhoa_Edit";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            // 
            // NoiDung
            // 
            this.NoiDung.Caption = "Nội Dung";
            this.NoiDung.FieldName = "NoiDung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 1;
            // 
            // MucDiem
            // 
            this.MucDiem.Caption = "Mức Điểm";
            this.MucDiem.FieldName = "MucDiem";
            this.MucDiem.Name = "MucDiem";
            this.MucDiem.Visible = true;
            this.MucDiem.VisibleIndex = 2;
            // 
            // SVDiem
            // 
            this.SVDiem.Caption = "Sinh Viên Đánh Giá";
            this.SVDiem.FieldName = "SVDiem";
            this.SVDiem.Name = "SVDiem";
            this.SVDiem.Visible = true;
            this.SVDiem.VisibleIndex = 3;
            // 
            // DiemThuc
            // 
            this.DiemThuc.Caption = "Điểm Thực";
            this.DiemThuc.FieldName = "DiemThuc";
            this.DiemThuc.Name = "DiemThuc";
            this.DiemThuc.Visible = true;
            this.DiemThuc.VisibleIndex = 4;
            // 
            // LTDiem
            // 
            this.LTDiem.Caption = "Điểm Lớp Trưởng";
            this.LTDiem.FieldName = "LTDiem";
            this.LTDiem.Name = "LTDiem";
            this.LTDiem.Visible = true;
            this.LTDiem.VisibleIndex = 5;
            // 
            // GVDiem
            // 
            this.GVDiem.Caption = "Điểm CVHT";
            this.GVDiem.FieldName = "GVDiem";
            this.GVDiem.Name = "GVDiem";
            this.GVDiem.Visible = true;
            this.GVDiem.VisibleIndex = 6;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 7;
            // 
            // usDanhSachDanhGiaDiemRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "usDanhSachDanhGiaDiemRenLuyen";
            this.Size = new System.Drawing.Size(952, 485);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbbHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cbbNamHoc;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView griditem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit MaKhoa_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TenKhoa_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn MucDiem;
        private DevExpress.XtraGrid.Columns.GridColumn SVDiem;
        private DevExpress.XtraGrid.Columns.GridColumn DiemThuc;
        private DevExpress.XtraGrid.Columns.GridColumn LTDiem;
        private DevExpress.XtraGrid.Columns.GridColumn GVDiem;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
    }
}
