using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class GiangVienDAO : BaseDAO
    {
        public GiangVien GetByMaGV(string MaGV)
        {
            return _db.GiangViens.FirstOrDefault(x => x.MaGV == MaGV);
        }
        public GiangVien GetByTK(string Tk)
        {
            return _db.GiangViens.FirstOrDefault(x => x.TenTaiKhoan == Tk);
        }
        public List<GiangVien> GetAll(string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                return _db.GiangViens.ToList();
            }
            return _db.GiangViens.Where(x=>x.TenGV.Contains(content) || x.MaGV.Contains(content) || x.TenTaiKhoan.Contains(content)).ToList();
        }
        public List<GiangVien> GetAllByMaKhoa(string MaKhoa, string content = "")
        {
            var lst = MaKhoa.Split(',');
            if (string.IsNullOrEmpty(content))
            {
                return _db.GiangViens.Where(x => lst.Any(y => y == x.MaKhoa)).ToList();
            }
            return _db.GiangViens.Where(x => lst.Any(y => y == x.MaKhoa)).Where(y=> y.TenGV.Contains(content) || y.MaGV.Contains(content) || y.TenTaiKhoan.Contains(content)).ToList();
        }

        public bool AddOrUpdate(GiangVien item, int mode)
        {
            if (mode == 0)
            {
                _db.GiangViens.Add(item);
            }
            else
            {
                var up = GetByMaGV(item.MaGV);
                up.TenGV = item.TenGV;
                up.MaKhoa = item.MaKhoa;
                up.TenTaiKhoan = item.TenTaiKhoan;
            }
            return SaveToDatabase();
        }
        public bool Delete(string MaGV)
        {
            var del = GetByMaGV(MaGV);
            _db.GiangViens.Remove(del);
            return SaveToDatabase();
        }

    }
}
