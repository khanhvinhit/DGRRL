using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DGDRL.APP.DAO;
using DGDRL.Model.DTO;

namespace DGDRL.APP.GUI
{
    public partial class FrmAddNewEditGiangVien : DevExpress.XtraEditors.XtraForm
    {
        public string MaGiangVien;
        public FrmAddNewEditGiangVien(string maGiangVien)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(maGiangVien))
            {
                MaGiangVien = maGiangVien;
                LoadData();
                btnAdd.Text = "Cập nhật";
            }
            LoadDanhSachKhoa();
        }

        public void LoadDanhSachKhoa()
        {
            var dao = new KhoaDAO();
            var lst = dao.GetAll();
            cbbDanhSachKhoa.Properties.DataSource = lst;
            cbbDanhSachKhoa.Properties.ValueMember = "MaKhoa";
            cbbDanhSachKhoa.Properties.DisplayMember = "TenKhoa";

        }
        private void LoadData()
        {
            var dao = new GiangVienDAO();
            var item = dao.GetByMaGV(MaGiangVien);
            if (item != null)
            {
                txtMaGiangVien.ReadOnly = true;
                txtMaGiangVien.Text = item.MaGV;
                txtTenGiangVien.Text = item.TenGV;
                txtTenTaiKhoan.Text = item.TenTaiKhoan;
                if (!string.IsNullOrEmpty(item.TenTaiKhoan))
                {
                    txtTenTaiKhoan.ReadOnly = true;
                }
                cbbDanhSachKhoa.EditValue = item.MaKhoa;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new GiangVienDAO();
            var item = dao.GetByMaGV(MaGiangVien);

            string sErr = "";
            bool bVali = true;
            var ma = txtMaGiangVien.Text;
            var ten = txtTenGiangVien.Text;
            var khoa = cbbDanhSachKhoa.EditValue as string;
            var tk = txtTenTaiKhoan.Text;            
            if (string.IsNullOrEmpty(ma))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập mã giảng viên";
            }
            if (string.IsNullOrEmpty(ten))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập tên giang viên";
            }
            if (string.IsNullOrEmpty(khoa))
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn khoa";
            }
            if (string.IsNullOrEmpty(tk))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập tên đăng nhập";
            }

            if (item == null)
            {
                var check = dao.GetByMaGV(ma);
                if (check != null)
                {
                    bVali = false;
                    sErr = sErr + "Mã giảng viên đã tồn tại";
                }
            }
            if (item == null)
            {
                var check = dao.GetByTK(tk);
                if (check != null)
                {
                    bVali = false;
                    sErr = sErr + "Tên đăng nhập đã tồn tại";
                }
            }
            if (bVali)
            {
                var mode = 1;
                var checktk = false;
                if (item == null)
                {
                    item = new GiangVien();
                    item.MaGV = ma;
                    item.TenTaiKhoan = tk;
                    mode = 0;
                    checktk = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(item.TenTaiKhoan) && !string.IsNullOrEmpty(tk))
                    {
                        checktk = true;
                        item.TenTaiKhoan = tk;
                    }
                }
                item.TenGV = ten;
                item.MaKhoa = khoa;
                var res = dao.AddOrUpdate(item, mode);
                if (res)
                {

                    if (checktk)
                    {
                        var usDAO = new TaiKhoanDAO();
                        usDAO.AddOrUpdate(new TaiKhoan()
                        {
                            Username = item.TenTaiKhoan,
                            Password = "1234567890",
                            ChucVu = "GV"
                        }, 0);
                    }
                    if (mode == 1)
                    {
                        sErr = "Cập nhật thành công";
                    }
                    else
                    {
                        sErr = "Thêm thành công";
                    }
                    if (XtraMessageBox.Show(sErr, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Tạo lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show(sErr, "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}