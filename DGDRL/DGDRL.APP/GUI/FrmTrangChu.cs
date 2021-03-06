﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DGDRL.Model.DTO;

namespace DGDRL.APP.GUI
{
    public partial class FrmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TaiKhoan Username;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmTrangChu));
        public FrmTrangChu()
        {
            InitializeComponent();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.dataSend = new FrmLogin.DataSend(GetFirstValue);
            frmLogin.ShowDialog();
            if (Username == null)
            {
                frmLogin.ShowDialog();
            }
        }
        public void Quyen(string quyen)
        {
            this.ribbonPage2.Visible = false;
            this.btnDanhGiaDiemRenLuyen.Visibility = BarItemVisibility.Never;
            this.btnDiemLop.Visibility = BarItemVisibility.Never;
            if (quyen == "SVTV")
            {
                this.btnDanhGiaDiemRenLuyen.Visibility = BarItemVisibility.Always;
            }
            if (quyen == "SVLT" || quyen == "SVLP" || quyen == "SVTV")
            {
                this.btnDanhGiaDiemRenLuyen.Visibility = BarItemVisibility.Always;
                this.btnDiemLop.Visibility = BarItemVisibility.Always;
            }
            if (quyen == "GV")
            {
                this.btnDiemLop.Visibility = BarItemVisibility.Always;
            }
            if (quyen == "admin")
            {
                this.ribbonPage2.Visible = true;
            }
        }
        public void GetFirstValue(TaiKhoan username)
        {
            this.Username = username;
            Quyen(Username.ChucVu);
            tabControlMain.TabPages.Clear();
        }
        public int checkTab(string TabNameAdd)
        {
            for (int i = 0; i < tabControlMain.TabPages.Count; i++)
            {
                if (tabControlMain.TabPages[i].Name == TabNameAdd)
                {
                    return i;
                }
            }
            return -1;
        }
        public void AddTab(XtraTabControl XtraTabCha, string icon, string TabNameAdd, string TabNameCaption, UserControl UserControl)
        {
            if (checkTab(TabNameAdd) > -1)
            {
                XtraTabCha.SelectedTabPage = XtraTabCha.TabPages[checkTab(TabNameAdd)];
            }
            else
            {
                XtraTabPage TAbAdd = new XtraTabPage();
                TAbAdd.Name = TabNameAdd;
                TAbAdd.Text = TabNameCaption;
                TAbAdd.Controls.Add(UserControl);
                UserControl.Dock = DockStyle.Fill;

                if (!string.IsNullOrEmpty(icon))
                {
                    TAbAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject(icon)));
                    TAbAdd.ImageOptions.SvgImageSize = new Size(16, 16);
                }
                XtraTabCha.TabPages.Add(TAbAdd);
                XtraTabCha.SelectedTabPage = XtraTabCha.TabPages[tabControlMain.TabPages.Count - 1];
            }
        }
        private void tabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            tabControlMain.TabPages.Remove((arg.Page as XtraTabPage));
        }
        private void btnDanhSachKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachKhoa.ImageOptions.SvgImage", "DanhSachKhoa", "Danh Sách Khoa", new usDanhSachKhoa());
        }

        private void btnDanhSachGiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachGiangVien.ImageOptions.SvgImage", "DanhSachGiangVien", "Danh Sách Giảng Viên", new usDanhSachGiangVien());
        }

        private void btnDanhSachLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachLop.ImageOptions.SvgImage", "DanhSachLop", "Danh Sách Lớp ", new usDanhSachLop());
        }

        private void btnDanhSachSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachSinhVien.ImageOptions.SvgImage", "DanhSachSinhVien", "Danh Sách Sinh Viên", new usDanhSachSinhVien());
        }

        private void btnDanhSachTieuChiDanhGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachTieuChiDanhGia.ImageOptions.SvgImage", "DanhSachTieuChiDanhGia", "Danh Sách Tiêu Chí Đánh Giá", new usDanhSachTieuChiDanhGia());
        }

        private void btnDanhSachNoiDungChiTiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachNoiDungChiTiet.ImageOptions.SvgImage", "DanhSachNoiDungChiTiet", "Danh Sách Nội Dung Chi Tiết", new usDanhSachNoiDungChiTiet());
        }

        private void btnDanhSachLuaChonChiTiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhSachLuaChonChiTiet.ImageOptions.SvgImage", "DanhSachLuaChonChiTiet", "Danh Sách Lựa Chọn Chi Tiết", new usDanhSachLuaChonChiTiet());
        }

        private void btnThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnThongTinCaNhan.ImageOptions.SvgImage", "ThongTinCaNhan", "Thông Tin Cá Nhân", new usDanhSachThongTinCaNhan(Username));
        }

        private void barButtonItemDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            var changepw = new FrmChangePassWord(Username);
            changepw.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDanhGiaDiemRenLuyen.ImageOptions.SvgImage", "DanhGiaDiemRenLuyen", "Đánh Giá Điểm Rèn Luyện", new usDanhSachDanhGiaDiemRenLuyen(Username,Username.Username));
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.dataSend = new FrmLogin.DataSend(GetFirstValue);
            frmLogin.ShowDialog();
            if (Username != null)
            {
                this.Show();
                if (Username.ChucVu != "admin")
                {

                }
            }
            else
            {
                frmLogin.ShowDialog();
            }
        }

        private void btnDiemLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(tabControlMain, "btnDiemLop.ImageOptions.SvgImage", "DiemLop", "Điểm Lớp", new usDiemLop(Username));
        }
    }
}