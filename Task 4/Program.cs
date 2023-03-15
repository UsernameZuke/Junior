using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeWeeksInParadise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividor = 10;
            string name;
            int age;
            string ageWord;
            string zodiacSign;
            string placeOfWork;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возвраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Введите ваше место работы: ");
            placeOfWork = Console.ReadLine();
            int lastNumberInAge = age % dividor;
            if (lastNumberInAge == 1)
            {
                ageWord = "год";
            }
            else if (lastNumberInAge > 1 && lastNumberInAge<5)
            {
                ageWord = "года";
            }
            else
            {
                ageWord = "лет";
            }
            Console.WriteLine($"Вас зовут {name}, вам {age} {ageWord}. Ваш знак зодиака {zodiacSign}. Ваше место работы {placeOfWork}");
        }
    }
}
