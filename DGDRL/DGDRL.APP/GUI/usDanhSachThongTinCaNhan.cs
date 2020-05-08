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
using DGDRL.APP.DAO;

namespace DGDRL.APP.GUI
{
    public partial class usDanhSachThongTinCaNhan : UserControl
    {
        public TaiKhoan Username;
        public usDanhSachThongTinCaNhan(TaiKhoan us)
        {
            InitializeComponent();
            this.Username = us;
            LoadThongTin();
        }
        public void LoadThongTin()
        {
            if (Username.ChucVu == "GV")
            {

            }
            else if(Username.ChucVu == "SVLT"|| Username.ChucVu == "SVLP"|| Username.ChucVu == "SVTV")
            {
                SinhVienDAO dao = new SinhVienDAO();
                var item = dao.GetByMSSV(Username.Username);
                lbMSSV.Text = item.MSSV;
                lbHoTen.Text = item.HoTen;
                lbMaLop.Text = item.MaLop;
                lbNgaySinh.Text = item.NgaySinh.Value.ToString("dd/MM/yyyy");
                lbQueQuan.Text = item.QueQuan;
            }
        }
       
    }
}
