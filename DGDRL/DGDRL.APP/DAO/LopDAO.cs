using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
   public class LopDAO: BaseDAO
    {
        public Lop GetByMaLop(string MaLop)
        {
            return _db.Lops.FirstOrDefault(x => x.MaLop == MaLop);
        }

        public Lop GetByMaGV(string MaGV)
        {
            return _db.Lops.FirstOrDefault(x => x.MaGV == MaGV);
        }
        
        public List<Lop> GetAll(string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                return _db.Lops.ToList();
            }
            return _db.Lops.Where(x => x.TenLop.Contains(content) || x.MaLop.Contains(content) || x.MaGV.Contains(content)).ToList();
        }

        public List<Lop> GetAllByMaKhoa(string MaKhoa, string content = "")
        {
            var lst = MaKhoa.Split(',');
            if (string.IsNullOrEmpty(content))
            {
                return _db.Lops.Where(x => lst.Any(y => y == x.MaKhoa)).ToList();
            }
            return _db.Lops.Where(x => lst.Any(y => y == x.MaKhoa)).Where(x => x.TenLop.Contains(content) || x.MaLop.Contains(content) || x.MaGV.Contains(content)).ToList();
        }
        public bool AddOrUpdate(Lop item, int mode)
        {
            if (mode == 0)
            {
                _db.Lops.Add(item);
            }
            else
            {
                var up = GetByMaLop(item.MaLop);
                up.TenLop = item.TenLop;
                up.MaKhoa = item.MaKhoa;
                up.MaGV = item.MaGV;
                up.MaLT = item.MaLT;
            }
            return SaveToDatabase();
        }
        public bool Delete(string MaLop)
        {
            var del = GetByMaLop(MaLop);
            _db.Lops.Remove(del);
            return SaveToDatabase();
        }
    }
}
