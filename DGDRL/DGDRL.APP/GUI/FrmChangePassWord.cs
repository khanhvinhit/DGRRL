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
            string sErr = "";
            bool bVali = true;
            var passOld = txtPasswordOld.Text;
            var newpass = txtNewPassWord.Text;
            var confirmpass = txtConfirmPassword.Text;

            if (us == null)
            {
                sErr = sErr + "Vui drdfdfgfẩu cũ";
                bVali = false;
            }
            if (string.IsNullOrEmpty(passOld))
            {
                sErr = sErr + "Vui lòng nhập mật khẩu cũ";
                bVali = false;
            }
            if (us.Password != passOld)
            {
                sErr = sErr + "Mật khẩu sai";
                bVali = false;
            }
            if (string.IsNullOrEmpty(newpass))
            {
                sErr = sErr + "Vui lòng nhập mật khẩu mới";
                bVali = false;
            }
            if (string.IsNullOrEmpty(confirmpass))
            {
                sErr = sErr + "Vui lòng nhập mật khẩu xác nhận";
                bVali = false;
            }
            if (newpass == passOld)
            {
                sErr = sErr + "Mật khẩu mới trùng với mật khẩu cũ";
                bVali = false;
            }
            if (newpass != confirmpass)
            {
                sErr = sErr + "Mật khẩu mới không trùng với xác nhận mật khẩu";
                bVali = false;
            }
            if (bVali)
            {
                us.Password = newpass;
                var res = dao.SaveToDatabase();
                if (res)
                {
                    sErr = sErr + "Thay đổi thành công";
                    if (XtraMessageBox.Show(sErr, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    sErr = sErr + "Thay đổi thất bại";
                    XtraMessageBox.Show(sErr, "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show(sErr, "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}