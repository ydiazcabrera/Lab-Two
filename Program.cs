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
                decimal length = decimal.Parse(lInput);

                Console.WriteLine("Enter Width:");
                string wInput = Console.ReadLine();
                decimal width = decimal.Parse(wInput);

                Console.WriteLine("Enter Height:");
                string hInput = Console.ReadLine();
                decimal height = decimal.Parse(hInput);

                decimal area = (length * width);
                Console.WriteLine("Area:" + area);

                decimal perimeter = (2 * (length + width));
                Console.WriteLine("Perimeter:" + perimeter);

                decimal volume = (length * width * height);
                Console.WriteLine("Volume :" + volume);

                Console.WriteLine("Do you want to continue? (Y/N)");
                string answer = Console.ReadLine();

                if (answer == "N")
                break;
                                
            }
                    
        }
    }
}
