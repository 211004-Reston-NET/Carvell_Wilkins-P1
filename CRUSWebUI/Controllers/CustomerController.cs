using System.Linq;
using CRUSBL;
using CRUSModels;
using CRUSWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUSWebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerBL _restBL;
        public CustomerController(ICustomerBL p_restBL)
        {
            _restBL = p_restBL;
        }

        // GET: RestaurantController
        public ActionResult Index()
        {
            //We got our list of restaurant from our business layer
            //We converted that Model restaurant into RestaurantVM using Select method
            //Finally we changed it to a List with ToList()
            return View(_restBL.GetAllCustomer()
                        .Select(rest => new CustomerVM(rest))
                        .ToList()
            );
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerVM restVM)
        {
            //This if statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for attribute elements will appear and autofill in the proper feedback for the user 
            //to correct themselves
            if (ModelState.IsValid)
            {
                _restBL.AddCustomer(new Customer()
                {
                    Name = restVM.Name,
                    Address = restVM.Address,
                    Email = restVM.Email
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        // GET: RestaurantController/Details/5
        public ActionResult Details(int CustomerId)
        {
            return View();
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int CustomerId)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int CustomerId, IFormCollection collection)
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
        public ActionResult Delete(int CustomerId)
        {
            return View (new CustomerVM(_restBL.GetCustomerById(CustomerId)));


        }

        public ActionResult Login(CustomerVM p_customerVM)
        {
            ViewData.Add("Customer Name", SingletonVM.customer.Name);
            ViewData.Add("Customer Email", SingletonVM.customer.Email);
            if (ModelState.IsValid)
            {
                SingletonVM.customer = _restBL.GetSingleCustomer(p_customerVM.Name, p_customerVM.Email);
                return RedirectToAction(nameof(Index));


            }
            return View();
        }


        // POST: RestaurantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int CustomerId, IFormCollection collection)
        {
            try
            {
                Customer toBeDeleted = _restBL.GetCustomerById(CustomerId);
                _restBL.DeleteCustomer(toBeDeleted);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        


           
            
        }
    }











        //public IActionResult Details(int CustomerId)
        //{
        //    if (ModelState.IsValid)
        //    {


        //        string name = Name;
        //        string email = Email;

        //        Customer Login = new Customer();
        //        try
        //        {
        //            Login = _restBL.GetCustomerById(p_customerId);
        //            return RedirectToAction(nameof(Index);
        //        catch (System.Exception)
        //        {


        //            return View();
        //        }


        //        CustomerVM x = new CustomerVM();
        //        name = Login.Name;
        //        email = Login.Email;




        //        return RedirectToAction("ShoppingIndex", "StoreFront");
        //    }
