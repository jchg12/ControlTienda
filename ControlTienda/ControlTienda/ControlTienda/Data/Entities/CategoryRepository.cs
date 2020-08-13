using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class CategoryRepository : GenericRepository<Cash>, ICashRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {

        }
    }

}
