using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
   public class KhoaDAO: BaseDAO
    {
        public Khoa GetByMaKhoa(string MaKhoa)
        {
            return _db.Khoas.FirstOrDefault(x => x.MaKhoa == MaKhoa);
        }

        public List<Khoa> GetAll()
        {
            return _db.Khoas.ToList();
        }

        public bool AddOrUpdate(Khoa item, int mode)
        {
            if (mode == 0)
            {
                _db.Khoas.Add(item);
            }
            else
            {
                var up = GetByMaKhoa(item.MaKhoa);
                up.TenKhoa = item.TenKhoa;               
            }
            return SaveToDatabase();
        }
        public bool Delete(string MaKhoa)
        {
            var del = GetByMaKhoa(MaKhoa);
            _db.Khoas.Remove(del);
            return SaveToDatabase();
        }

    }
}
