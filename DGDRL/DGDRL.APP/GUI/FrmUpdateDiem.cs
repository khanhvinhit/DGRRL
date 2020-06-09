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
    public partial class FrmUpdateDiem : DevExpress.XtraEditors.XtraForm
    {
        public TaiKhoan Username;
        public int ID;
        public int Diem;
        public int Min;
        public int Max;
        public string type;
        public FrmUpdateDiem(TaiKhoan us, int id, int diem, int min, int max, string type)
        {
            InitializeComponent();
            Username = us;
            this.ID = id;
            this.Diem = diem;
            this.Min = min;
            this.Max = max;
            this.type = type;
            numDiem.Value = Diem;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DiemDanhGiaRenLuyenDAO dao = new DiemDanhGiaRenLuyenDAO();
            int diem = (int)numDiem.Value;
            if (diem < this.Min)
            {
                XtraMessageBox.Show("Điểm tối thiểu phải từ " + this.Min, "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (diem > this.Max)
            {
                XtraMessageBox.Show("Điểm tối đa phải thấp hơn hoặc bằng " + this.Max, "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dao.UpdateDiem(this.ID, diem, Username.ChucVu, type);
                this.Close();
            }
        }
    }
}