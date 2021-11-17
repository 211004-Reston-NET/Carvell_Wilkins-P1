using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUSBL;
using CRUSModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUSWebUI.Models;

namespace CRUSWebUI.Controllers
{
    public class OrderPlacementController : Controller
    {
        private ICustomerBL _restBL;
        public OrderPlacementController(ICustomerBL p_restBL)
        {
            _restBL = p_restBL;
        }

        // GET: RestaurantController
        public ActionResult Index()
        {
            //We got our list of restaurant from our business layer
            //We converted that Model restaurant into RestaurantVM using Select method
            //Finally we changed it to a List with ToList()

            ViewData.Add("CustomerName", SingletonVM.customer.Name);
            ViewData.Add("CustomerEmail", SingletonVM.customer.Email);
            return View(_restBL.GetAllOrders()
                        .Select(rest => new OrderPlacementVM(rest))
                        .ToList()
            );
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(OrderPlacementVM restVM)
        {
            //This if statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for attribute elements will appear and autofill in the proper feedback for the user 
            //to correct themselves
            if (ModelState.IsValid)
            {
                _restBL.AddOrder(new OrderPlacement()
                {   
                    StoreFrontId = restVM.StoreFrontId,
                    ProductId = restVM.ProductId,
                    CustomerId = restVM.CustomerId,
                    Price = (int) restVM.Price
                   
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        // GET: RestaurantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Create1(OrderPlacementVM restVM)
        {
            //This if statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for attribute elements will appear and autofill in the proper feedback for the user 
            //to correct themselves
            if (ModelState.IsValid)
            {
                _restBL.AddOrder(new OrderPlacement()
                {
                    CustomerId = restVM.CustomerId,
                    StoreFrontId = restVM.StoreFrontId,
                    Price = (int) restVM.Price
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }


        // GET: RestaurantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestaurantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

