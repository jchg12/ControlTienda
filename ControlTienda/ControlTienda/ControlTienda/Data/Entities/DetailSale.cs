using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class DetailSale :IEntity 
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]

        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public decimal UnitPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public decimal TotalPrice { get; set; }

        public Product Product { get; set; }
        public  Sale Sale {get;set;}
    }
}
