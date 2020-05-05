﻿using System;
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
    public partial class usDanhSachLop : UserControl
    {
        public usDanhSachLop()
        {
            InitializeComponent();
            LoadDanhSachKhoa();
            LoadDanhSachLop();
            AddRepository();
        }

        public void LoadDanhSachKhoa()
        {
            var dao = new KhoaDAO();
            var lst = dao.GetAll();
            cbbDanhSachKhoa.Properties.DataSource = lst;
            cbbDanhSachKhoa.Properties.ValueMember = "MaKhoa";
            cbbDanhSachKhoa.Properties.DisplayMember = "TenKhoa";
        }
        public void LoadDanhSachLop()
        {
            gcDanhSach.DataSource = null;
            gcDanhSach.Controls.Clear();
            var dao = new LopDAO();
            var lst = new List<Lop>();
            var ids = string.Join(",", cbbDanhSachKhoa.Properties.Items.GetCheckedValues());
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
                var item = griditem.GetRow(griditem.FocusedRowHandle) as Lop;
                var dao = new LopDAO();
                var res = dao.Delete(item.MaGV);
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
        public void ShowFormAdd(string GiangVien)
        {
            FrmAddNewEditLop form = new FrmAddNewEditLop(GiangVien);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            if (string.IsNullOrEmpty(GiangVien))
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
            LoadDanhSachLop();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ShowFormAdd("");
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDanhSachLop();
        }

        private void griditem_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                var item = griditem.GetRow(info.RowHandle) as Lop;
                ShowFormAdd(item.MaLop);
            }
        }
    }
}
