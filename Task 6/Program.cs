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
            int numberOfRows = allPictures / picturesInRow;
            int restOfPictures = allPictures % picturesInRow;
            Console.WriteLine("Получится полных рядов картинок:    " + numberOfRows);
            Console.WriteLine("Останется картинок в неполном ряду: " + restOfPictures);
            Console.ReadKey();
        }
    }
}
