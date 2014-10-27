using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuddyCardWeb.Models;
using BuddyCardWeb.Repository;

namespace BuddyCardWeb.Controllers
{
    public class CreditCardController : Controller
    {
        // GET: CreditCard
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreditCard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreditCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreditCard/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
				CreditCard card = new CreditCard()
				{
					Name = collection["Name"],
					FirstName = collection["FirstName"],
					LastName = collection["LastName"],
					Expiration = Convert.ToDateTime(collection["Expiration"]),
					CreditCardNumber = collection["CreditCardNumber"],
					Vendor = collection["Vendor"],
					CVV = collection["CVV"],
				};

				card = CreditCardRepository.Create(card);
                //return RedirectToAction("Index");
				return View(card);
        }

        // GET: CreditCard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreditCard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditCard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreditCard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
