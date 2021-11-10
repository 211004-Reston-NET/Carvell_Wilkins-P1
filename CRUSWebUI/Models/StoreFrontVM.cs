using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUSModels;

namespace CRUSWebUI.Models
{
    public class StoreFrontVM
    {
        public StoreFrontVM()
        {

        }
        public StoreFrontVM(StoreFront p_rest)
        {
            
            this.Name = p_rest.Name;
            this.Description = p_rest.Description;
            this.Address = p_rest.Address;
            this.StoreFrontId = p_rest.StoreFrontId;
        }
        public int StoreFrontId {get; set;}
        public string Name { get; set; }
        public String Description { get; set; }
        public string Address { get; set; }
    }
}
    



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using CRUSModels;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

// namespace CRUSWebUI.Models
// {
//     public class StoreFrontVM : Controller
//     {
//         public StoreFrontVM(StoreFront rest)
//         {
//             Rest = rest;
//         }

//         public StoreFront Rest { get; }

//         // GET: StoreFrontVM
//         public ActionResult Index()
//         {
//             return View();
//         }

//         // GET: StoreFrontVM/Details/5
//         public ActionResult Details(int id)
//         {
//             return View();
//         }

//         // GET: StoreFrontVM/Create
//         public ActionResult Create()
//         {
//             return View();
//         }

//         // POST: StoreFrontVM/Create
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Create(IFormCollection collection)
//         {
//             try
//             {
//                 return RedirectToAction(nameof(Index));
//             }
//             catch
//             {
//                 return View();
//             }
//         }

//         // GET: StoreFrontVM/Edit/5
//         public ActionResult Edit(int id)
//         {
//             return View();
//         }

//         // POST: StoreFrontVM/Edit/5
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Edit(int id, IFormCollection collection)
//         {
//             try
//             {
//                 return RedirectToAction(nameof(Index));
//             }
//             catch
//             {
//                 return View();
//             }
//         }

//         // GET: StoreFrontVM/Delete/5
//         public ActionResult Delete(int id)
//         {
//             return View();
//         }

//         // POST: StoreFrontVM/Delete/5
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Delete(int id, IFormCollection collection)
//         {
//             try
//             {
//                 return RedirectToAction(nameof(Index));
//             }
//             catch
//             {
//                 return View();
//             }
//         }
//     }
// }
