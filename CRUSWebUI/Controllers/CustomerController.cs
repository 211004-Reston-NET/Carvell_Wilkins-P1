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
        public ICustomerBL _restBL;
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

            ViewData.Add("CustomerName", SingletonVM.customer.Name);
            ViewData.Add("CustomerEmail", SingletonVM.customer.Email);
            return View(_restBL.GetAllCustomer()
                        .Select(rest => new CustomerVM(rest))
                        .ToList()
            );
        }

        public ActionResult WelcomePage()
        {

            ViewData.Add("OrderId", SingletonVM.orderPlacement.OrderId);
            ViewData.Add("CustomerId", SingletonVM.orderPlacement.CustomerId);
            ViewData.Add("CustomerName", SingletonVM.customer.Name);
            ViewData.Add("CustomerEmail", SingletonVM.customer.Email);
            return View(_restBL.GetAllCustomer()
                        .Select(rest => new CustomerVM(rest))
                        .ToList()
            );
        }
        // GET: CustomerController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WelcomePage(CustomerVM p_customerVM)
        {
            ViewBag.CustomerName = SingletonVM.customer.Name;
            ViewBag.CustomerAddress = SingletonVM.customer.Address;
            if (ModelState.IsValid)
            {
                SingletonVM.customer = _restBL.GetACustomer(p_customerVM.Name, p_customerVM.Email);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }




        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(CustomerVM p_customerVM)
        {
            ViewBag.CustomerName = SingletonVM.customer.Name;
            ViewBag.CustomerAddress = SingletonVM.customer.Email;
            if (ModelState.IsValid)
            {
                SingletonVM.customer = _restBL.GetACustomer(p_customerVM.Name, p_customerVM.Email);
                return RedirectToAction(nameof(WelcomePage));
            }
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


        
      
        public ActionResult Details1(int CustomerId) /*Commented this out and added this above the Http post*/

        {
                {


                return View(_restBL.GetAllCustomer()
                            .Select(rest => new CustomerVM(rest))
                            .ToList()
                );
                }
            


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
        
        public ActionResult Login1(CustomerVM p_customerVM)
        {
            ViewData.Add("CustomerName", SingletonVM.customer.Name);
            ViewData.Add("CustomerEmail", SingletonVM.customer.Email);
            if (ModelState.IsValid)
            {
                SingletonVM.customer = _restBL.GetSingleCustomer(p_customerVM.Name, p_customerVM.Email);
                return RedirectToAction(nameof(WelcomePage));


            }
            return View();
        }

        /*Recently changed below*/
        public ActionResult Login2(int CustomerId) /*Changed this from login to login2 11/13/4pm*/
        {
            return View(new CustomerVM(_restBL.GetCustomerById(CustomerId)));


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










