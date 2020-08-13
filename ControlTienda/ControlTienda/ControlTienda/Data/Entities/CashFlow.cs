﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class CashFlow:IEntity 
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public decimal MoneyIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal MoneyOutflow { get; set; }
        public Cash Cash { get; set; }

    }
}
