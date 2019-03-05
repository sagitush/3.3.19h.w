using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._19_homework
{
    class Customer:IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthYear, string address, int protection, int totalPurchases)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
            TotalPurchases = totalPurchases;
        }

        public override string ToString()
        {
            return $"Customer {Name} ID:{Id},birth year:{BirthYear},adress:{Address},protection:{Protection},total purchases:{TotalPurchases}";
        }

        public int CompareTo(Customer other)
        {
            return this.Protection - other.Protection;
        }
    }
    class CustomerPurchasesComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.TotalPurchases - y.TotalPurchases;
        }
    }
    class CustomerBirthYearComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return (x.BirthYear - y.BirthYear)*-1;
        }
    }

}
