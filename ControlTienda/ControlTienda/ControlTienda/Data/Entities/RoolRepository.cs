using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        public RolRepository(DataContext context) : base(context)
        {

        }
    }

}
