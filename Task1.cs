using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Введи трёхзначное число: ");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            string stringNumber = Convert.ToString(threeDigitNumber);
            Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


        }
    }
}