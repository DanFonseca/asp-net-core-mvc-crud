using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_core_crud.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Department()
        {
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public Double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(se => se.TotalSales(initial, final));
        }
    }
}
