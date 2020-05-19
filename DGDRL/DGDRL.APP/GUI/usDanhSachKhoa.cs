using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGDRL.APP.DAO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DGDRL.Model.DTO;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachKhoa : UserControl
    {
        DataTable dt = new DataTable();
        public usDanhSachKhoa()
        {
            InitializeComponent();
            LoadDanhSachKhoa();
            AddRepository();
        }
        public void LoadDanhSachKhoa()
        {
            gcDanhSach.DataSource = null;
            gcDanhSach.Controls.Clear();
            var dao = new KhoaDAO();
            var ser = txtSearch.Text;
            var lst = dao.GetAll(ser);
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
                var item = griditem.GetRow(griditem.FocusedRowHandle) as Khoa;
                var dao = new KhoaDAO();
                var res = dao.Delete(item.MaKhoa);
                if (res)
                {
                    XtraMessageBox.Show("Xóa thành công", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhoa();
                }
                else
                {
                    XtraMessageBox.Show("Xóa lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void ShowFormAdd(string Khoa)
        {
            frmAddNewEditKhoa form = new frmAddNewEditKhoa(Khoa);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            if (string.IsNullOrEmpty(Khoa))
            {
                form.Text = "Thêm mới";
            }
            else
            {
                form.Text = "Cập nhật";
            }
            form.ShowDialog();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhoa();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ShowFormAdd("");
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDanhSachKhoa();
        }
        private void griditem_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                var item = griditem.GetRow(info.RowHandle) as Khoa;
                ShowFormAdd(item.MaKhoa);
            }
        }

    }
}
