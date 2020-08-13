using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class DetailPurchaseRepository : GenericRepository<DetailPurchase>, IDetailPurchaseRepository
    {
        public DetailPurchaseRepository(DataContext context) : base(context)
        {

        }
    }

}
