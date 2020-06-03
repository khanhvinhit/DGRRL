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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvNoiDungChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemCTMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDGRL = new DevExpress.XtraGrid.GridControl();
            this.gvTieuChiDanhGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTCMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gvLuaChonChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemLTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoiDungChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTieuChiDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuaChonChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvNoiDungChiTiet
            // 
            this.gvNoiDungChiTiet.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNoiDungChiTiet.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvNoiDungChiTiet.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNoiDungChiTiet.Appearance.Row.Options.UseFont = true;
            this.gvNoiDungChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCT,
            this.NoiDung,
            this.gridColumn5,
            this.DiemCTMax,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvNoiDungChiTiet.GridControl = this.gvDGRL;
            this.gvNoiDungChiTiet.Name = "gvNoiDungChiTiet";
            this.gvNoiDungChiTiet.OptionsDetail.ShowDetailTabs = false;
            this.gvNoiDungChiTiet.OptionsView.RowAutoHeight = true;
            this.gvNoiDungChiTiet.OptionsView.ShowColumnHeaders = false;
            this.gvNoiDungChiTiet.OptionsView.ShowGroupPanel = false;
            this.gvNoiDungChiTiet.OptionsView.ShowIndicator = false;
            this.gvNoiDungChiTiet.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvNoiDungChiTiet_MasterRowEmpty);
            this.gvNoiDungChiTiet.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvNoiDungChiTiet_MasterRowGetChildList);
            this.gvNoiDungChiTiet.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvNoiDungChiTiet_MasterRowGetRelationName);
            this.gvNoiDungChiTiet.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvNoiDungChiTiet_MasterRowGetRelationCount);
            // 
            // MaCT
            // 
            this.MaCT.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCT.AppearanceCell.Options.UseFont = true;
            this.MaCT.Caption = "STT";
            this.MaCT.ColumnEdit = this.repositoryItemMemoEdit4;
            this.MaCT.FieldName = "MaCT";
            this.MaCT.MaxWidth = 50;
            this.MaCT.MinWidth = 50;
            this.MaCT.Name = "MaCT";
            this.MaCT.OptionsColumn.AllowEdit = false;
            this.MaCT.OptionsColumn.AllowFocus = false;
            this.MaCT.OptionsFilter.AllowAutoFilter = false;
            this.MaCT.OptionsFilter.AllowFilter = false;
            this.MaCT.Visible = true;
            this.MaCT.VisibleIndex = 0;
            this.MaCT.Width = 50;
            // 
            // repositoryItemMemoEdit4
            // 
            this.repositoryItemMemoEdit4.Name = "repositoryItemMemoEdit4";
            // 
            // NoiDung
            // 
            this.NoiDung.AppearanceCell.Options.UseTextOptions = true;
            this.NoiDung.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NoiDung.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiDung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NoiDung.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDung.Caption = "Nội Dung";
            this.NoiDung.FieldName = "NoiDung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.OptionsColumn.AllowEdit = false;
            this.NoiDung.OptionsColumn.AllowFocus = false;
            this.NoiDung.OptionsFilter.AllowAutoFilter = false;
            this.NoiDung.OptionsFilter.AllowFilter = false;
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.MaxWidth = 90;
            this.gridColumn5.MinWidth = 90;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 90;
            // 
            // DiemCTMax
            // 
            this.DiemCTMax.Caption = "Điểm Tối Đa";
            this.DiemCTMax.FieldName = "DiemCTMax";
            this.DiemCTMax.MaxWidth = 90;
            this.DiemCTMax.MinWidth = 90;
            this.DiemCTMax.Name = "DiemCTMax";
            this.DiemCTMax.OptionsColumn.AllowEdit = false;
            this.DiemCTMax.OptionsColumn.AllowFocus = false;
            this.DiemCTMax.OptionsFilter.AllowAutoFilter = false;
            this.DiemCTMax.OptionsFilter.AllowFilter = false;
            this.DiemCTMax.Visible = true;
            this.DiemCTMax.VisibleIndex = 3;
            this.DiemCTMax.Width = 90;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.MaxWidth = 90;
            this.gridColumn6.MinWidth = 90;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 90;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "gridColumn7";
            this.gridColumn7.MaxWidth = 90;
            this.gridColumn7.MinWidth = 90;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 90;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "gridColumn8";
            this.gridColumn8.MaxWidth = 90;
            this.gridColumn8.MinWidth = 90;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn8.OptionsFilter.AllowFilter = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 90;
            // 
            // gvDGRL
            // 
            this.gvDGRL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDGRL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.gvNoiDungChiTiet;
            gridLevelNode2.LevelTemplate = this.gvLuaChonChiTiet;
            gridLevelNode2.RelationName = "LuaChonChiTiet";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "NoiDungChiTiet";
            this.gvDGRL.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gvDGRL.Location = new System.Drawing.Point(0, 0);
            this.gvDGRL.MainView = this.gvTieuChiDanhGia;
            this.gvDGRL.Name = "gvDGRL";
            this.gvDGRL.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit5,
            this.repositoryItemMemoEdit4,
            this.repositoryItemMemoEdit6});
            this.gvDGRL.Size = new System.Drawing.Size(1063, 457);
            this.gvDGRL.TabIndex = 18;
            this.gvDGRL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTieuChiDanhGia,
            this.gvLuaChonChiTiet,
            this.gvNoiDungChiTiet});
            // 
            // gvTieuChiDanhGia
            // 
            this.gvTieuChiDanhGia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTieuChiDanhGia.Appearance.Row.Options.UseFont = true;
            this.gvTieuChiDanhGia.Appearance.Row.Options.UseTextOptions = true;
            this.gvTieuChiDanhGia.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gvTieuChiDanhGia.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvTieuChiDanhGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTC,
            this.gridColumn2,
            this.gridColumn3,
            this.DiemTCMax,
            this.gridColumn4,
            this.gridColumn12,
            this.gridColumn13});
            this.gvTieuChiDanhGia.GridControl = this.gvDGRL;
            this.gvTieuChiDanhGia.Name = "gvTieuChiDanhGia";
            this.gvTieuChiDanhGia.OptionsDetail.ShowDetailTabs = false;
            this.gvTieuChiDanhGia.OptionsView.RowAutoHeight = true;
            this.gvTieuChiDanhGia.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvTieuChiDanhGia.OptionsView.ShowGroupPanel = false;
            this.gvTieuChiDanhGia.OptionsView.ShowIndicator = false;
            this.gvTieuChiDanhGia.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvTieuChiDanhGia_MasterRowEmpty);
            this.gvTieuChiDanhGia.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvTieuChiDanhGia_MasterRowGetChildList);
            this.gvTieuChiDanhGia.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvTieuChiDanhGia_MasterRowGetRelationName);
            this.gvTieuChiDanhGia.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvTieuChiDanhGia_MasterRowGetRelationCount);
            // 
            // MaTC
            // 
            this.MaTC.Caption = "STT";
            this.MaTC.ColumnEdit = this.repositoryItemMemoEdit6;
            this.MaTC.FieldName = "MaTC";
            this.MaTC.MaxWidth = 50;
            this.MaTC.MinWidth = 50;
            this.MaTC.Name = "MaTC";
            this.MaTC.OptionsColumn.AllowEdit = false;
            this.MaTC.OptionsColumn.AllowFocus = false;
            this.MaTC.OptionsFilter.AllowAutoFilter = false;
            this.MaTC.OptionsFilter.AllowFilter = false;
            this.MaTC.Visible = true;
            this.MaTC.VisibleIndex = 0;
            this.MaTC.Width = 50;
            // 
            // repositoryItemMemoEdit6
            // 
            this.repositoryItemMemoEdit6.Name = "repositoryItemMemoEdit6";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn2.Caption = "Nội Dung";
            this.gridColumn2.FieldName = "NoiDungTC";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 629;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điểm Tối Thiểu";
            this.gridColumn3.MaxWidth = 90;
            this.gridColumn3.MinWidth = 90;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 90;
            // 
            // DiemTCMax
            // 
            this.DiemTCMax.Caption = "Điểm Tối Đa";
            this.DiemTCMax.FieldName = "DiemTCMax";
            this.DiemTCMax.MaxWidth = 90;
            this.DiemTCMax.MinWidth = 90;
            this.DiemTCMax.Name = "DiemTCMax";
            this.DiemTCMax.OptionsColumn.AllowEdit = false;
            this.DiemTCMax.OptionsColumn.AllowFocus = false;
            this.DiemTCMax.OptionsFilter.AllowAutoFilter = false;
            this.DiemTCMax.OptionsFilter.AllowFilter = false;
            this.DiemTCMax.Visible = true;
            this.DiemTCMax.VisibleIndex = 3;
            this.DiemTCMax.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điểm Sinh Viên";
            this.gridColumn4.MaxWidth = 90;
            this.gridColumn4.MinWidth = 90;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 90;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Điểm Lớp Trưởng";
            this.gridColumn12.MaxWidth = 90;
            this.gridColumn12.MinWidth = 90;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn12.OptionsFilter.AllowFilter = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            this.gridColumn12.Width = 90;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Điểm Giáo Viên";
            this.gridColumn13.MaxWidth = 90;
            this.gridColumn13.MinWidth = 90;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.AllowFocus = false;
            this.gridColumn13.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn13.OptionsFilter.AllowFilter = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            this.gridColumn13.Width = 90;
            // 
            // repositoryItemMemoEdit5
            // 
            this.repositoryItemMemoEdit5.Name = "repositoryItemMemoEdit5";
            // 
            // gvLuaChonChiTiet
            // 
            this.gvLuaChonChiTiet.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLuaChonChiTiet.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvLuaChonChiTiet.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLuaChonChiTiet.Appearance.Row.Options.UseFont = true;
            this.gvLuaChonChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLC,
            this.MoTa,
            this.DiemTT,
            this.DiemTD,
            this.DiemSV,
            this.DiemLTT,
            this.DiemGV});
            this.gvLuaChonChiTiet.GridControl = this.gvDGRL;
            this.gvLuaChonChiTiet.Name = "gvLuaChonChiTiet";
            this.gvLuaChonChiTiet.OptionsDetail.ShowDetailTabs = false;
            this.gvLuaChonChiTiet.OptionsView.RowAutoHeight = true;
            this.gvLuaChonChiTiet.OptionsView.ShowColumnHeaders = false;
            this.gvLuaChonChiTiet.OptionsView.ShowGroupPanel = false;
            this.gvLuaChonChiTiet.OptionsView.ShowIndicator = false;
            // 
            // MaLC
            // 
            this.MaLC.Caption = "STT";
            this.MaLC.FieldName = "MaLC";
            this.MaLC.MaxWidth = 50;
            this.MaLC.MinWidth = 50;
            this.MaLC.Name = "MaLC";
            this.MaLC.OptionsColumn.AllowEdit = false;
            this.MaLC.OptionsColumn.AllowFocus = false;
            this.MaLC.OptionsFilter.AllowAutoFilter = false;
            this.MaLC.OptionsFilter.AllowFilter = false;
            this.MaLC.Visible = true;
            this.MaLC.VisibleIndex = 0;
            this.MaLC.Width = 50;
            // 
            // MoTa
            // 
            this.MoTa.Caption = "Nội Dung";
            this.MoTa.ColumnEdit = this.repositoryItemMemoEdit5;
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.OptionsColumn.AllowEdit = false;
            this.MoTa.OptionsColumn.AllowFocus = false;
            this.MoTa.OptionsFilter.AllowAutoFilter = false;
            this.MoTa.OptionsFilter.AllowFilter = false;
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 1;
            // 
            // DiemTT
            // 
            this.DiemTT.Caption = "Điểm Tối Thiểu";
            this.DiemTT.FieldName = "DiemTT";
            this.DiemTT.MaxWidth = 90;
            this.DiemTT.MinWidth = 90;
            this.DiemTT.Name = "DiemTT";
            this.DiemTT.OptionsColumn.AllowEdit = false;
            this.DiemTT.OptionsColumn.AllowFocus = false;
            this.DiemTT.OptionsFilter.AllowAutoFilter = false;
            this.DiemTT.OptionsFilter.AllowFilter = false;
            this.DiemTT.Visible = true;
            this.DiemTT.VisibleIndex = 2;
            this.DiemTT.Width = 90;
            // 
            // DiemTD
            // 
            this.DiemTD.Caption = "Điểm Tối Đa";
            this.DiemTD.FieldName = "DiemTD";
            this.DiemTD.MaxWidth = 90;
            this.DiemTD.MinWidth = 90;
            this.DiemTD.Name = "DiemTD";
            this.DiemTD.OptionsColumn.AllowEdit = false;
            this.DiemTD.OptionsColumn.AllowFocus = false;
            this.DiemTD.OptionsFilter.AllowAutoFilter = false;
            this.DiemTD.OptionsFilter.AllowFilter = false;
            this.DiemTD.Visible = true;
            this.DiemTD.VisibleIndex = 3;
            this.DiemTD.Width = 90;
            // 
            // DiemSV
            // 
            this.DiemSV.Caption = "Điểm SV";
            this.DiemSV.FieldName = "DiemSV";
            this.DiemSV.MaxWidth = 90;
            this.DiemSV.MinWidth = 90;
            this.DiemSV.Name = "DiemSV";
            this.DiemSV.OptionsColumn.AllowEdit = false;
            this.DiemSV.OptionsColumn.AllowFocus = false;
            this.DiemSV.OptionsFilter.AllowAutoFilter = false;
            this.DiemSV.OptionsFilter.AllowFilter = false;
            this.DiemSV.Visible = true;
            this.DiemSV.VisibleIndex = 4;
            this.DiemSV.Width = 90;
            // 
            // DiemLTT
            // 
            this.DiemLTT.Caption = "Điểm LT";
            this.DiemLTT.FieldName = "DiemLTT";
            this.DiemLTT.MaxWidth = 90;
            this.DiemLTT.MinWidth = 90;
            this.DiemLTT.Name = "DiemLTT";
            this.DiemLTT.OptionsFilter.AllowAutoFilter = false;
            this.DiemLTT.OptionsFilter.AllowFilter = false;
            this.DiemLTT.Visible = true;
            this.DiemLTT.VisibleIndex = 5;
            this.DiemLTT.Width = 90;
            // 
            // DiemGV
            // 
            this.DiemGV.Caption = "Điểm GV";
            this.DiemGV.FieldName = "DiemGV";
            this.DiemGV.MaxWidth = 90;
            this.DiemGV.MinWidth = 90;
            this.DiemGV.Name = "DiemGV";
            this.DiemGV.OptionsFilter.AllowAutoFilter = false;
            this.DiemGV.OptionsFilter.AllowFilter = false;
            this.DiemGV.Visible = true;
            this.DiemGV.VisibleIndex = 6;
            this.DiemGV.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvDGRL);
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
            ((System.ComponentModel.ISupportInitialize)(this.gvNoiDungChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTieuChiDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuaChonChiTiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gvDGRL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNoiDungChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn MaCT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCTMax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLuaChonChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn MaLC;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn DiemTT;
        private DevExpress.XtraGrid.Columns.GridColumn DiemTD;
        private DevExpress.XtraGrid.Columns.GridColumn DiemSV;
        private DevExpress.XtraGrid.Columns.GridColumn DiemLTT;
        private DevExpress.XtraGrid.Columns.GridColumn DiemGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTieuChiDanhGia;
        private DevExpress.XtraGrid.Columns.GridColumn MaTC;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn DiemTCMax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}