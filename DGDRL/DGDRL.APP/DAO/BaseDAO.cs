using DGDRL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGDRL.APP.DAO
{
    public class BaseDAO
    {
        public DGRLSVEntities _db;

        public BaseDAO()
        {
            _db = new DGRLSVEntities();
        }

        public bool SaveToDatabase()
        {
            try
            {
                return _db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }   
    }
}
