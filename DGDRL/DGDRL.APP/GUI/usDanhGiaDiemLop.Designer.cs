namespace DGDRL.APP.GUI
{
    partial class usDanhGiaDiemLop
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
            this.MaCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemCTMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDGRL = new DevExpress.XtraGrid.GridControl();
            this.gvTieuChiDanhGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.NoiDungTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTCMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gvLuaChonChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbbHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.cbbNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoiDungChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTieuChiDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuaChonChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.MaCT.ColumnEdit = this.repositoryItemMemoEdit2;
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
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
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
            this.gvDGRL.Location = new System.Drawing.Point(5, 81);
            this.gvDGRL.MainView = this.gvTieuChiDanhGia;
            this.gvDGRL.Name = "gvDGRL";
            this.gvDGRL.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemMemoEdit3});
            this.gvDGRL.Size = new System.Drawing.Size(771, 283);
            this.gvDGRL.TabIndex = 17;
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
            this.NoiDungTC,
            this.gridColumn1,
            this.DiemTCMax,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
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
            this.MaTC.ColumnEdit = this.repositoryItemMemoEdit3;
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
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // NoiDungTC
            // 
            this.NoiDungTC.AppearanceCell.Options.UseTextOptions = true;
            this.NoiDungTC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NoiDungTC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungTC.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiDungTC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NoiDungTC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoiDungTC.Caption = "Nội Dung";
            this.NoiDungTC.FieldName = "NoiDungTC";
            this.NoiDungTC.Name = "NoiDungTC";
            this.NoiDungTC.OptionsColumn.AllowEdit = false;
            this.NoiDungTC.OptionsColumn.AllowFocus = false;
            this.NoiDungTC.OptionsFilter.AllowAutoFilter = false;
            this.NoiDungTC.OptionsFilter.AllowFilter = false;
            this.NoiDungTC.Visible = true;
            this.NoiDungTC.VisibleIndex = 1;
            this.NoiDungTC.Width = 629;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Điểm Tối Thiểu";
            this.gridColumn1.MaxWidth = 90;
            this.gridColumn1.MinWidth = 90;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 90;
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Điểm Sinh Viên";
            this.gridColumn2.MaxWidth = 90;
            this.gridColumn2.MinWidth = 90;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điểm Lớp Trưởng";
            this.gridColumn3.MaxWidth = 90;
            this.gridColumn3.MinWidth = 90;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điểm Giáo Viên";
            this.gridColumn4.MaxWidth = 90;
            this.gridColumn4.MinWidth = 90;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 90;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
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
            this.DiemMin,
            this.DiemMax,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
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
            this.MoTa.ColumnEdit = this.repositoryItemMemoEdit1;
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.OptionsColumn.AllowEdit = false;
            this.MoTa.OptionsColumn.AllowFocus = false;
            this.MoTa.OptionsFilter.AllowAutoFilter = false;
            this.MoTa.OptionsFilter.AllowFilter = false;
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 1;
            // 
            // DiemMin
            // 
            this.DiemMin.Caption = "Điểm Tối Thiểu";
            this.DiemMin.FieldName = "DiemMin";
            this.DiemMin.MaxWidth = 90;
            this.DiemMin.MinWidth = 90;
            this.DiemMin.Name = "DiemMin";
            this.DiemMin.OptionsColumn.AllowEdit = false;
            this.DiemMin.OptionsColumn.AllowFocus = false;
            this.DiemMin.OptionsFilter.AllowAutoFilter = false;
            this.DiemMin.OptionsFilter.AllowFilter = false;
            this.DiemMin.Visible = true;
            this.DiemMin.VisibleIndex = 2;
            this.DiemMin.Width = 90;
            // 
            // DiemMax
            // 
            this.DiemMax.Caption = "Điểm Tối Đa";
            this.DiemMax.FieldName = "DiemMax";
            this.DiemMax.MaxWidth = 90;
            this.DiemMax.MinWidth = 90;
            this.DiemMax.Name = "DiemMax";
            this.DiemMax.OptionsColumn.AllowEdit = false;
            this.DiemMax.OptionsColumn.AllowFocus = false;
            this.DiemMax.OptionsFilter.AllowAutoFilter = false;
            this.DiemMax.OptionsFilter.AllowFilter = false;
            this.DiemMax.Visible = true;
            this.DiemMax.VisibleIndex = 3;
            this.DiemMax.Width = 90;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "gridColumn9";
            this.gridColumn9.MaxWidth = 90;
            this.gridColumn9.MinWidth = 90;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn9.OptionsFilter.AllowFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 90;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "gridColumn10";
            this.gridColumn10.MaxWidth = 90;
            this.gridColumn10.MinWidth = 90;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 90;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "gridColumn11";
            this.gridColumn11.MaxWidth = 90;
            this.gridColumn11.MinWidth = 90;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn11.OptionsFilter.AllowFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            this.gridColumn11.Width = 90;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Location = new System.Drawing.Point(467, 52);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(147, 23);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Chuyển Điểm Của Sinh Vien";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(701, 52);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Làm Mới";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(620, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Chuyển Điểm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(315, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Học Kỳ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(300, 52);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(161, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Chuyển Điểm Lớp Trưởng";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Năm Học";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gvDGRL);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.btnLoad);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbbHocKy);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.cbbNamHoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(781, 369);
            this.panelControl1.TabIndex = 2;
            // 
            // usDanhGiaDiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "usDanhGiaDiemLop";
            this.Size = new System.Drawing.Size(781, 369);
            ((System.ComponentModel.ISupportInitialize)(this.gvNoiDungChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTieuChiDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuaChonChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cbbHocKy;
        private DevExpress.XtraEditors.LookUpEdit cbbNamHoc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gvDGRL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNoiDungChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTieuChiDanhGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLuaChonChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn MaCT;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCTMax;
        private DevExpress.XtraGrid.Columns.GridColumn MaTC;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungTC;
        private DevExpress.XtraGrid.Columns.GridColumn DiemTCMax;
        private DevExpress.XtraGrid.Columns.GridColumn MaLC;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraGrid.Columns.GridColumn DiemMin;
        private DevExpress.XtraGrid.Columns.GridColumn DiemMax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
    }
}
