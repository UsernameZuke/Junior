using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThreeWeeksInParadise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int allPictures = 52;
            Console.WriteLine("Получится полных рядов картинок:    " + allPictures / picturesInRow);
            Console.WriteLine("Останется картинок в неполном ряду: " + allPictures % picturesInRow);
            Console.ReadKey();
        }
    }
}
