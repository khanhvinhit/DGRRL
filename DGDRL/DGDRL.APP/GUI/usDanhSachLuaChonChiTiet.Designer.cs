namespace DGDRL.APP.GUI
{
    partial class usDanhSachLuaChonChiTiet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usDanhSachLuaChonChiTiet));
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.griditem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Button = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbDanhSachTC = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDanhSachTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSach.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcDanhSach.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcDanhSach.Location = new System.Drawing.Point(7, 99);
            this.gcDanhSach.MainView = this.griditem;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(923, 425);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griditem});
            // 
            // griditem
            // 
            this.griditem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLC,
            this.MaCT,
            this.MoTa,
            this.DiemMin,
            this.DiemMax,
            this.Button});
            this.griditem.GridControl = this.gcDanhSach;
            this.griditem.Name = "griditem";
            this.griditem.OptionsBehavior.ReadOnly = true;
            this.griditem.OptionsView.ShowGroupPanel = false;
            this.griditem.DoubleClick += new System.EventHandler(this.griditem_DoubleClick);
            // 
            // MaLC
            // 
            this.MaLC.Caption = "Mã Lựa Chọn";
            this.MaLC.FieldName = "MaLC";
            this.MaLC.Name = "MaLC";
            this.MaLC.OptionsColumn.AllowEdit = false;
            this.MaLC.OptionsColumn.AllowFocus = false;
            this.MaLC.OptionsColumn.ReadOnly = true;
            this.MaLC.Visible = true;
            this.MaLC.VisibleIndex = 0;
            // 
            // MaCT
            // 
            this.MaCT.Caption = "Mã Chi Tiết";
            this.MaCT.FieldName = "MaCT";
            this.MaCT.Name = "MaCT";
            this.MaCT.OptionsColumn.AllowEdit = false;
            this.MaCT.OptionsColumn.AllowFocus = false;
            this.MaCT.Visible = true;
            this.MaCT.VisibleIndex = 1;
            // 
            // MoTa
            // 
            this.MoTa.Caption = "Mô Tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.OptionsColumn.AllowEdit = false;
            this.MoTa.OptionsColumn.AllowFocus = false;
            this.MoTa.OptionsColumn.ReadOnly = true;
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 2;
            // 
            // DiemMin
            // 
            this.DiemMin.Caption = "Điểm Tối Thiểu";
            this.DiemMin.FieldName = "DiemMin";
            this.DiemMin.Name = "DiemMin";
            this.DiemMin.OptionsColumn.AllowEdit = false;
            this.DiemMin.OptionsColumn.AllowFocus = false;
            this.DiemMin.OptionsColumn.ReadOnly = true;
            this.DiemMin.Visible = true;
            this.DiemMin.VisibleIndex = 3;
            // 
            // DiemMax
            // 
            this.DiemMax.Caption = "Điểm Tối Đa";
            this.DiemMax.FieldName = "DiemMax";
            this.DiemMax.Name = "DiemMax";
            this.DiemMax.OptionsColumn.AllowEdit = false;
            this.DiemMax.OptionsColumn.AllowFocus = false;
            this.DiemMax.Visible = true;
            this.DiemMax.VisibleIndex = 4;
            // 
            // Button
            // 
            this.Button.FieldName = "Button";
            this.Button.MaxWidth = 50;
            this.Button.Name = "Button";
            this.Button.Visible = true;
            this.Button.VisibleIndex = 5;
            this.Button.Width = 50;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.gcDanhSach);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(935, 529);
            this.panelControl1.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cbbDanhSachTC);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSearch);
            this.groupControl1.Controls.Add(this.btnAddNew);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Location = new System.Drawing.Point(7, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(923, 74);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // cbbDanhSachTC
            // 
            this.cbbDanhSachTC.Location = new System.Drawing.Point(5, 43);
            this.cbbDanhSachTC.Name = "cbbDanhSachTC";
            this.cbbDanhSachTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDanhSachTC.Size = new System.Drawing.Size(205, 20);
            this.cbbDanhSachTC.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Nội dung chi tiết";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(217, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(217, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(845, 43);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 21);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(428, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "cancel_16x16.png");
            // 
            // usDanhSachLuaChonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "usDanhSachLuaChonChiTiet";
            this.Size = new System.Drawing.Size(935, 529);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDanhSachTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView griditem;
        private DevExpress.XtraGrid.Columns.GridColumn MaLC;
        private DevExpress.XtraGrid.Columns.GridColumn MaCT;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraGrid.Columns.GridColumn DiemMin;
        private DevExpress.XtraGrid.Columns.GridColumn Button;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbbDanhSachTC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn DiemMax;
    }
}
