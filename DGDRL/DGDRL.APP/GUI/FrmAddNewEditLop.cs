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
    public partial class FrmAddNewEditLop : DevExpress.XtraEditors.XtraForm
    {
        public string MaLop;
        public FrmAddNewEditLop(string malop)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(malop))
            {
                MaLop = malop;
                LoadData();
                btnAdd.Text = "Cập nhật";
            }
            LoadDanhSachKhoa();
            LoadDanhSachGV();
        }
        public void LoadDanhSachKhoa()
        {
            var dao = new KhoaDAO();
            var lst = dao.GetAll();
            cbbDanhSachKhoa.Properties.DataSource = lst;
            cbbDanhSachKhoa.Properties.ValueMember = "MaKhoa";
            cbbDanhSachKhoa.Properties.DisplayMember = "TenKhoa";

        }
        public void LoadDanhSachGV()
        {
            var dao = new GiangVienDAO();
            var lst = dao.GetAll();
            cbbGVCN.Properties.DataSource = lst;
            cbbGVCN.Properties.ValueMember = "MaGV";
            cbbGVCN.Properties.DisplayMember = "TenGV";

        }
        private void LoadData()
        {
            var dao = new LopDAO();
            var item = dao.GetByMaLop(MaLop);
            if (item != null)
            {
                txtMaLop.ReadOnly = true;
                txtMaLop.Text = item.MaLop;
                txtTenLop.Text = item.TenLop;
                cbbDanhSachKhoa.EditValue = item.MaKhoa;
                cbbGVCN.EditValue = item.MaGV;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new LopDAO();
            var item = dao.GetByMaLop(MaLop);

            string sErr = "";
            bool bVali = true;
            var ma = txtMaLop.Text;
            var ten = txtTenLop.Text;
            var khoa = cbbDanhSachKhoa.EditValue as string;
            var gv = cbbGVCN.EditValue as string;
            if (string.IsNullOrEmpty(ma))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập mã lớp";
            }
            if (string.IsNullOrEmpty(ten))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập tên lớp";
            }
            if (string.IsNullOrEmpty(khoa))
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn khoa";
            }
            if (string.IsNullOrEmpty(gv))
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn GVCN";
            }

            if (item == null)
            {
                var check = dao.GetByMaGV(ma);
                if (check != null)
                {
                    bVali = false;
                    sErr = sErr + "GVCN đã làm giáo viên chủ nhiệm của lớp khác";
                }
            }
            if (bVali)
            {
                var mode = 1;
                if (item == null)
                {
                    item = new Lop();
                    item.MaLop = ma;
                    mode = 0;
                }
                item.TenLop = ten;
                item.MaKhoa = khoa;
                item.MaGV = gv;
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