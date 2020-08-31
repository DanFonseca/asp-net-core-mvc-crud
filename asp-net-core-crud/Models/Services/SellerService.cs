using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_core_crud.Data;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_crud.Models.Services
{
    public class SellerService 
    {
        private readonly asp_net_core_crudContext _context;

        public SellerService(asp_net_core_crudContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void insert (Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
