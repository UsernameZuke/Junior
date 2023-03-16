using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThreeWeeksInParadise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal;
            int crystalPrice;
            int totalPrice;
            int minCrystalPrice = 1;
            int maxCrystalPrice;

            Console.Write("Сколько у вас золота? - ");
            gold = Convert.ToInt32(Console.ReadLine());
            maxCrystalPrice = gold + 1;
            crystalPrice = new Random().Next(minCrystalPrice, maxCrystalPrice);
            Console.Clear();
            Console.WriteLine("Магазин кристаллов");
            Console.WriteLine("");
            Console.WriteLine($"Цена за кристалл: {crystalPrice}.    У Вас {gold} золота.");
            Console.Write("Сколько желаете приобрести? - ");
            crystal = Convert.ToInt32(Console.ReadLine());
            totalPrice = crystal * crystalPrice;
            if (totalPrice <= gold)
            {
                Console.WriteLine("Спасибо за покупку!");
                gold -= crystal * crystalPrice;
            }
            else
            {
                Console.WriteLine("У Вас не достаточно средств!");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Инвентарь");
            Console.WriteLine($"Золото:    {gold}.");
            Console.WriteLine($"Кристаллы: {crystal}.");
            Console.ReadKey();
        }
    }
}
