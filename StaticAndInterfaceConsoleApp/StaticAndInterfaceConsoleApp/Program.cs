using StaticAndInterfaceConsoleApp.Models;
using System;

namespace StaticAndInterfaceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User farid = new User("faridmma@code.edu.az", "Farid.mammadov60")
            {               
                Fullname = "Farid Mammadov"
            };
            farid.ShowInfo();
            Console.WriteLine("--------");
            Console.WriteLine(farid);
            Console.WriteLine("--------");
            

            User GS = new User("Galatasaray@tr.com", "Gasay1234567")
            {
                Fullname = "Galatasaray"
            };
            GS.ShowInfo();
            Console.WriteLine("---------");
            Console.WriteLine(GS);
           
        }
    }
}
