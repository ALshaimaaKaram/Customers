using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Models;
using Customers.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
    public class CustomerTypeController : Controller
    {
		private readonly ICustomerRepository<CustomerType> customerTypeRepository;

		public CustomerTypeController(ICustomerRepository<CustomerType> customerTypeRepository)
		{
			this.customerTypeRepository = customerTypeRepository;
		}


		// GET: CustomerType
		public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerType customerType)
        {
            try
            {
				customerTypeRepository.Add(customerType);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerType/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerType customerType)
        {
            try
            {
				customerTypeRepository.Update(customerType);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerType/Delete/5
        public ActionResult Delete(int id)
        {
			var customerType = customerTypeRepository.FindById(id);
			return View(customerType);
        }

        // POST: CustomerType/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerType customerType)
        {
            try
            {
                customerTypeRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}