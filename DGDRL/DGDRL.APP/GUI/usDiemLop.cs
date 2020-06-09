using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGDRL.Model.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace DGDRL.APP.GUI
{
    public partial class usDiemLop : UserControl
    {
        public TaiKhoan Username;
        public usDiemLop(TaiKhoan us)
        {
            InitializeComponent();
            if (us != null)
            {
                Username = us;
                Quyen(Username.ChucVu);
            }
            LoadHocKy();
            LoadNamHoc();
            AddRepository();
        }
        public void Quyen(string quyen)
        {
            this.btnChuyenDiem.Visible = false;
            this.btnChuyenDiemLT.Visible = false;
            this.btnChuyenDiemSV.Visible = false;
            if (quyen == "GV")
            {
                this.btnChuyenDiemLT.Visible = true;
                this.btnChuyenDiemSV.Visible = true;
            }
            else
            {
                this.btnChuyenDiem.Visible = true;
            }
        }
        private void AddRepository()
        {
            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = TextEditStyles.HideTextEditor;
            edit.ButtonClick += edit_ButtonClick;
            edit.Buttons[0].Caption = "Cập Nhật";
            edit.Buttons[0].Kind = ButtonPredefines.Glyph;
            griditem.Columns["GhiChu"].ColumnEdit = edit;
        }
        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var item = griditem.GetRow(griditem.FocusedRowHandle) as dynamic;
            var form = new FrmUpdateDiemLop(Username, item.MSSV, item.Nam, item.hocky);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.ShowDialog();
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDSHocSinh();
        }
        public void LoadHocKy()
        {
            var lst = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("I","Học Kỳ 1"),
                new KeyValuePair<string, string>("II","Học Kỳ 2")
            };
            cbbHocKy.Properties.DataSource = lst;
            cbbHocKy.Properties.ValueMember = "Key";
            cbbHocKy.Properties.DisplayMember = "Value";
            cbbHocKy.EditValue = "I";
        }
        public void LoadNamHoc()
        {
            var lst = new List<KeyValuePair<string, string>>();
            for (int i = DateTime.Now.Year; i >= DateTime.Now.AddYears(-10).Year; i--)
            {
                var item = i + "-" + (i + 1);
                lst.Add(new KeyValuePair<string, string>(item, item));
            }
            cbbNamHoc.Properties.DataSource = lst;
            cbbNamHoc.Properties.ValueMember = "Key";
            cbbNamHoc.Properties.DisplayMember = "Value";
            cbbNamHoc.EditValue = (DateTime.Now.Year + "-" + DateTime.Now.AddYears(1).Year);
        }

        public void LoadDSHocSinh()
        {
            //SVLT
            //SVLP
            //admin
            //GV
            var hocky = cbbHocKy.EditValue as string;
            var namhoc = cbbNamHoc.EditValue as string;
            if (string.IsNullOrEmpty(hocky))
            {
                XtraMessageBox.Show("Vui lòng chọn học kỳ", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(namhoc))
            {
                XtraMessageBox.Show("Vui lòng chọn năm học", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ds = new List<SinhVien>();
                var daoSV = new DAO.SinhVienDAO();
                if (Username.ChucVu == "GV")
                {
                    var daoLop = new DAO.LopDAO();
                    var daoGV = new DAO.GiangVienDAO();
                    var gv = daoGV.GetByTK(Username.Username);
                    var lop = daoLop.GetByMaGV(gv.MaGV);
                    ds = daoSV.GetAllByLop(lop.MaLop);
                }
                if (Username.ChucVu == "SVLP" || Username.ChucVu == "SVLT")
                {
                    var daoLop = new DAO.LopDAO();
                    var daoGV = new DAO.SinhVienDAO();
                    var sv = daoGV.GetByMSSV(Username.Username);
                    ds = daoSV.GetAllByLop(sv.MaLop);
                }
                var i = 1;
                var data = from a in ds
                           select new
                           {
                               STT = i++,
                               Nam = int.Parse(namhoc.Split('-')[0].ToString()),
                               hocky,
                               a.MSSV,
                               a.HoTen,
                               a.NgaySinh,
                               DiemSVDG = DiemCaNhan("DiemSVDG", a.MSSV, int.Parse(namhoc.Split('-')[0].ToString()), hocky),
                               DiemLT = DiemCaNhan("DiemLT", a.MSSV, int.Parse(namhoc.Split('-')[0].ToString()), hocky),
                               DiemCVHT = DiemCaNhan("DiemCVHT", a.MSSV, int.Parse(namhoc.Split('-')[0].ToString()), hocky)
                           };
                gcDanhSach.DataSource = data;
            }

        }
        public int DiemCaNhan(string type, string mssv, int namhoc, string hocky)
        {
            var daodg = new DAO.DiemDanhGiaRenLuyenDAO();
            var diem = daodg.GetAllByMSSV(mssv, namhoc, hocky);
            if (diem != null)
            {
                if (type == "DiemSVDG")
                {
                    return diem.Sum(x => x.DiemSVDG ?? 0);
                }
                if (type == "DiemLT")
                {
                    return diem.Sum(x => x.DiemLT ?? 0);
                }
                if (type == "DiemCVHT")
                {
                    return diem.Sum(x => x.DiemCVHT ?? 0);
                }
            }
            return 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDSHocSinh();
        }

        private void btnChuyenDiemLT_Click(object sender, EventArgs e)
        {
            var hocky = cbbHocKy.EditValue as string;
            var namhoc = cbbNamHoc.EditValue as string;
            if (string.IsNullOrEmpty(hocky))
            {
                XtraMessageBox.Show("Vui lòng chọn học kỳ", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(namhoc))
            {
                XtraMessageBox.Show("Vui lòng chọn năm học", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var check = UpdateChuyenDiem(namhoc, hocky, "GV1");
                if (check)
                {
                    XtraMessageBox.Show("Chuyển điểm thành công", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Chuyển điểm lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnChuyenDiemSV_Click(object sender, EventArgs e)
        {
            var hocky = cbbHocKy.EditValue as string;
            var namhoc = cbbNamHoc.EditValue as string;
            if (string.IsNullOrEmpty(hocky))
            {
                XtraMessageBox.Show("Vui lòng chọn học kỳ", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(namhoc))
            {
                XtraMessageBox.Show("Vui lòng chọn năm học", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var check = UpdateChuyenDiem(namhoc, hocky, "GV2");
                if (check)
                {
                    LoadDSHocSinh();
                    XtraMessageBox.Show("Chuyển điểm thành công", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Chuyển điểm lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnChuyenDiem_Click(object sender, EventArgs e)
        {
            var hocky = cbbHocKy.EditValue as string;
            var namhoc = cbbNamHoc.EditValue as string;
            if (string.IsNullOrEmpty(hocky))
            {
                LoadDSHocSinh();
                XtraMessageBox.Show("Vui lòng chọn học kỳ", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(namhoc))
            {
                XtraMessageBox.Show("Vui lòng chọn năm học", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var check = UpdateChuyenDiem(namhoc, hocky, "SV");
                if (check)
                {
                    LoadDSHocSinh();
                    XtraMessageBox.Show("Chuyển điểm thành công", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Chuyển điểm lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        public bool UpdateChuyenDiem( string namhoc, string hocky, string type)
        {
            var nam = int.Parse(namhoc.Split('-')[0].ToString());
            var dao = new DAO.DiemDanhGiaRenLuyenDAO();
            var lst = dao.GetAllByMSSV(nam, hocky);
            foreach (var item in lst)
            {
                if (type == "GV1")
                {
                    item.DiemCVHT = item.DiemLT;
                }
                else if (type == "GV2")
                {
                    item.DiemCVHT = item.DiemSVDG;
                }
                else
                {
                    item.DiemLT = item.DiemSVDG;
                }
            }
            return dao.SaveToDatabase();
        }
    }
}
