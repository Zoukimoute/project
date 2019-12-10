using E_BusinessGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SQLManager.GetPanier<Program>(1));
            Console.Read();
        }
    }
}
