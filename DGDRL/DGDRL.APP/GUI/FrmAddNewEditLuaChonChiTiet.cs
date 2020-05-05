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
    public partial class FrmAddNewEditLuaChonChiTiet : DevExpress.XtraEditors.XtraForm
    {

        public int MaLC;
        public FrmAddNewEditLuaChonChiTiet(int malc)
        {
            InitializeComponent();
            if (malc > 0)
            {
                MaLC = malc;
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
            var dao = new LuaChonChiTietDAO();
            var item = dao.GetByMaLC(MaLC);
            if (item != null)
            {
                txtNoiDung.Text = item.MoTa;
                numDiem.Text = item.DiemMin.Value.ToString();
                numDiem.Text = item.DiemMax.Value.ToString();
                cbbDanhSachTC.EditValue = item.MaCT;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new LuaChonChiTietDAO();
            var item = dao.GetByMaLC(MaLC);

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
                    item = new LuaChonChiTiet();
                    mode = 0;
                }
                item.MoTa = nd;
                item.DiemMin = int.Parse(max);
                item.DiemMax = int.Parse(max);
                item.MaCT = int.Parse(tc);
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