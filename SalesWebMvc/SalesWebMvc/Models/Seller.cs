using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} required")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Display(Name ="Bith Date")]//ao inves de imprimir o nome da variavel, impressao personalizada
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd//MM/yyyy}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Range(100.0,5000.0, ErrorMessage ="{0} must be from {1} to {2}")]
        [Required(ErrorMessage = "{0} required")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }
        public Seller( string name, string email, DateTime birthday, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            Birthday = birthday;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(d => d.Date >= initial && d.Date <= final).Sum(sr => sr.Amount);
        }
    }
}

