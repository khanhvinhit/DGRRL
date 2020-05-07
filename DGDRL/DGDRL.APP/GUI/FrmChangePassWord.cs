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
    public partial class FrmChangePassWord : DevExpress.XtraEditors.XtraForm
    {
        public TaiKhoan Username;
        public FrmChangePassWord(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.Username = taiKhoan;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dao = new TaiKhoanDAO();
            var us = dao.GetByUsername(Username.Username);
            if (us != null)
            {
                us.Password = "";
            }
            var res = dao.SaveToDatabase();
            if (res)
            {
                if (XtraMessageBox.Show("Thay đổi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Thay đổi lỗi", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}