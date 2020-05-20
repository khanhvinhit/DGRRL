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
            var dao = new DiemDanhGiaRenLuyenDAO();
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

                var lstsource = from a in lst
                                join b in lstrenluyen on a.MaLC equals b.MaLC
                                select new
                                {
                                    a.ID ,
                                    NoiDungTC = (b.MaTC.ToString().Length >= 2) ? b.MaTC + ": " + b.NoiDungTC :b.MaTC + ": " + b.NoiDungTC,
                                    NoiDungCT = (b.MaCT.ToString().Length >= 2) ? "0" + b.MaCT + ": "+ b.NoiDungCT: "00" + b.MaCT + ": " + b.NoiDungCT,
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadNoiDung();
            //Show group columns in the table.
            griditem.OptionsView.ShowGroupedColumns = true;

            // Expand group rows.
            griditem.ExpandAllGroups();
            //GridColumn colReceived = griditem.Columns["NoiDungTC"];
            //GridColumn colRead = griditem.Columns["NoiDungCT"];
            //griditem.BeginSort();
            //try
            //{
            //    griditem.ClearGrouping();
            //    colReceived.Width = 500;
            //    colReceived.GroupIndex = 0;
            //    colRead.Width = 500;
            //    colRead.GroupIndex = 1;
            //}
            //finally
            //{
            //    griditem.EndSort();
            //}
        }
    }
}
