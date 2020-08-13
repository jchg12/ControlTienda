using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class DetailSaleRepository : GenericRepository<DetailSale>, IDetailSaleRepository
    {
        public DetailSaleRepository(DataContext context) : base(context)
        {

        }

    }

}
