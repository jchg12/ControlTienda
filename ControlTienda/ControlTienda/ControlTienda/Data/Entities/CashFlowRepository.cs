using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{ 

    using Entities;

    public class CashFlowRepository : GenericRepository<CashFlow>, ICashFlowRepository
 {
    public CashFlowRepository(DataContext context) : base(context)
    {

    }

  }
}
