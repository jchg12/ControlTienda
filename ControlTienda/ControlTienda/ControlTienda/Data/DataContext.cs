using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{
    using Entities;
    using System.Data.Entity;
     public class DataContext :DbContext
    {
        public DataContext():base("name=conection")
        {

        }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<CashFlow> cashFlows { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DetailPurchase>DetailPurchases { get; set; }
        public DbSet<DetailSale >DetailSales { get; set; }
        public DbSet<Logg> Loggs { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet <Refund>Refunds { get; set; }
        public DbSet <Rol>Rols { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
