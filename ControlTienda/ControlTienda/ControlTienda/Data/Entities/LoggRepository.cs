using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class LoggRepository : GenericRepository<Logg>, ILoggRepository
    {
        public LoggRepository(DataContext context) : base(context)
        {

        }

    }

}
