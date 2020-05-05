using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class TaiKhoanDAO: BaseDAO
    {
        public TaiKhoan GetByUsername(string Username)
        {
            return _db.TaiKhoans.FirstOrDefault(x => x.Username == Username);
        }

        public List<TaiKhoan> GetAll()
        {
            return _db.TaiKhoans.ToList();
        }

        public bool AddOrUpdate(TaiKhoan item, int mode)
        {
            if (mode == 0)
            {
                _db.TaiKhoans.Add(item);
            }
            else
            {
                var up = GetByUsername(item.Username);
                up.Password = item.Password;
                up.ChucVu = item.ChucVu;             
            }
            return SaveToDatabase();
        }
        public bool Delete(string Username)
        {
            var del = GetByUsername(Username);
            _db.TaiKhoans.Remove(del);
            return SaveToDatabase();
        }
    }
}
