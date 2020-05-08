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
    public partial class FrmAddNewEditSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public string MSSV;
        public FrmAddNewEditSinhVien(string mssv)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(mssv))
            {
                MSSV = mssv;
                LoadData();
                btnAdd.Text = "Cập nhật";
            }
            LoadDanhSachLop();
            LoadDanhSachCV();
        }

        private void LoadDanhSachCV()
        {
            var lst = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("SVTV","Thành Viên"),
                new KeyValuePair<string, string>("SVLT","Lớp Trưởng"),
                new KeyValuePair<string, string>("SVLP","Lớp Phó"),
            };
            cbbQuyen.Properties.DataSource = lst;
            cbbQuyen.Properties.ValueMember = "Key";
            cbbQuyen.Properties.DisplayMember = "Value";
        }

        public void LoadDanhSachLop()
        {
            var dao = new LopDAO();
            var lst = dao.GetAll();
            cbbDanhSachLop.Properties.DataSource = lst;
            cbbDanhSachLop.Properties.ValueMember = "MaLop";
            cbbDanhSachLop.Properties.DisplayMember = "TenLop";

        }
        private void LoadData()
        {
            var dao = new SinhVienDAO();
            var item = dao.GetByMSSV(MSSV);
            if (item != null)
            {
                txtMSSV.ReadOnly = true;
                txtMSSV.Text = item.MSSV;
                txtHoTen.Text = item.HoTen;
                txtQueQuan.Text = item.QueQuan;
                deNgaySinh.Text = item.NgaySinh.Value.ToString("yyyy/MM/dd");
                cbbDanhSachLop.EditValue = item.MaLop;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new SinhVienDAO();
            var item = dao.GetByMSSV(MSSV);

            string sErr = "";
            bool bVali = true;
            var ma = txtMSSV.Text;
            var ten = txtHoTen.Text;
            var que = txtQueQuan.Text;
            var ngay = deNgaySinh.Text;
            var lop = cbbDanhSachLop.EditValue as string;
            var cv = cbbQuyen.EditValue as string;
            if (string.IsNullOrEmpty(ma))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập mã số sinh viên";
            }
            if (string.IsNullOrEmpty(ten))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập tên sinh viên";
            }
            if (string.IsNullOrEmpty(ngay))
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn ngày sinh";
            }
            if (string.IsNullOrEmpty(lop))
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn lớp";
            }
            if (item == null)
            {
                var check = dao.GetByMSSV(ma);
                if (check != null)
                {
                    bVali = false;
                    sErr = sErr + "Sinh viên đã tồn tại";
                }
            }
            if (bVali)
            {
                var mode = 1;
                if (item == null)
                {
                    item = new SinhVien();
                    item.MSSV = ma;
                    mode = 0;
                }
                item.HoTen = ten;
                item.QueQuan = que;
                item.NgaySinh = DateTime.Parse(ngay);
                item.MaLop = lop;
                var res = dao.AddOrUpdate(item, mode);
                if (res)
                {

                    if (mode == 1)
                    {
                        sErr = "Cập nhật thành công";
                    }
                    else
                    {
                        sErr = "Thêm thành công";
                        var usDAO = new TaiKhoanDAO();
                        if (cv == "SVLT" || cv == "SVLT")
                        {
                            var check = usDAO._db.SinhViens.Where(x => x.MaLop == item.MaLop).ToList();
                            foreach (var ite in check)
                            {
                                var us = usDAO.GetByUsername(ite.MSSV);
                                if (us != null)
                                {
                                    if (us.ChucVu == cv)
                                    {
                                        us.ChucVu = "SVTV";
                                        usDAO.SaveToDatabase();
                                        break;
                                    }

                                }
                            }
                        }
                        usDAO.AddOrUpdate(new TaiKhoan()
                        {
                            Username = item.MSSV,
                            Password = "1234567890",
                            ChucVu = (string.IsNullOrEmpty(cv) ? "SVTV" : cv)
                        }, 0);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}