using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DGDRL.APP.DAO;
using DGDRL.Model.DTO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachLuaChonChiTiet : UserControl
    {
        public usDanhSachLuaChonChiTiet()
        {
            InitializeComponent();
            LoadDanhSachTC();
            LoadDanhSachLCCT();
            AddRepository();
        }
        public void LoadDanhSachTC()
        {
            var dao = new NoiDungChiTietDAO();
            var lst = dao.GetAll();
            cbbDanhSachTC.Properties.DataSource = lst;
            cbbDanhSachTC.Properties.ValueMember = "MaCT";
            cbbDanhSachTC.Properties.DisplayMember = "NoiDung";
        }
        public void LoadDanhSachLCCT()
        {
            gcDanhSach.DataSource = null;
            gcDanhSach.Controls.Clear();
            var dao = new LuaChonChiTietDAO();
            var lst = new List<LuaChonChiTiet>();
            var ids = string.Join(",", cbbDanhSachTC.Properties.Items.GetCheckedValues());
            var ser = txtSearch.Text;
            if (string.IsNullOrEmpty(ids))
            {
                lst = dao.GetAll(ser);
            }
            else
            {
                lst = dao.GetAllByMaKhoa(ids, ser);
            }

            gcDanhSach.DataSource = lst;
        }
        private void AddRepository()
        {
            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = TextEditStyles.HideTextEditor;
            edit.ButtonClick += edit_ButtonClick;
            edit.Buttons[0].Caption = "Xóa";
            edit.Buttons[0].Image = imageCollection1.Images[0];
            edit.Buttons[0].Kind = ButtonPredefines.Glyph;
            griditem.Columns["Button"].ColumnEdit = edit;
        }

        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var item = griditem.GetRow(griditem.FocusedRowHandle) as LuaChonChiTiet;
                var dao = new LuaChonChiTietDAO();
                var res = dao.Delete(item.MaLC);
                if (res)
                {
                    XtraMessageBox.Show("Xóa thành công", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLCCT();
                }
                else
                {
                    XtraMessageBox.Show("Xóa lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        public void ShowFormAdd(int MaLC)
        {
            FrmAddNewEditLuaChonChiTiet form = new FrmAddNewEditLuaChonChiTiet(MaLC);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            if (MaLC == 0)
            {
                form.Text = "Thêm mới";
            }
            else
            {
                form.Text = "Cập nhật";
            }
            form.ShowDialog();
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDanhSachLCCT();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDanhSachLCCT();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ShowFormAdd(0);
        }
        private void griditem_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                var item = griditem.GetRow(info.RowHandle) as LuaChonChiTiet;
                ShowFormAdd(item.MaLC);
            }
        }
    }
}
