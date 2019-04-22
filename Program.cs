using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Enter Length:");
                string lInput = Console.ReadLine();
                int length = int.Parse(lInput);

                Console.WriteLine("Enter Width:");
                string wInput = Console.ReadLine();
                int width = int.Parse(wInput);

                Console.WriteLine("Enter Height:");
                string hInput = Console.ReadLine();
                int height = int.Parse(hInput);

                double area = (length * width);
                Console.WriteLine("Area:" + area);

                double perimeter = (2 * (length + width));
                Console.WriteLine("Perimeter:" + perimeter);

                double volume = (length * width * height);
                Console.WriteLine("Volume :" + volume);

                Console.WriteLine("Do you want to continue? (Y/N)");
                string answer = Console.ReadLine();

                if (answer == "N")
                break;
                                
            }
        

        }
    }
}
