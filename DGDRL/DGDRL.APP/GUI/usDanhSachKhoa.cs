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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DGDRL.Model.DTO;

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachKhoa : UserControl
    {
        DataTable dt = new DataTable();
        public usDanhSachKhoa()
        {
            InitializeComponent();
            dt.Columns.Add("MaKhoa");
            dt.Columns.Add("TenKhoa");
            LoadData();
        }
        public void LoadData()
        {
            gcDanhSach.DataSource = null;
            gcDanhSach.Controls.Clear();
            KhoaDAO dao = new KhoaDAO();
            var lst = dao.GetAll();

            foreach (var item in lst)
            {
                var dr = dt.NewRow();
                dr["MaKhoa"] = item.MaKhoa.Trim();
                dr["TenKhoa"] = item.TenKhoa.Trim();

                dt.Rows.Add(dr);
            }
            gcDanhSach.DataSource = dt;
        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            griditem.AddNewRow();
        }

        private void gridItem_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KhoaDAO dao = new KhoaDAO();
            string sErr = "";
            bool bVali = true;
            var MaKhoa = griditem.GetRowCellValue(e.RowHandle, "MaKhoa").ToString();
            var TenKhoa = griditem.GetRowCellValue(e.RowHandle, "TenKhoa").ToString();
            if (e.RowHandle < 0)
            {
                if (string.IsNullOrEmpty(TenKhoa))
                {
                    bVali = false;
                    sErr = sErr + "Vui lòng nhập tên khoa";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(MaKhoa))
                {
                    bVali = false;
                    sErr = sErr + "Vui lòng nhập mã khoa";
                }
                if (string.IsNullOrEmpty(TenKhoa))
                {
                    bVali = false;
                    sErr = sErr + "Vui lòng nhập tên khoa";
                }
            }
            if (bVali)
            {
                var item = new Khoa();
                item.MaKhoa = MaKhoa.Trim();
                item.TenKhoa = TenKhoa.Trim();
                if (e.RowHandle < 0)
                {
                    dao.AddOrUpdate(item, 0);
                }
                else
                {
                    dao.AddOrUpdate(item, 1);
                }
            }
            else
            {
                e.Valid = false;
                XtraMessageBox.Show(sErr, "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gcDanhSach_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && griditem.State != GridState.Editing)
            {
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dt.Rows.RemoveAt(griditem.FocusedRowHandle);
                }
            }
        }
        
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            griditem.AddNewRow();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt.Rows.RemoveAt(griditem.FocusedRowHandle);
                KhoaDAO dao = new KhoaDAO();
            }
        }
    }
}
