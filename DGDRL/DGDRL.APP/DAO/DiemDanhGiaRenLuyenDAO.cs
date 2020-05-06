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
        public DGRenLuyen GetByID(int ID)
        {
            return _db.DGRenLuyens.FirstOrDefault(x => x.ID == ID);
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
                var up = GetByID(item.ID);               
                up.MaHK = item.MaHK;
                up.MSSV = item.MSSV;
                up.MaLC = item.MaLC;
                up.DiemSVDG = item.DiemSVDG;
                up.DiemLT = item.DiemLT;
                up.DiemCVHT = item.DiemCVHT;
            }
            return SaveToDatabase();
        }
        public bool Delete(int ID)
        {
            var del = GetByID(ID);
            _db.DGRenLuyens.Remove(del);
            return SaveToDatabase();
        }

    }
}
