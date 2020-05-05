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
    public partial class FrmAddNewEditCTDG : DevExpress.XtraEditors.XtraForm
    {
        public int MaTC;
        public FrmAddNewEditCTDG(int mtc=0)
        {
            InitializeComponent();
            if (mtc > 0)
            {
                MaTC = mtc;
                LoadData();
                btnAdd.Text = "Cập nhật";
            }
        }
        private void LoadData()
        {
            var dao = new TieuChiDanhGiaDAO();
            var item = dao.GetByMaTC(MaTC);
            if (item != null)
            {
                txtNoiDung.Text = item.NoiDung;
                numDiem.Text = item.DiemTCMax.Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new TieuChiDanhGiaDAO();
            var item = dao.GetByMaTC(MaTC);

            string sErr = "";
            bool bVali = true;
            var nd = txtNoiDung.Text;
            var max = numDiem.Text;
            if (string.IsNullOrEmpty(nd))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập nội dung tiêu chí đánh giá";
            }
            if (string.IsNullOrEmpty(max))
            {
                bVali = false;
                sErr = sErr + "Vui lòng nhập số điểm tối đa";
            }
            if (bVali)
            {
                var mode = 1;
                if (item == null)
                {
                    item = new TieuChiDanhGia();
                    mode = 0;
                }
                item.NoiDung = nd;
                item.DiemTCMax = int.Parse(max);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}