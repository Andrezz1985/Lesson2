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
            Console.Write("Введите цифру, обозначающую день недели: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            void CheckingTheDayOfTheWeek (int Number) {
            if (Number == 6 || Number == 7) {
                Console.WriteLine("Да");
            }
            else if (Number < 1 || Number > 7) {
                Console.WriteLine("Такого дня недели не существует");
             }
            else Console.WriteLine("Нет");
            }

            CheckingTheDayOfTheWeek(Number);

        }
    }
}