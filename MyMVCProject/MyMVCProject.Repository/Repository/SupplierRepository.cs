using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyMVCProject.Models.Models;
using MyMVCProject.DatabaseContext.DatabaseContext;
using System.Data.Entity;

namespace MyMVCProject.Repository.Repository
{
    
   public class SupplierRepository
    {
        SupplierDbContext db = new SupplierDbContext();
        public bool Add(Supplier supplier)
        {
            int isExecuted = 0;

            db.Suppliers.Add(supplier);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Delete(Supplier supplier)
        {
            int isExecuted = 0;
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.ID == supplier.ID);

            db.Suppliers.Remove(aSupplier);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }
        public bool Update(Supplier supplier)
        {
            int isExecuted = 0;
            
            db.Entry(supplier).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }
        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }
        public Supplier GetByID(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.ID == supplier.ID);
            return aSupplier;
        }
    }
}
