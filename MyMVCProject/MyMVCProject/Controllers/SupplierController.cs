using MyMVCProject.BLL.BLL;
using MyMVCProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCProject.Controllers
{
    public class SupplierController: Controller
    {
        SupplierManager _supplierManager = new SupplierManager();
        private Supplier _supplier = new Supplier();

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Supplier supplier)
        {
            //_supplier.Code = supplier.Code;
            //_supplier.Name = supplier.Name;
            //_supplier.Address = supplier.Address;
            //_supplier.Email = supplier.Email;
            //_supplier.Contact = supplier.Contact;
            //_supplier.ContactPerson = supplier.ContactPerson;
            //_supplierManager.Add(_supplier);
            if (ModelState.IsValid)
            {
                if (_supplierManager.Add(supplier))
                {
                    ViewBag.SuccessMsg = "Saved";
                }
                else
                {
                    ViewBag.FailMsg = "Failed";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Error";
            }
            return View();
        }
        public ActionResult Delete(Supplier supplier)
        {
            
            _supplier.ID = supplier.ID;
            _supplierManager.Delete(_supplier);
            return View();
        }
        //public ActionResult Update(Supplier supplier)
        //{

        //    _supplier.ID = supplier.ID;

        //    Supplier aSupplier = _supplierManager.GetByID(_supplier);
        //    if (aSupplier != null)
        //    {

        //        _supplier.Name = supplier.Name;
        //        _supplierManager.Update(aSupplier);

        //    }

        //    return View();
        //}

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            _supplier.ID = Id;
            var supplier =_supplierManager.GetByID(_supplier);
            return View(supplier);
        }
        [HttpPost]
        public ActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                if (_supplierManager.Update(supplier))
                {
                    ViewBag.SuccessMsg = "Updated";
                }
                else
                {
                    ViewBag.FailMsg = "Failed";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Error";
            }

            return View(supplier);
        }

        [HttpGet]
        public ActionResult Show()
        {
            var suppliers = _supplierManager.GetAll();
            _supplier.Suppliers = suppliers;
            return View(_supplier);

        }
        [HttpPost]
        public ActionResult Show(Supplier supplier)
        {
            var suppliers = _supplierManager.GetAll();
            if (supplier.Name != null)
            {
                suppliers = suppliers.Where(c => c.Name.ToLower().Contains(supplier.Name.ToLower())).ToList();
            }
            if (supplier.Code != null)
            {
                suppliers = suppliers.Where(c => c.Code.ToLower().Contains(supplier.Code.ToLower())).ToList();
            }
            if (supplier.Address != null)
            {
               suppliers = suppliers.Where(c => c.Address.ToLower().Contains(supplier.Address.ToLower())).ToList();
            }
            if (supplier.Email != null)
            {
                suppliers = suppliers.Where(c => c.Email.ToLower().Contains(supplier.Email.ToLower())).ToList();
            }
            if (supplier.Contact > 0)
            {
                suppliers = suppliers.Where(c => c.Contact == supplier.Contact).ToList();
            }
            supplier.Suppliers = suppliers;
            return View(supplier);

        }
    }
}