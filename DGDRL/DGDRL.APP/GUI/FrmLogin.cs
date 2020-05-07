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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public delegate void DataSend(TaiKhoan taiKhoan);
        public DataSend dataSend;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUser.Text;
            var password = txtPass.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Lỗi");
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Lỗi");
            }
            var dao = new LoginDAO();
            var check = dao.Login(username, password);
            if (check == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi");
            }
            else if (check == 1)
            {
                MessageBox.Show("Sai mật khẩu", "Lỗi");
            }
            else
            {
                var us = dao.LoginAccept(username);
                dataSend(us);
                this.Close();
            }
        }
    }
}