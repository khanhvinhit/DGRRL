using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class LoginDAO:BaseDAO
    {
        public LoginDAO()
        {

        }

        public int Login(string username, string password)
        {
            var data = _db.TaiKhoans.FirstOrDefault(x => x.Username == username);
            if (data == null)
            {
                //Không tồn tại
                return 0;
            }
            if (data.Password != password)
            {
                //Sai mật khẩu
                return 1;
            }
            return 2;
        }
        public string LoginAccept(string username, bool isGiaoVien)
        {
            if (isGiaoVien)
            {
                var data = _db.GiangViens.FirstOrDefault(x => x.MaGV == username);
                return data.MaGV;
            }
            else
            {
                var data = _db.SinhViens.FirstOrDefault(x => x.MSSV == username);
                return data.MSSV;
            }
        }
    }
}
