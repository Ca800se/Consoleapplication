using System;
using System.Data;
using DecBinConverter; 

namespace Tipis6Lr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите способ ввода данных:");
            Console.WriteLine("1 - Ввести данные вручную");
            Console.WriteLine("2 - Автоматическое заполнение");
            Console.Write("Ваш выбор (1 или 2): ");
            string vibor = Console.ReadLine();

            if (vibor == "1")
            {
                Console.WriteLine("Преобразователь единиц веса \n");

                Console.WriteLine("--- Конвертация фунтов и килограммов ---\n");
                Console.WriteLine ("Введите вес в фунтах : ");
                string funt = Console.ReadLine();
                if (double.TryParse(funt, out double pounds))
                {
                    double kgFromPounds = WeightConverter.ConvertPoundsToKg(pounds);
                    Console.WriteLine($"{pounds} фунт или фунтов = {kgFromPounds:F4} кг");
                }
                else
                {
                    Console.WriteLine("Введите корректное число!");
                }
               
                Console.WriteLine("--- Конвертация аптекарских унций и граммов ---\n");
                Console.WriteLine("Введите аптекарскую унцию : ");
                string ynci = Console.ReadLine();
                if(double.TryParse(ynci, out double apothecaryOunces))
                {
                    double gramsFromOunces = WeightConverter.ConvertApothecaryOuncesToGrams(apothecaryOunces);
                    Console.WriteLine($"{apothecaryOunces} апт. унц. = {gramsFromOunces:F4} г");
                }
                else
                {
                    Console.WriteLine("Введитте корректное число!");
                }


                Console.WriteLine("--- Конвертация килограммов и слагов ---\n");
                Console.WriteLine("Введите килограммы : ");
                string kg = Console.ReadLine();
                if(double.TryParse(kg, out double kgToSlug))
                {
                    double slugs = WeightConverter.ConvertKgToSlugs(kgToSlug);
                    Console.WriteLine($"{kgToSlug} кг = {slugs:F4} слаг(ов)");
                }
                else
                {
                    Console.WriteLine("Введите корректное числов!");

                }

                Console.WriteLine("--- Нажмите любую клавишу для выхода ---");
            }
            else if (vibor == "2")
            {
                Console.WriteLine("Преобразователь единиц веса \n");

                Console.WriteLine("--- Конвертация фунтов и килограммов ---\n");
                double pounds = 1;
                double kgFromPounds = WeightConverter.ConvertPoundsToKg(pounds);
                Console.WriteLine($"{pounds} фунт(ов) = {kgFromPounds:F4} кг");



                Console.WriteLine("--- Конвертация аптекарских унций и граммов ---");
                double apothecaryOunces = 1;
                double gramsFromOunces = WeightConverter.ConvertApothecaryOuncesToGrams(apothecaryOunces);
                Console.WriteLine($"{apothecaryOunces} апт. унц. = {gramsFromOunces:F4} г");



                Console.WriteLine("--- Конвертация килограммов и слагов ---");
                double kgToSlug = 1;
                double slugs = WeightConverter.ConvertKgToSlugs(kgToSlug);
                Console.WriteLine($"{kgToSlug} кг = {slugs:F4} слаг(ов)");


                Console.WriteLine(" --- Нажмите любую клавишу для выхода ---");
            }
            else
            {
                Console.WriteLine("Ошибка: введите 1 или 2.");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}