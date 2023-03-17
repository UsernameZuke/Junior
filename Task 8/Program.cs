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
            int queueLengthInPlaces;
            int dividorForHour = 60;
            int receptionTime = 10;
            int waitingTime;
            int hoursInQueue;
            int minutesInQueue;
            bool isSelectedAnswer = false;

            Console.Clear();
            Console.WriteLine("Глава 7: Поликлинника \n");
            Console.WriteLine("Открыв двери местной поликлинники, перед Вами предстает длинный корридор.");
            Console.WriteLine("Корридор уходит в одну и в другую сторону. Вспомнив, что Вам нужен 5-ый кабинет, направляетесь в ту сторону.");
            Console.WriteLine("Подходя, Вы обнаруживаете что не один такой, и надо бы занять очередь.");
            Console.Write("Оценив обстановку, Вы видите, что перед вами очередь человек так из ");
            queueLengthInPlaces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Рассматривая объявления на двери кабинета, Вам попадается одно, на котором указано время приема. И оно составляет 10 мин.");
            waitingTime = queueLengthInPlaces * receptionTime;
            hoursInQueue = waitingTime / dividorForHour;
            minutesInQueue = waitingTime % dividorForHour;
            Console.WriteLine($"Произведя не хитрые вычисления, становится понятно, что свою очередь придется ждать {hoursInQueue} ч. {minutesInQueue} мин.\n");
            Console.WriteLine("Ваши действия? \n");
            Console.WriteLine("1) Просто ждать своей очереди.");
            Console.WriteLine("2) Пойти прогуляться или занять место в другой очереди.");
            Console.WriteLine("3) Попробовать сжульничать.\n");
            ConsoleKeyInfo key = Console.ReadKey();

            while (isSelectedAnswer == false)
            {
                switch (key.KeyChar)
                {
                    case '1':
                        Console.WriteLine(") Вы решили никуда не ходить и ничего не делать. Просто ждать своей очереди.");
                        isSelectedAnswer = true;
                        break;
                    case '2':
                        Console.WriteLine(") Так как до приема еще есть время, Вы решили прогуляться.");
                        isSelectedAnswer = true;
                        break;
                    case '3':
                        Console.WriteLine(") Хитро озираясь по сторонам, Вы аккуратно достаете кристалл из прошлого задания. Что-то начинаете бормотать...");
                        Console.WriteLine("Как вдруг!\n");
                        isSelectedAnswer = true;
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("FATAL ERROR!");
                        Console.WriteLine("This is for God mode only");
                        Console.WriteLine("Please reboot your system and try again");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
