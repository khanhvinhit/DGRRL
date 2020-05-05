using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class LuaChonChiTietDAO: BaseDAO
    {
        public LuaChonChiTiet GetByMaLC(int MaLC)
        {
            return _db.LuaChonChiTiets.FirstOrDefault(x => x.MaLC == MaLC);
        }

        public List<LuaChonChiTiet> GetAll()
        {
            return _db.LuaChonChiTiets.ToList();
        }

        public bool AddOrUpdate(LuaChonChiTiet item, int mode)
        {
            if (mode == 0)
            {
                _db.LuaChonChiTiets.Add(item);
            }
            else
            {
                var up = GetByMaLC(item.MaLC);
                up.MaCT = item.MaCT;
                up.MoTa = item.MoTa;
                up.DiemMin = item.DiemMin;
                up.DiemMax = item.DiemMax;
            }
            return SaveToDatabase();
        }
        public bool Delete(int MaLC)
        {
            var del = GetByMaLC(MaLC);
            _db.LuaChonChiTiets.Remove(del);
            return SaveToDatabase();
        }
    }
}
