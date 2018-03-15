using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //BMI = 體重(公斤) / 身高2(公尺2)

            double BMI;

            Console.Write("體重 : ");
            string wei = Console.ReadLine();
            Console.Write("身高 : ");
            string hei = Console.ReadLine();
            BMI = double.Parse(wei) / (double.Parse(hei) * double.Parse(hei))*10000;
            Console.WriteLine(BMI);
            if (BMI < 16.5 || BMI>31.5)
            {
                Console.Write("免兵");
            }
           else 
            {
                Console.Write("去當兵");

            }
            Console.ReadLine(); 

            
        }
    }
}
