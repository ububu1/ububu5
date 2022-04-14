using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин_Цветов.Classes
{
    class Context
    {
        private static db_3Entities _db;
        public static db_3Entities db
        {
            get
            {
                if (_db == null)
                    _db = new db_3Entities();
                return _db;
            }
        }
    }
}
