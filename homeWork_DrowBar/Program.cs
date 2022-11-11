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
            int xBarPosition;
            int yBarPosition;
            int procentBar;            

            Console.Write("Введите процент заполнености бара: ");
            procentBar = Convert.ToInt32(Console.ReadLine());

            if (procentBar < 0)
            {
                procentBar = 0;
            }
            else if (procentBar > 100)
            {
                procentBar = 100;
            }

            Console.Write("Введите x позицию бара: ");
            xBarPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y позицию бара: ");
            yBarPosition = Convert.ToInt32(Console.ReadLine());
   
            DrowBar(procentBar, xBarPosition, yBarPosition);
            Console.ReadLine();             
        }

        static void DrowBar(int valueBar, int xBarPosition,int yBarPosition) 
        {
            Console.SetCursorPosition(yBarPosition, xBarPosition);
            int maxBar = 10;
            int countCells = valueBar * maxBar / 100;
            string bar = "";

            for (int i = 0; i < countCells; i++)
            {
                bar += '#';
            }

            for (int i = countCells; i < maxBar; i++)
            {
                bar += '_';
            }

            Console.WriteLine($"[{bar}]");
        }
    }
}
