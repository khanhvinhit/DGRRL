using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGDRL.APP.DAO;
using DGDRL.Model.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachDanhGiaDiemRenLuyen : UserControl
    {
        public TaiKhoan Username;
        public string MSSV;
        public usDanhSachDanhGiaDiemRenLuyen(TaiKhoan us, string mssv)
        {
            InitializeComponent();
            Username = us;
            MSSV = mssv;
            LoadHocKy();
            LoadNamHoc();
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
        public void loadNoiDung()
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

                var dao = new TieuChiDanhGiaDAO();
                var lstall = dao.GetAll().Select(x => new { x.MaTC, NoiDungTC = x.NoiDung, x.DiemTCMax }).ToList();
                gvDGRL.DataSource = lstall;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadNoiDung();
        }

        private void gvTieuChiDanhGia_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            var dao = new NoiDungChiTietDAO();
            GridView view = sender as GridView;
            var tcdg = view.GetRow(e.RowHandle) as dynamic;
            if (tcdg != null)
            {
                var lst = dao.GetAllTieuChi(tcdg.MaTC) as List<NoiDungChiTiet>;
                e.IsEmpty = lst.Count <= 0;
            }
        }

        private void gvTieuChiDanhGia_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            var dao = new NoiDungChiTietDAO();
            GridView view = sender as GridView;
            var tcdg = view.GetRow(e.RowHandle) as dynamic;
            if (tcdg != null)
            {
                e.ChildList = (dao.GetAllTieuChi(tcdg.MaTC) as List<NoiDungChiTiet>).ToList().Select(x => new
                {
                    MaCTView = (x.MaCT >= 10) ? "0" + x.MaCT : "00" + x.MaCT,
                    x.MaCT,
                    x.MaTC,
                    x.NoiDung,
                    x.DiemCTMax
                }).ToList();
            }
        }

        private void gvTieuChiDanhGia_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvTieuChiDanhGia_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "NoiDungChiTiet";
        }

        private void gvNoiDungChiTiet_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            var dao = new LuaChonChiTietDAO();
            GridView view = sender as GridView;
            var tcdg = view.GetRow(e.RowHandle) as dynamic;
            if (tcdg != null)
            {
                var lst = dao.GetAllLuaChon(tcdg.MaCT) as List<LuaChonChiTiet>;
                e.IsEmpty = lst.Count <= 0;
            }
        }

        private void gvNoiDungChiTiet_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var dao = new DiemDanhGiaRenLuyenDAO();
            var daob = new LuaChonChiTietDAO();
            GridView view = sender as GridView;
            var tcdg = view.GetRow(e.RowHandle) as dynamic;
            if (tcdg != null)
            {
                var hocky = cbbHocKy.EditValue as string;
                var namhoc = cbbNamHoc.EditValue as string;
                int namhoc2 = int.Parse(namhoc.Split('-')[0].ToString());
                var lst = dao.GetAllByMSSV(MSSV, namhoc2, hocky);
                var lstrenluyen = dao._db.ViewLuaChonChiTiets.ToList();
                if (lst.Count() <= 0)
                {
                    foreach (var item in lstrenluyen)
                    {
                        dao.AddOrUpdate(new Model.DTO.DGRenLuyen()
                        {
                            NamHoc = namhoc2,
                            MaHK = hocky,
                            MSSV = MSSV,
                            MaLC = item.MaLC
                        }, 0);
                    }
                    lst = dao.GetAllByMSSV(MSSV, namhoc2, hocky);
                }
                var lc = daob.GetAllLuaChon(tcdg.MaCT) as List<LuaChonChiTiet>;
                var lstsource = from a in lst.Where(x => lc.Any(y => y.MaLC == x.MaLC))
                                join b in lc on a.MaLC equals b.MaLC
                                select new
                                {
                                    MaLCView = (b.MaLC >= 10) ? "0" + b.MaLC : "00" + b.MaLC,
                                    b.MaLC,
                                    b.MoTa,
                                    DiemTT = b.DiemMin,
                                    DiemTD = b.DiemMax,
                                    DiemSV = a.DiemSVDG,
                                    DiemLTT = a.DiemLT,
                                    DiemGV = a.DiemCVHT
                                };
                e.ChildList = lstsource.ToList();
            }
        }

        private void gvNoiDungChiTiet_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvNoiDungChiTiet_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "LuaChonChiTiet";
        }
        private void gvLuaChonChiTiet_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            var item = view.DataSource as dynamic;
            if (item != null)
            {
                int id = item[0].MaLC;
                int diem = item[0].DiemSV ?? 0;
                int diemtt = item[0].DiemTT ?? 0;
                int diemtd = item[0].DiemTD ?? 0;
                var frm = new FrmUpdateDiem(Username,id, diem, diemtt, diemtd,"Thap");
                frm.StartPosition = FormStartPosition.Manual;
                var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y-15);
                frm.Location = _point;
                frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                frm.ShowDialog();
            }
            
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadNoiDung();
        }
    }
}
