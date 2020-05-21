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
            loadNoiDung();
        }
        public void loadNoiDung()
        {
            var dao = new DiemDanhGiaRenLuyenDAO();
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

            var lstsource = from a in lst
                            join b in lstrenluyen on a.MaLC equals b.MaLC
                            select new
                            {
                                a.ID,
                                NoiDungTC = (b.MaTC.ToString().Length >= 2) ? b.MaTC + ": " + b.NoiDungTC : b.MaTC + ": " + b.NoiDungTC,
                                NoiDungCT = (b.MaCT.ToString().Length >= 2) ? "0" + b.MaCT + ": " + b.NoiDungCT : "00" + b.MaCT + ": " + b.NoiDungCT,
                                NoiDungLC = (a.MaLC.ToString().Length >= 2) ? "0" + a.MaLC + ": " + b.NoiDungLC : "00" + a.MaLC + ": " + b.NoiDungLC,
                                b.DiemTCMax,
                                b.DiemMax,
                                a.DiemSVDG,
                                a.DiemLT,
                                a.DiemCVHT
                            };

            gcDanhSach.DataSource = lstsource;
        }
    }
}