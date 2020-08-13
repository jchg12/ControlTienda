using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Category :IEntity 
    {
        public int Id { set; get; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }
}
