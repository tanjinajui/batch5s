using MyMVCProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVCProject.DatabaseContext.DatabaseContext
{
   public class SupplierDbContext:DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
