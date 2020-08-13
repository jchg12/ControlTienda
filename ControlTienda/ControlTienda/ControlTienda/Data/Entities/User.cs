using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ControlTienda.Data.Entities
{
   public class User :IEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(25)]
        public string Phone { get; set; }
        [MinLength(6),MaxLength(8)]
        public string Nickname { get; set; }
        [MinLength(8), MaxLength(15)]
        public string Password { get; set; }
        public Rol Rol { get; set; }

    }
}
