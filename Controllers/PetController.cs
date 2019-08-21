using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.Services;

namespace PetShop.Controllers
{
    public class PetController : Controller
    {
        private readonly IPet Pet;
        public PetController(IPet _Pet)
        {
            Pet = _Pet;    
        }
        public IActionResult Index()
        {
            return View(Pet.GetPets);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //commented
        [HttpPost]
        public IActionResult Create(Pet model)
        {
            if (ModelState.IsValid)
            {
                Pet.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Pet model=Pet.GetPet(Id);
                return View(model);
            }
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            Pet.Remove(Id);
            return RedirectToAction("Index");
        }

    }
}