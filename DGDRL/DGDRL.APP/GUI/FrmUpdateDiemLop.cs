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
using DGDRL.Model.DTO;
using DGDRL.APP.DAO;
using DevExpress.XtraGrid.Views.Grid;

namespace DGDRL.APP.GUI
{
    public partial class FrmUpdateDiemLop : DevExpress.XtraEditors.XtraForm
    {
        public TaiKhoan Username;
        public string MSSV;
        public int Nam;
        public string Hocky;
        public FrmUpdateDiemLop(TaiKhoan us, string mssv, int nam, string hocky)
        {
            InitializeComponent();
            Username = us;
            MSSV = mssv;
            Nam = nam;
            Hocky = hocky;
            LoadData();
        }
        public void LoadData()
        {
            var dao = new TieuChiDanhGiaDAO();
            var lstall = dao.GetAll().Select(x => new { x.MaTC, NoiDungTC = x.NoiDung, x.DiemTCMax }).ToList();
            gvDGRL.DataSource = lstall;
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
                e.ChildList = dao.GetAllTieuChi(tcdg.MaTC);
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
                var lst = dao.GetAllByMSSV(MSSV, Nam, Hocky);
                var lstrenluyen = dao._db.ViewLuaChonChiTiets.ToList();
                if (lst.Count() <= 0)
                {
                    foreach (var item in lstrenluyen)
                    {
                        dao.AddOrUpdate(new Model.DTO.DGRenLuyen()
                        {
                            NamHoc = Nam,
                            MaHK = Hocky,
                            MSSV = MSSV,
                            MaLC = item.MaLC
                        }, 0);
                    }
                    lst = dao.GetAllByMSSV(MSSV, Nam, Hocky);
                }
                var lc = daob.GetAllLuaChon(tcdg.MaCT) as List<LuaChonChiTiet>;
                var lstsource = from a in lst.Where(x=> lc.Any(y=> y.MaLC == x.MaLC))
                                join b in lc on a.MaLC equals b.MaLC
                                select new
                                {
                                    b.MaLC,
                                    b.MoTa,
                                    DiemTT = b.DiemMin,
                                    DiemTD = b.DiemMax,
                                    DiemSV = a.DiemSVDG,
                                    DiemLTT = a.DiemLT,
                                    DiemGV = a.DiemCVHT

                                };
                e.ChildList = lstsource.ToList();
                if (Username.ChucVu == "GV")
                {
                    this.DiemLTT.OptionsColumn.AllowEdit = false;
                    this.DiemLTT.OptionsColumn.AllowFocus = false;
                }
                if (Username.ChucVu == "SVLT"&& Username.ChucVu == "SVLP")
                {
                    this.DiemGV.OptionsColumn.AllowEdit = false;
                    this.DiemGV.OptionsColumn.AllowFocus = false;
                }
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
    }
}