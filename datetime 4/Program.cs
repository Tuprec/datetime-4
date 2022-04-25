using System;

namespace datetime_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime geboorte = new DateTime();
            DateTime vandaag = new DateTime(2022, 04, 25);
            Console.WriteLine("geef uw verjaardagsdatum: ");
            geboorte = Convert.ToDateTime(Console.ReadLine());

            double aantalD = geboorte.Subtract(vandaag).TotalDays;

            Console.WriteLine($"Er zijn nog {aantalD} tot u jarig bent!!!");

            

        }
    }
}
