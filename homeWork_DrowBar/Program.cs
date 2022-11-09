using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_DrowBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xBar;
            int yBar;
            int procentBar;

            Console.Write("Введите процент заполнености бара: ");
            procentBar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x позицию бара: ");
            xBar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y позицию бара: ");
            yBar = Convert.ToInt32(Console.ReadLine());
   
            DrowBar(procentBar, xBar, yBar);
            Console.ReadLine(); 
            
        }

        static void DrowBar(int valueBar, int xBar,int yBar) 
        {
            Console.SetCursorPosition(yBar, xBar);
            int maxBar = 10;
            int countCells = valueBar / maxBar;

            Console.Write("[");

            for (int i = 1; i <= maxBar; i++) 
            {
                if (i <= countCells)
                {
                    Console.Write("#");
                }
                else 
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine("]");
        }
    }
}
