using System.ComponentModel.DataAnnotations;

namespace ControlTienda.Data.Entities
{
    public class Rol :IEntity 
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Details { get; set; }

    }
}
