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
    public partial class FrmAddNewEditNoiDungChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public int MaCT;
        public FrmAddNewEditNoiDungChiTiet(int mact)
        {
            InitializeComponent();
            if (mact > 0)
            {
                MaCT = mact;
                LoadData();
                btnAdd.Text = "Cập nhật";
            }
            LoadDanhSachCT();
        }
        public void LoadDanhSachCT()
        {
            var dao = new TieuChiDanhGiaDAO();
            var lst = dao.GetAll();
            cbbDanhSachTC.Properties.DataSource = lst;
            cbbDanhSachTC.Properties.ValueMember = "MaTC";
            cbbDanhSachTC.Properties.DisplayMember = "NoiDung";

        }
        private void LoadData()
        {
            var dao = new NoiDungChiTietDAO();
            var item = dao.GetByMaCT(MaCT);
            if (item != null)
            {
                txtNoiDung.Text = item.NoiDung;
                numDiem.Text = item.DiemCTMax.Value.ToString();
                cbbDanhSachTC.EditValue = item.MaTC;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new NoiDungChiTietDAO();
            var item = dao.GetByMaCT(MaCT);

            string sErr = "";
            bool bVali = true;
            var nd = txtNoiDung.Text;
            var max = numDiem.Text;
            var tc = cbbDanhSachTC.EditValue as string;
            if (string.IsNullOrEmpty(nd))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập nội dung chi tiết đánh giá";
            }
            if (string.IsNullOrEmpty(max))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập số điểm tối đa";
            }
            if (string.IsNullOrEmpty(tc))
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn tiêu chí đánh giá";
            }
            if (bVali)
            {
                var mode = 1;
                if (item == null)
                {
                    item = new NoiDungChiTiet();
                    mode = 0;
                }
                item.NoiDung = nd;
                item.DiemCTMax = int.Parse(max);
                item.MaTC = int.Parse(tc);
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