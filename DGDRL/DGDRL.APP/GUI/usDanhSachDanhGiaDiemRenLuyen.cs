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

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachDanhGiaDiemRenLuyen : UserControl
    {
        public string MSSV;
        public usDanhSachDanhGiaDiemRenLuyen(string mssv)
        {
            InitializeComponent();
            LoadHocKy();
            LoadNamHoc();
            MSSV = mssv;
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
                                    b.MaLC,
                                    b.MoTa,
                                    DiemTT = b.DiemMin,
                                    DiemTD = b.DiemMax,
                                    DiemSV = a.DiemSVDG,
                                    DiemLTT = a.DiemLT,
                                    DiemGV = a.DiemCVHT
                                };
                e.ChildList = lstsource.ToList();
                //if (lst.Any(x=>x.DiemCVHT != null))
                //{
                //    this.DiemSV.OptionsColumn.AllowEdit = false;
                //    this.DiemSV.OptionsColumn.AllowFocus = false;
                //}
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

        private void gvLuaChonChiTiet_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvLuaChonChiTiet_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            var maLC = gvLuaChonChiTiet.GetRowCellValue(e.RowHandle, "MaLC").ToString();
            var diem = gvLuaChonChiTiet.GetRowCellValue(e.RowHandle, "DiemSV").ToString();
            XtraMessageBox.Show(maLC, diem, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //if (e.RowHandle < 0)
            //{
            //    if (string.IsNullOrEmpty(maLC))
            //    {
            //        bVali = false;
            //        sErr = sErr + "Vui lòng nhập tên khoa";
            //    }
            //}
        }

        private void gvDGRL_ProcessGridKey(object sender, KeyEventArgs e)
        {

        }
    }
}
