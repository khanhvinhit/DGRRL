using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class KetQuaDAO: BaseDAO
    {
        public KetQua GetByMSSV(string MSSV)
        {
            return _db.KetQuas.FirstOrDefault(x => x.MSSV == MSSV);
        }

        public List<KetQua> GetAll()
        {
            return _db.KetQuas.ToList();
        }

        public bool AddOrUpdate(KetQua item, int mode)
        {
            if (mode == 0)
            {
                _db.KetQuas.Add(item);
            }
            else
            {
                var up = GetByMSSV(item.MSSV);
                up.NamHoc = item.NamHoc;
                up.MaHK = item.MaHK;
                up.TongDiemSV = item.TongDiemSV;
                up.TongDiemLT = item.TongDiemLT;
                up.TongDiemCVHT = item.TongDiemCVHT;
                up.XepLoai = item.XepLoai;
            }
            return SaveToDatabase();
        }
        public bool Delete(string MSSV)
        {
            var del = GetByMSSV(MSSV);
            _db.KetQuas.Remove(del);
            return SaveToDatabase();
        }

    }
}
