using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DGDRL.APP.DAO;
using DevExpress.XtraGrid.Views.Grid;
using DGDRL.Model.DTO;

namespace DGDRL.APP.GUI
{
    public partial class usDanhGiaDiemLop : UserControl
    {
        public usDanhGiaDiemLop()
        {
            InitializeComponent();
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
            GridView view =  sender as GridView;
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
                e.ChildList =dao.GetAllTieuChi(tcdg.MaTC);
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
                var lst = dao.GetAllTieuChi(tcdg.MaCT) as List<LuaChonChiTiet>;
                e.IsEmpty = lst.Count <= 0;
            }
        }

        private void gvNoiDungChiTiet_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var dao = new LuaChonChiTietDAO();
            GridView view = sender as GridView;
            var tcdg = view.GetRow(e.RowHandle) as dynamic;
            if (tcdg != null)
            {
                e.ChildList = dao.GetAllTieuChi(tcdg.MaCT);
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
