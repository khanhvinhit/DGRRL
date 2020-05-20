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
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.griditem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoiDungTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.NoiDungCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.NoiDungLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.DiemMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemSVDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemCVDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKhoa_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TenKhoa_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbbNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTimKiem);
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
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(625, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 24);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Xem";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.TenKhoa_Edit,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemMemoEdit3});
            this.gcDanhSach.Size = new System.Drawing.Size(942, 430);
            this.gcDanhSach.TabIndex = 14;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griditem});
            // 
            // griditem
            // 
            this.griditem.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.griditem.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.griditem.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.griditem.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.griditem.Appearance.GroupRow.Options.UseFont = true;
            this.griditem.Appearance.GroupRow.Options.UseTextOptions = true;
            this.griditem.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.griditem.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.griditem.Appearance.OddRow.Options.UseTextOptions = true;
            this.griditem.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.griditem.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.griditem.Appearance.Row.Options.UseFont = true;
            this.griditem.Appearance.Row.Options.UseTextOptions = true;
            this.griditem.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.griditem.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.griditem.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.griditem.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.griditem.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.griditem.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.griditem.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.griditem.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.griditem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NoiDungTC,
            this.NoiDungCT,
            this.NoiDungLC,
            this.DiemMax,
            this.DiemSVDG,
            this.DiemLT,
            this.DiemCVDG,
            this.GhiChu});
            this.griditem.GridControl = this.gcDanhSach;
            this.griditem.GroupCount = 2;
            this.griditem.Name = "griditem";
            this.griditem.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.griditem.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.griditem.OptionsBehavior.AutoExpandAllGroups = true;
            this.griditem.OptionsCustomization.AllowGroup = false;
            this.griditem.OptionsPrint.PrintFooter = false;
            this.griditem.OptionsPrint.PrintGroupFooter = false;
            this.griditem.OptionsPrint.UsePrintStyles = false;
            this.griditem.OptionsView.AllowHtmlDrawGroups = false;
            this.griditem.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.griditem.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.griditem.OptionsView.RowAutoHeight = true;
            this.griditem.OptionsView.ShowGroupedColumns = true;
            this.griditem.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.griditem.OptionsView.ShowGroupPanel = false;
            this.griditem.OptionsView.ShowIndicator = false;
            this.griditem.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NoiDungTC, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NoiDungCT, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // NoiDungTC
            // 
            this.NoiDungTC.AppearanceCell.Options.UseTextOptions = true;
            this.NoiDungTC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungTC.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiDungTC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungTC.Caption = "Nội Dung";
            this.NoiDungTC.ColumnEdit = this.repositoryItemMemoEdit1;
            this.NoiDungTC.FieldName = "NoiDungTC";
            this.NoiDungTC.MaxWidth = 500;
            this.NoiDungTC.Name = "NoiDungTC";
            this.NoiDungTC.OptionsColumn.AllowEdit = false;
            this.NoiDungTC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NoiDungTC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.NoiDungTC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NoiDungTC.OptionsColumn.FixedWidth = true;
            this.NoiDungTC.OptionsColumn.ReadOnly = true;
            this.NoiDungTC.OptionsColumn.ShowCaption = false;
            this.NoiDungTC.OptionsFilter.AllowAutoFilter = false;
            this.NoiDungTC.OptionsFilter.AllowFilter = false;
            this.NoiDungTC.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            // 
            // NoiDungCT
            // 
            this.NoiDungCT.AppearanceCell.Options.UseTextOptions = true;
            this.NoiDungCT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungCT.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiDungCT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungCT.Caption = "Nội Dung";
            this.NoiDungCT.ColumnEdit = this.repositoryItemMemoEdit2;
            this.NoiDungCT.FieldName = "NoiDungCT";
            this.NoiDungCT.Name = "NoiDungCT";
            this.NoiDungCT.OptionsColumn.AllowEdit = false;
            this.NoiDungCT.OptionsColumn.AllowFocus = false;
            this.NoiDungCT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.NoiDungCT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NoiDungCT.OptionsColumn.FixedWidth = true;
            this.NoiDungCT.OptionsColumn.ReadOnly = true;
            this.NoiDungCT.OptionsColumn.ShowCaption = false;
            this.NoiDungCT.OptionsFilter.AllowAutoFilter = false;
            this.NoiDungCT.OptionsFilter.AllowFilter = false;
            this.NoiDungCT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit2.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit2.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // NoiDungLC
            // 
            this.NoiDungLC.AppearanceCell.Options.UseTextOptions = true;
            this.NoiDungLC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungLC.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiDungLC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungLC.Caption = "Nội Dung";
            this.NoiDungLC.ColumnEdit = this.repositoryItemMemoEdit3;
            this.NoiDungLC.FieldName = "NoiDungLC";
            this.NoiDungLC.Name = "NoiDungLC";
            this.NoiDungLC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NoiDungLC.OptionsFilter.AllowAutoFilter = false;
            this.NoiDungLC.OptionsFilter.AllowFilter = false;
            this.NoiDungLC.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.NoiDungLC.Visible = true;
            this.NoiDungLC.VisibleIndex = 0;
            this.NoiDungLC.Width = 500;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // DiemMax
            // 
            this.DiemMax.Caption = "Mức Điểm";
            this.DiemMax.FieldName = "DiemMax";
            this.DiemMax.Name = "DiemMax";
            this.DiemMax.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DiemMax.OptionsFilter.AllowAutoFilter = false;
            this.DiemMax.OptionsFilter.AllowFilter = false;
            this.DiemMax.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.DiemMax.Visible = true;
            this.DiemMax.VisibleIndex = 3;
            this.DiemMax.Width = 83;
            // 
            // DiemSVDG
            // 
            this.DiemSVDG.Caption = "Sinh Viên Đánh Giá";
            this.DiemSVDG.FieldName = "DiemSVDG";
            this.DiemSVDG.Name = "DiemSVDG";
            this.DiemSVDG.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DiemSVDG.OptionsFilter.AllowAutoFilter = false;
            this.DiemSVDG.OptionsFilter.AllowFilter = false;
            this.DiemSVDG.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.DiemSVDG.Visible = true;
            this.DiemSVDG.VisibleIndex = 4;
            this.DiemSVDG.Width = 83;
            // 
            // DiemLT
            // 
            this.DiemLT.Caption = "Điểm Lớp Trưởng";
            this.DiemLT.FieldName = "DiemLT";
            this.DiemLT.Name = "DiemLT";
            this.DiemLT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DiemLT.OptionsFilter.AllowAutoFilter = false;
            this.DiemLT.OptionsFilter.AllowFilter = false;
            this.DiemLT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.DiemLT.Visible = true;
            this.DiemLT.VisibleIndex = 5;
            this.DiemLT.Width = 83;
            // 
            // DiemCVDG
            // 
            this.DiemCVDG.Caption = "Điểm CVHT";
            this.DiemCVDG.FieldName = "DiemCVDG";
            this.DiemCVDG.Name = "DiemCVDG";
            this.DiemCVDG.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DiemCVDG.OptionsFilter.AllowAutoFilter = false;
            this.DiemCVDG.OptionsFilter.AllowFilter = false;
            this.DiemCVDG.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.DiemCVDG.Visible = true;
            this.DiemCVDG.VisibleIndex = 6;
            this.DiemCVDG.Width = 83;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsFilter.AllowAutoFilter = false;
            this.GhiChu.OptionsFilter.AllowFilter = false;
            this.GhiChu.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 7;
            this.GhiChu.Width = 89;
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
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungLC;
        private DevExpress.XtraGrid.Columns.GridColumn DiemMax;
        private DevExpress.XtraGrid.Columns.GridColumn DiemSVDG;
        private DevExpress.XtraGrid.Columns.GridColumn DiemLT;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCVDG;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungTC;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungCT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
    }
}
