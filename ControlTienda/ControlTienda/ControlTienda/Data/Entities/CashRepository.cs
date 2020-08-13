using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class CashRepository : GenericRepository<Cash>, ICashRepository
    {
        public CashRepository(DataContext context) : base(context)
        {

        }
    }

}
