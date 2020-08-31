using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_core_crud.Models;
using asp_net_core_crud.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_crud.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
  
            return View(_sellerService.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Seller seller)
        {
            _sellerService.insert(seller);
            return Redirect(nameof (Index));
        }

    }
}
