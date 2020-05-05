using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
   public class TieuChiDanhGiaDAO: BaseDAO
    {      
        public TieuChiDanhGia GetByMaTC(int MaTC)
        {
            return _db.TieuChiDanhGias.FirstOrDefault(x => x.MaTC == MaTC);
        }

        public List<TieuChiDanhGia> GetAll(string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                return _db.TieuChiDanhGias.ToList();
            }
            return _db.TieuChiDanhGias.Where(x => x.NoiDung.Contains(content)).ToList();
        }

        public bool AddOrUpdate(TieuChiDanhGia item, int mode)
        {
            if (mode == 0)
            {
                _db.TieuChiDanhGias.Add(item);
            }
            else
            {
                var up = GetByMaTC(item.MaTC);
                up.NoiDung = item.NoiDung;
                up.DiemTCMax = item.DiemTCMax;             
            }
            return SaveToDatabase();
        }
        public bool Delete(int MaTC)
        {
            var del = GetByMaTC(MaTC);
            _db.TieuChiDanhGias.Remove(del);
            return SaveToDatabase();
        }
    }
}
