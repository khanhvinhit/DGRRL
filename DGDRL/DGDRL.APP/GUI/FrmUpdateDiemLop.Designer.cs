namespace DGDRL.APP.GUI
{
    partial class FrmUpdateDiemLop
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.griditem;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MaKhoa_Edit,
            this.TenKhoa_Edit,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemMemoEdit3});
            this.gcDanhSach.Size = new System.Drawing.Size(1063, 457);
            this.gcDanhSach.TabIndex = 15;
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
            this.NoiDungLC.VisibleIndex = 5;
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
            this.DiemMax.VisibleIndex = 0;
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
            this.DiemSVDG.VisibleIndex = 1;
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
            this.DiemLT.VisibleIndex = 2;
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
            this.DiemCVDG.VisibleIndex = 3;
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
            this.GhiChu.VisibleIndex = 4;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gcDanhSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 457);
            this.panel1.TabIndex = 16;
            // 
            // FrmUpdateDiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 457);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1065, 489);
            this.MinimumSize = new System.Drawing.Size(1065, 489);
            this.Name = "FrmUpdateDiemLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateDiemLop";
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoa_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhoa_Edit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView griditem;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungTC;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungCT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungLC;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn DiemMax;
        private DevExpress.XtraGrid.Columns.GridColumn DiemSVDG;
        private DevExpress.XtraGrid.Columns.GridColumn DiemLT;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCVDG;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit MaKhoa_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TenKhoa_Edit;
        private System.Windows.Forms.Panel panel1;
    }
}