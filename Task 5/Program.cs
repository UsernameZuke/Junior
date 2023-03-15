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
            string temp;
            string firstName = "Витко";
            string lastName = "Алексей";
            Console.WriteLine(firstName + " " + lastName);
            temp = firstName;
            firstName = lastName;
            lastName = temp;
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
