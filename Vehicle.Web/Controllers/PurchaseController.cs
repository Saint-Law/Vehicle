using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Core.ViewModels;
using Vehicle.Data.Interface;
using Vehicle.Data.Models;

namespace Vehicle.Web.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IPurchaseRepository purchaseRepo;
        //private readonly IBodyTypeRepository bodyTypeRepo;
        //private readonly IVehicleDetailsRepository vehicleDetailsRepo;
        private readonly IMapper mapper;

        public PurchaseController(IPurchaseRepository _purchase, IMapper _mapper)
        {
            purchaseRepo = _purchase;
            mapper = _mapper;
        }

        public async Task<ActionResult> Index()
        {
            var purch = await purchaseRepo.FindAll();
            var collection = mapper.Map<List<Purchase>, List<PurchaseVM>>(purch.ToList());
            return View(collection);
        }

        // GET: LoginController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var isExist = await purchaseRepo.isExist(id);
            if (!isExist)
            {
                return NotFound();
            }

            var purch = await purchaseRepo.FindById(id);
            var collection = mapper.Map<PurchaseVM>(purch);
            return View(collection);
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {           
            return View();         
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PurchaseVM collection)
        {
            try
            {
                //TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(collection);
                }

                var purch = mapper.Map<Purchase>(collection);
                purch.DateCreated = DateTime.Now;

                var isSuccess = await purchaseRepo.Create(purch);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong....");
                    return View(collection);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something Went Wrong....");
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var isExist = await purchaseRepo.isExist(id);
            if (!isExist)
            {
                return NotFound();
            }
            var purch = await purchaseRepo.FindById(id);
            var collection = mapper.Map<PurchaseVM>(purch);
            return View(collection);
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PurchaseVM collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(collection);
                }
                var purch = mapper.Map<Purchase>(collection);
                var isSuccess = await purchaseRepo.Update(purch);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong...");
                    return View(collection);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something Went Wrong...");
                return View(collection);
            }
        }

        // GET: LoginController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            //checking if there is any record for that particular Id
            var purch = await purchaseRepo.FindById(id);
            if (purch == null)
            {
                return NotFound();
            }

            var isSuccess = await purchaseRepo.Delete(purch);
            if (!isSuccess)
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PurchaseVM collection)
        {
            try
            {
                //TODO: Add delete logic here 
                var purch = await purchaseRepo.FindById(id);
                if (purch == null)
                {
                    return NotFound();
                }
                var isSuccess = await purchaseRepo.Delete(purch);
                if (!isSuccess)
                {
                    return BadRequest();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }
    }
}
