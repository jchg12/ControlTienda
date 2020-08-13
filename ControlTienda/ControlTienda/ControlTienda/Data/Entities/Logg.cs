using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ControlTienda.Data.Entities
{
    public class Logg :IEntity 
    {
        public int Id { get; set; }
        public DateTime? DteLogin { get; set; }
        public DateTime? DateLogout { get; set; }
        [MaxLength(250)]
        public string Remark { get; set; }
        public User User { get; set; }
    }
}
