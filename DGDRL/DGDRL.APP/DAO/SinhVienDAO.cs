using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
   public class SinhVienDAO: BaseDAO
    {
        public SinhVien GetByMSSV(string MSSV)
        {
            return _db.SinhViens.FirstOrDefault(x => x.MSSV == MSSV);
        }

        public List<SinhVien> GetAll(string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                return _db.SinhViens.ToList();
            }
            return _db.SinhViens.Where(x => x.MSSV.Contains(content) || x.MaLop.Contains(content) || x.HoTen.Contains(content)).ToList();
        }
        public List<SinhVien> GetAllByLop(string MaLop, string content = "")
        {
            var lst = MaLop.Split(',');
            if (string.IsNullOrEmpty(content))
            {
                return _db.SinhViens.Where(x => lst.Any(y => y == x.MaLop)).ToList();
            }
            return _db.SinhViens.Where(x => lst.Any(y => y == x.MaLop)).Where(x => x.MSSV.Contains(content) || x.MaLop.Contains(content) || x.HoTen.Contains(content)).ToList();
        }
        public bool AddOrUpdate(SinhVien item, int mode)
        {
            if (mode == 0)
            {
                _db.SinhViens.Add(item);
            }
            else
            {
                var up = GetByMSSV(item.MSSV);
                up.HoTen = item.HoTen;
                up.NgaySinh = item.NgaySinh;
                up.QueQuan = item.QueQuan;
                up.MaLop = item.MaLop;
            }
            return SaveToDatabase();
        }
        public bool Delete(string MSSV)
        {
            var del = GetByMSSV(MSSV);
            _db.SinhViens.Remove(del);
            return SaveToDatabase();
        }
    }
}
