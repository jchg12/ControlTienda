using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ControlTienda.Data.Entities
{
   public  class Refund :IEntity
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Amount { get; set; }
        public string Remark { get; set; }

        public DetailSale DetailSale { get; set; }
    }
}
