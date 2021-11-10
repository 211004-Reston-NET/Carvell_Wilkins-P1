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
    public class ProductController : Controller
    {
        private IProductBL _restBL;
        public ProductController(IProductBL p_restBL)
        {
            _restBL = p_restBL;
        }

        // GET: RestaurantController
        public ActionResult Index()
        {
            //We got our list of restaurant from our business layer
            //We converted that Model restaurant into RestaurantVM using Select method
            //Finally we changed it to a List with ToList()
            return View(_restBL.getAllProduct()
                        .Select(rest => new ProductVM(rest))
                        .ToList()
            );
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductVM restVM)
        {
            //This if statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for attribute elements will appear and autofill in the proper feedback for the user 
            //to correct themselves
            // *** if (ModelState.IsValid)
            //  {
            //      _restBL.getAllProduct(new Product()
            //      {
            //          Name = restVM.Name,
            //          Price =  restVM.Price,
            //          Quantity = restVM.Quantity
            //      });

            //      return RedirectToAction(nameof(Index));
            //  }

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
