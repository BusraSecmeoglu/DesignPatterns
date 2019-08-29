using StatePattern.Classes;
using StatePattern.Enums;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMessageProvider changeMessageProvider = new ChangeMessageProvider();

            Console.WriteLine("Türkçe için 1, İngilizce için 2'ye basınız. \n for Turkhish 1, for English 2 press please.");

            var a = Console.ReadKey().KeyChar.ToString();


            string ChangeMessage = changeMessageProvider.SetLanguage(int.Parse(a));

            Console.WriteLine(ChangeMessage);

            var b = Console.ReadKey().KeyChar.ToString();

            string message = changeMessageProvider.SetLanguage(int.Parse(a), int.Parse(b));
            
            Console.WriteLine(message);
        }
    }
}
