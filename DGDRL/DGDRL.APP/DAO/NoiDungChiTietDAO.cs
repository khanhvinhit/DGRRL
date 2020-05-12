using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class NoiDungChiTietDAO: BaseDAO
    {
        public NoiDungChiTiet GetByMaCT(int MaCT)
        {
            return _db.NoiDungChiTiets.FirstOrDefault(x => x.MaCT == MaCT);
        }

        public List<NoiDungChiTiet> GetAll(string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                return _db.NoiDungChiTiets.ToList();
            }
            return _db.NoiDungChiTiets.Where(x => x.NoiDung.Contains(content)).ToList();
        }
        public List<NoiDungChiTiet> GetAllTieuChi(int MaTC)
        {
            return _db.NoiDungChiTiets.Where(x => x.MaTC == MaTC).ToList();
        }

        public List<NoiDungChiTiet> GetAllByMaKhoa(string TC, string content = "")
        {
            var lst = TC.Split(',');
            if (string.IsNullOrEmpty(content))
            {
                return _db.NoiDungChiTiets.Where(x => lst.Any(y => int.Parse(y) == x.MaTC)).ToList();
            }
            return _db.NoiDungChiTiets.Where(x => lst.Any(y => int.Parse(y) == x.MaTC)).Where(x => x.NoiDung.Contains(content)).ToList();
        }
        public bool AddOrUpdate(NoiDungChiTiet item, int mode)
        {
            if (mode == 0)
            {
                _db.NoiDungChiTiets.Add(item);
            }
            else
            {
                var up = GetByMaCT(item.MaCT);
                up.MaTC = item.MaTC;
                up.NoiDung = item.NoiDung;
                up.DiemCTMax = item.DiemCTMax;
            }
            return SaveToDatabase();
        }
        public bool Delete(int MaCT)
        {
            var del = GetByMaCT(MaCT);
            _db.NoiDungChiTiets.Remove(del);
            return SaveToDatabase();
        }
    }
}
