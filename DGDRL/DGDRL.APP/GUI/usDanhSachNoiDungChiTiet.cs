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
using DGDRL.Model.DTO;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachNoiDungChiTiet : UserControl
    {
        public usDanhSachNoiDungChiTiet()
        {
            InitializeComponent();
            LoadDanhSachTC();
            LoadDanhSachNDCT();
            AddRepository();
        }
        public void LoadDanhSachTC()
        {
            var dao = new TieuChiDanhGiaDAO();
            var lst = dao.GetAll();
            cbbDanhSachTC.Properties.DataSource = lst;
            cbbDanhSachTC.Properties.ValueMember = "MaTC";
            cbbDanhSachTC.Properties.DisplayMember = "NoiDung";
        }
        public void LoadDanhSachNDCT()
        {
            gcDanhSach.DataSource = null;
            gcDanhSach.Controls.Clear();
            var dao = new NoiDungChiTietDAO();
            var lst = new List<NoiDungChiTiet>();
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
                var item = griditem.GetRow(griditem.FocusedRowHandle) as NoiDungChiTiet;
                var dao = new NoiDungChiTietDAO();
                var res = dao.Delete(item.MaCT);
                if (res)
                {
                    XtraMessageBox.Show("Xóa thành công", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNDCT();
                }
                else
                {
                    XtraMessageBox.Show("Xóa lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        public void ShowFormAdd(int MaCT)
        {
            FrmAddNewEditNoiDungChiTiet form = new FrmAddNewEditNoiDungChiTiet(MaCT);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            if (MaCT == 0)
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
            LoadDanhSachTC();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDanhSachNDCT();
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
                var item = griditem.GetRow(info.RowHandle) as NoiDungChiTiet;
                ShowFormAdd(item.MaCT);
            }
        }
    }
}
