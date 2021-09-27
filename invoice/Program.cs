using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(0999, "andrey", "vadim ");
            invoice.Quantity = 9;
            invoice.Information();

            Console.ReadKey();
        }
    }
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }
        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void NDS(double nds)
        {
            double result1 = account * (1 - nds / 100.0);
            result1 *= quantity;
            Console.WriteLine($"With NDS = {result1}");

        }
        public void WithOutNds()
        {
            double result2 = account * quantity;
            Console.WriteLine($"Without NDS = {result2}");
        }
        public void Information()
        {
            Console.WriteLine($"Customer - {customer}, Provider - {provider}, Sum - {account}");
            NDS(0.2);
            WithOutNds();
        }

    }
}
