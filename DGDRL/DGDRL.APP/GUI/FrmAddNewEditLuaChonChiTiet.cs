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
            var dao = new NoiDungChiTietDAO();
            var lst = dao.GetAll();
            cbbDanhSachTC.Properties.DataSource = lst;
            cbbDanhSachTC.Properties.ValueMember = "MaCT";
            cbbDanhSachTC.Properties.DisplayMember = "NoiDung";

        }
        private void LoadData()
        {
            var dao = new LuaChonChiTietDAO();
            var item = dao.GetByMaLC(MaLC);
            if (item != null)
            {
                txtMS.Text = item.MaLC.ToString();
                txtMS.ReadOnly = true;
                txtNoiDung.Text = item.MoTa;
                numDiemMin.Text = item.DiemMin.Value.ToString();
                numDiemMin.Text = item.DiemMax.Value.ToString();
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
            var maso = txtMS.Text;
            var nd = txtNoiDung.Text;
            var min = numDiemMin.Text;
            var max = numDiemMax.Text;
            var tc = (int)cbbDanhSachTC.EditValue;
            if (string.IsNullOrEmpty(maso))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập mã";
            }
            if (string.IsNullOrEmpty(nd))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập mô tả";
            }
            if (string.IsNullOrEmpty(min))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập số điểm tối thiểu";
            }
            if (string.IsNullOrEmpty(max))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập số điểm tối đa";
            }
            if (tc <= 0)
            {
                bVali = false;
                sErr = sErr + "Vui lòng chọn nội dung chi tiết";
            }
            if (bVali)
            {
                var mode = 1;
                if (item == null)
                {
                    item = new LuaChonChiTiet();
                    mode = 0;
                    item.MaLC = int.Parse(maso);
                }
                item.MoTa = nd;
                item.DiemMin = int.Parse(min);
                item.DiemMax = int.Parse(max);
                item.MaCT = tc;

                var tcDAO = new LuaChonChiTietDAO();

                var tcitem = tcDAO.GetByMaLC(tc);
                var sum = dao.GetAllTieuChi(tc).Sum(x => x.DiemMax);
                if (mode == 0)
                {
                    if (sum > tcitem.DiemMax)
                    {
                        XtraMessageBox.Show("Điểm nội dung chi tiết đã vượt điểm tiêu chí tối đa cho phép", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    sum = dao.GetAllTieuChi(tc).Where(x => x.MaCT != item.MaCT).Sum(x => x.DiemMax);
                    if ((sum + item.DiemMax) > tcitem.DiemMax)
                    {
                        XtraMessageBox.Show("Điểm nội dung chi tiết đã vượt điểm tiêu chí tối đa cho phép", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

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