using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter money = new Converter(33.62, 49.25, 0.41, 6);
            Console.WriteLine(" ");
            Console.WriteLine($"$: {money.Usd1()}, Eur {money.Eur1()}, Rub { money.Rub1()}");
            money.MethodUsd();
            Console.WriteLine(money.MethodUsd());
            Console.ReadKey();
        }
    }
    class Converter
    {
        double hrn;
        public void Hrn(double value)
        {
            hrn = value;
        }
        public double Hrn1()
        {
            return hrn;
        }
        double usd;
        public double Usd1()
        {
            return usd;
        }
        double eur;
        public double Eur1()
        {
            return eur;
        }
        double rub;
        public double Rub1()
        {
            return rub;
        }
        public double nUsd;
        public void SetNUsd(double value)
        {
            nUsd = value;
        }
        public double MethodUsd()
        {
            return nUsd;
        }
        static double MethodUsd(double usd, double hrn, double nUsd)
        {
            nUsd = usd * hrn;
            return nUsd;
        }
        public Converter(double usd, double eur, double rub, double hrn)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            Console.Write("Point :");
            this.hrn = Convert.ToDouble(Console.ReadLine());
        }
    }
}
