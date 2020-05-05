using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class DiemDanhGiaRenLuyenDAO:BaseDAO
    {
        public DGRenLuyen GetByNamHoc(int NamHoc)
        {
            return _db.DGRenLuyens.FirstOrDefault(x => x.NamHoc == NamHoc);
        }

        public List<DGRenLuyen> GetAll()
        {
            return _db.DGRenLuyens.ToList();
        }

        public bool AddOrUpdate(DGRenLuyen item, int mode)
        {
            if (mode == 0)
            {
                _db.DGRenLuyens.Add(item);
            }
            else
            {
                var up = GetByNamHoc(item.NamHoc);               
                up.MaHK = item.MaHK;
                up.MSSV = item.MSSV;
                up.MaTC = item.MaTC;
                up.MaLC = item.MaLC;
                up.DiemSVDG = item.DiemSVDG;
                up.DiemLT = item.DiemLT;
                up.DiemCVHT = item.DiemCVHT;
            }
            return SaveToDatabase();
        }
        public bool Delete(int NamHoc)
        {
            var del = GetByNamHoc(NamHoc);
            _db.DGRenLuyens.Remove(del);
            return SaveToDatabase();
        }

    }
}
