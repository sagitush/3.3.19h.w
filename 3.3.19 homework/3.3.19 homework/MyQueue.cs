using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._19_homework
{
    class MyQueue
    {
        private List<Customer> customers = new List<Customer>();

        public void Enqueue(Customer customer)
        {
            this.customers.Add(customer);
        }
        public Customer Dequeue()
        {
            if(customers.Count>0)
            {
                Customer result = customers[0];
                this.customers.RemoveAt(0);
                return result;
            }
            return null;
        }
        public void Init(List<Customer> newlist)
        {
            this.customers = newlist;
        }
        public void Clear()
        {
            this.customers.Clear();
        }
        public Customer WholsNext()
        {
            return customers[0];
        }
        public int Count { get
            {
                return this.customers.Count;
            }
        }
        public void SortByProtection()
        {
            this.customers.Sort();
        }
        public void SortByTotalPurchases()
        {
            this.customers.Sort(new CustomerPurchasesComparer());
        }
        public void SortByBirthYear()
        {
            this.customers.Sort(new CustomerBirthYearComparer());
        }
        public List<Customer> DequeueCustomers(int b)
        {
            int index = 0;
            List<Customer> newlist = new List<Customer>();
            while (customers.Count > index && customers.Count < b)
            {
                newlist[index] = this.customers[index];
                this.customers.RemoveAt(index);
                index++;
            }
            return newlist;
        }
        public void AniRakSheela(Customer customer)
        {
            this.customers.Insert(0, customer);
        }
        public Customer DequeueProtectzia()
        {
            int maxProtection = 0;
            int index = 0;
            for (int i = 0; i <this.customers.Count; i++)
            {
                if(this.customers[i].Protection> maxProtection)
                {
                    maxProtection = this.customers[i].Protection;
                    index = i;
                }
            }
            Customer c = this.customers[index];
            this.customers.RemoveAt(index);
            return c;
        }
    }
}
