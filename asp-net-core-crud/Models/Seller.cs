using System;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core_crud.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Double BaseSalary { get; set; }

        public Department Department { get; set; }

        //Foreign Key de Departament
        public int DepartmentId { get; set; } 

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller(int id, string name, string email, DateTime birthDate,
            double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Seller()
        {
        }

        public void AddSeller(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSeller (SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public Double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final)
                .Sum(sr => sr.Amount);
        }
    }
}
