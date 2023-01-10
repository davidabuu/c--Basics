using System;
using Helloworld.Models;

namespace Helloworld // Note: actual namespace depends on the project name.
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard = "Z680",
                hasWifi = true,
                hasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 953.89m,
                videoCard = "rr55"
            };
            Console.WriteLine(myComputer.hasLTE);
        }
        
    }
}