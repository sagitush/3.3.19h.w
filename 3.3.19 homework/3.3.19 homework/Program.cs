using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._19_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            { new Customer (5,"noam",2009,"pt",7,70),
              new Customer(2,"shir",2012,"pt",5,100),
            new Customer(8,"itamar",1985,"pt",2,90)};
            MyQueue myQueue = new MyQueue();
            myQueue.Init(customers);
            Customer c = myQueue.DequeueProtectzia();
            Console.WriteLine(c);
            List<Customer> d = new List<Customer>();

            d=myQueue.DequeueCustomers(2);
            Customer v = myQueue.DequeueProtectzia();
            Console.WriteLine(v);
        }
    }
}
