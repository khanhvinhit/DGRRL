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
    public partial class frmAddNewEditKhoa : DevExpress.XtraEditors.XtraForm
    {
        public string MaKhoa;
        public frmAddNewEditKhoa(string maKhoa)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(maKhoa))
            {
                MaKhoa = maKhoa;
                LoadData();
                btnAdd.Text = "Cập nhật";
            }
        }
        private void LoadData()
        {
            var dao = new KhoaDAO();
            var item = dao.GetByMaKhoa(MaKhoa);
            if (item != null)
            {
                txtMaKhoa.ReadOnly = true;
                txtTenKhoa.Text = item.TenKhoa;

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new KhoaDAO();
            var item = dao.GetByMaKhoa(MaKhoa);

            string sErr = "";
            bool bVali = true;
            var ma = txtMaKhoa.Text;
            var ten = txtTenKhoa.Text;
            if (string.IsNullOrEmpty(ma))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập mã khoa";
            }
            if (string.IsNullOrEmpty(ten))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập tên khoa";
            }

            if (item == null)
            {
                var check = dao.GetByMaKhoa(ma);
                if (check != null)
                {
                    bVali = false;
                    sErr = sErr + "Mã giảng viên đã tồn tại";
                }
            }
            if (bVali)
            {
                var mode = 1;
                if (item == null)
                {
                    item = new Khoa();
                    item.MaKhoa = ma;
                    mode = 0;
                }
                item.TenKhoa = ten;
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