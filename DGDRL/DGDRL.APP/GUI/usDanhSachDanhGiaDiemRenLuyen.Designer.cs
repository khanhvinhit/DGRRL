﻿namespace DGDRL.APP.GUI
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvNoiDungChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCTView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
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
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTCMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gvLuaChonChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLCView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemLTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbbNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoiDungChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTieuChiDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuaChonChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvNoiDungChiTiet
            // 
            this.gvNoiDungChiTiet.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNoiDungChiTiet.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvNoiDungChiTiet.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNoiDungChiTiet.Appearance.Row.Options.UseFont = true;
            this.gvNoiDungChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCTView,
            this.NoiDung,
            this.gridColumn5,
            this.DiemCTMax,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvNoiDungChiTiet.GridControl = this.gvDGRL;
            this.gvNoiDungChiTiet.Name = "gvNoiDungChiTiet";
            this.gvNoiDungChiTiet.OptionsBehavior.AutoExpandAllGroups = true;
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
            // MaCTView
            // 
            this.MaCTView.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCTView.AppearanceCell.Options.UseFont = true;
            this.MaCTView.Caption = "STT";
            this.MaCTView.ColumnEdit = this.repositoryItemMemoEdit4;
            this.MaCTView.FieldName = "MaCTView";
            this.MaCTView.MaxWidth = 50;
            this.MaCTView.MinWidth = 50;
            this.MaCTView.Name = "MaCTView";
            this.MaCTView.OptionsColumn.AllowEdit = false;
            this.MaCTView.OptionsColumn.AllowFocus = false;
            this.MaCTView.OptionsFilter.AllowAutoFilter = false;
            this.MaCTView.OptionsFilter.AllowFilter = false;
            this.MaCTView.Visible = true;
            this.MaCTView.VisibleIndex = 0;
            this.MaCTView.Width = 50;
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
            this.NoiDung.ColumnEdit = this.repositoryItemMemoEdit1;
            this.NoiDung.FieldName = "NoiDung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.OptionsColumn.AllowEdit = false;
            this.NoiDung.OptionsColumn.AllowFocus = false;
            this.NoiDung.OptionsFilter.AllowAutoFilter = false;
            this.NoiDung.OptionsFilter.AllowFilter = false;
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 1;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
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
            this.gvDGRL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDGRL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.gvNoiDungChiTiet;
            gridLevelNode2.LevelTemplate = this.gvLuaChonChiTiet;
            gridLevelNode2.RelationName = "LuaChonChiTiet";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "NoiDungChiTiet";
            this.gvDGRL.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gvDGRL.Location = new System.Drawing.Point(5, 50);
            this.gvDGRL.MainView = this.gvTieuChiDanhGia;
            this.gvDGRL.Name = "gvDGRL";
            this.gvDGRL.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit5,
            this.repositoryItemMemoEdit4,
            this.repositoryItemMemoEdit6,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.gvDGRL.Size = new System.Drawing.Size(942, 430);
            this.gvDGRL.TabIndex = 19;
            this.gvDGRL.UseEmbeddedNavigator = true;
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
            this.gvTieuChiDanhGia.OptionsBehavior.AutoExpandAllGroups = true;
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
            this.gridColumn2.ColumnEdit = this.repositoryItemMemoEdit2;
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
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
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
            this.MaLCView,
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
            this.gvLuaChonChiTiet.DoubleClick += new System.EventHandler(this.gvLuaChonChiTiet_DoubleClick);
            // 
            // MaLCView
            // 
            this.MaLCView.Caption = "STT";
            this.MaLCView.FieldName = "MaLCView";
            this.MaLCView.MaxWidth = 50;
            this.MaLCView.MinWidth = 50;
            this.MaLCView.Name = "MaLCView";
            this.MaLCView.OptionsColumn.AllowEdit = false;
            this.MaLCView.OptionsColumn.AllowFocus = false;
            this.MaLCView.OptionsFilter.AllowAutoFilter = false;
            this.MaLCView.OptionsFilter.AllowFilter = false;
            this.MaLCView.Visible = true;
            this.MaLCView.VisibleIndex = 0;
            this.MaLCView.Width = 50;
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
            this.DiemSV.ToolTip = "Nhấn 2 lần để cập nhật điểm";
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
            this.DiemLTT.OptionsColumn.AllowEdit = false;
            this.DiemLTT.OptionsColumn.AllowFocus = false;
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
            this.DiemGV.OptionsColumn.AllowEdit = false;
            this.DiemGV.OptionsColumn.AllowFocus = false;
            this.DiemGV.OptionsFilter.AllowAutoFilter = false;
            this.DiemGV.OptionsFilter.AllowFilter = false;
            this.DiemGV.Visible = true;
            this.DiemGV.VisibleIndex = 6;
            this.DiemGV.Width = 90;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gvDGRL);
            this.panelControl1.Controls.Add(this.btnTimKiem);
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
            ((System.ComponentModel.ISupportInitialize)(this.gvNoiDungChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTieuChiDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuaChonChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.GridControl gvDGRL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNoiDungChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn MaCTView;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCTMax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLuaChonChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn MaLCView;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
    }
}
