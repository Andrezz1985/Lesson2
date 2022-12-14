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
            Console.Write("Введите число: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            string NumberText = Convert.ToString(Number);
            if (NumberText.Length > 2){
                Console.WriteLine("Третья цифра " + NumberText[2]);
            }
            else {
                Console.WriteLine("третьей цифры нет");
            }

        }
    }
}