namespace DGDRL.APP.GUI
{
    partial class usDiemLop
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.cbbNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.TenKhoa_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MaKhoa_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.griditem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemSVDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemCVHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnChuyenDiemSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyenDiemLT = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyenDiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
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
            // TenKhoa_Edit
            // 
            this.TenKhoa_Edit.AutoHeight = false;
            this.TenKhoa_Edit.Name = "TenKhoa_Edit";
            // 
            // MaKhoa_Edit
            // 
            this.MaKhoa_Edit.AutoHeight = false;
            this.MaKhoa_Edit.Name = "MaKhoa_Edit";
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 7;
            this.GhiChu.Width = 50;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Năm Học";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.OptionsColumn.AllowFocus = false;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 50;
            // 
            // griditem
            // 
            this.griditem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.NgaySinh,
            this.DiemSVDG,
            this.DiemLT,
            this.DiemCVHT,
            this.GhiChu});
            this.griditem.GridControl = this.gcDanhSach;
            this.griditem.Name = "griditem";
            this.griditem.OptionsView.ShowGroupPanel = false;
            // 
            // MSSV
            // 
            this.MSSV.Caption = "MSSV";
            this.MSSV.FieldName = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.OptionsColumn.AllowEdit = false;
            this.MSSV.OptionsColumn.AllowFocus = false;
            this.MSSV.Visible = true;
            this.MSSV.VisibleIndex = 1;
            this.MSSV.Width = 101;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowEdit = false;
            this.HoTen.OptionsColumn.AllowFocus = false;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 101;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.OptionsColumn.AllowEdit = false;
            this.NgaySinh.OptionsColumn.AllowFocus = false;
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            this.NgaySinh.Width = 101;
            // 
            // DiemSVDG
            // 
            this.DiemSVDG.Caption = "Điểm Sinh Viên";
            this.DiemSVDG.FieldName = "DiemSVDG";
            this.DiemSVDG.Name = "DiemSVDG";
            this.DiemSVDG.OptionsColumn.AllowEdit = false;
            this.DiemSVDG.OptionsColumn.AllowFocus = false;
            this.DiemSVDG.Visible = true;
            this.DiemSVDG.VisibleIndex = 4;
            this.DiemSVDG.Width = 101;
            // 
            // DiemLT
            // 
            this.DiemLT.Caption = "Điểm Lớp Trưởng";
            this.DiemLT.FieldName = "DiemLT";
            this.DiemLT.Name = "DiemLT";
            this.DiemLT.OptionsColumn.AllowEdit = false;
            this.DiemLT.OptionsColumn.AllowFocus = false;
            this.DiemLT.Visible = true;
            this.DiemLT.VisibleIndex = 5;
            this.DiemLT.Width = 101;
            // 
            // DiemCVHT
            // 
            this.DiemCVHT.Caption = "Điểm Giáo Viên";
            this.DiemCVHT.FieldName = "DiemCVHT";
            this.DiemCVHT.Name = "DiemCVHT";
            this.DiemCVHT.OptionsColumn.AllowEdit = false;
            this.DiemCVHT.OptionsColumn.AllowFocus = false;
            this.DiemCVHT.Visible = true;
            this.DiemCVHT.VisibleIndex = 6;
            this.DiemCVHT.Width = 101;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSach.Location = new System.Drawing.Point(5, 81);
            this.gcDanhSach.MainView = this.griditem;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MaKhoa_Edit,
            this.TenKhoa_Edit});
            this.gcDanhSach.Size = new System.Drawing.Size(786, 399);
            this.gcDanhSach.TabIndex = 14;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griditem});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnChuyenDiemSV);
            this.panelControl1.Controls.Add(this.btnLoad);
            this.panelControl1.Controls.Add(this.btnChuyenDiemLT);
            this.panelControl1.Controls.Add(this.btnChuyenDiem);
            this.panelControl1.Controls.Add(this.gcDanhSach);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbbHocKy);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.cbbNamHoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(796, 485);
            this.panelControl1.TabIndex = 1;
            // 
            // btnChuyenDiemSV
            // 
            this.btnChuyenDiemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDiemSV.Location = new System.Drawing.Point(482, 52);
            this.btnChuyenDiemSV.Name = "btnChuyenDiemSV";
            this.btnChuyenDiemSV.Size = new System.Drawing.Size(147, 23);
            this.btnChuyenDiemSV.TabIndex = 16;
            this.btnChuyenDiemSV.Text = "Chuyển Điểm Của Sinh Vien";
            this.btnChuyenDiemSV.Click += new System.EventHandler(this.btnChuyenDiemSV_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(716, 52);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Làm Mới";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnChuyenDiemLT
            // 
            this.btnChuyenDiemLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDiemLT.Location = new System.Drawing.Point(315, 52);
            this.btnChuyenDiemLT.Name = "btnChuyenDiemLT";
            this.btnChuyenDiemLT.Size = new System.Drawing.Size(161, 23);
            this.btnChuyenDiemLT.TabIndex = 15;
            this.btnChuyenDiemLT.Text = "Chuyển Điểm Lớp Trưởng";
            this.btnChuyenDiemLT.Click += new System.EventHandler(this.btnChuyenDiemLT_Click);
            // 
            // btnChuyenDiem
            // 
            this.btnChuyenDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDiem.Location = new System.Drawing.Point(635, 52);
            this.btnChuyenDiem.Name = "btnChuyenDiem";
            this.btnChuyenDiem.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenDiem.TabIndex = 15;
            this.btnChuyenDiem.Text = "Chuyển Điểm";
            this.btnChuyenDiem.Click += new System.EventHandler(this.btnChuyenDiem_Click);
            // 
            // usDiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "usDiemLop";
            this.Size = new System.Drawing.Size(796, 485);
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbbHocKy;
        private DevExpress.XtraEditors.LookUpEdit cbbNamHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TenKhoa_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit MaKhoa_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView griditem;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChuyenDiemSV;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnChuyenDiemLT;
        private DevExpress.XtraEditors.SimpleButton btnChuyenDiem;
        private DevExpress.XtraGrid.Columns.GridColumn MSSV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiemSVDG;
        private DevExpress.XtraGrid.Columns.GridColumn DiemLT;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCVHT;
    }
}
