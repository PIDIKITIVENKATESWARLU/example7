using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace example_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the brand name");
            string Name=Console.ReadLine();
            Console.WriteLine("enter the shirt1 price");
            int Shirt1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the shirt2 price");
            int Shirt2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the T-shirt1 price");
            int T_shirt1=Convert.ToInt32(Console.ReadLine());
            int total=Shirt1+Shirt2 + T_shirt1;
            float Disc = total / 10;
            float less=total-Disc;
            bool flag=false;
            Console.WriteLine("the brand name is {0}", Name);
            Console.WriteLine("price of the shirt1 is {0}", Shirt1);
            Console.WriteLine("price of the shirt2 is {0}", Shirt2);
            Console.WriteLine("price of the T_shirt is {0}", T_shirt1);
            Console.WriteLine("total price of the shirts are {0}",total);
            Console.WriteLine("discount of the shirts is {0}",Disc);
            Console.WriteLine("final price of the shirts are {0}",less);
            Console.WriteLine(flag);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("venky");
            Console.ReadLine();



        }
    }
}
