using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Problem_Points
{
    class Points
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter start points of X and Y (on new lines):");
            int current_x = Convert.ToInt32(Console.ReadLine());
            int current_y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a sequence of arrows:");
            string arrows = Console.ReadLine();
            char[] newArrows = arrows.ToCharArray();

            int counter = 0;
            for (int i = 0; i < newArrows.Length; i++)
            { 
            if (newArrows[i] == '~')
                {
                counter++;
                }
                if (counter % 2 == 0)
                {
                    if (newArrows[i] == '>')
                    {
                        current_x = current_x + 1;
                    }
                    if (newArrows[i] == '<')
                    {
                        current_x = current_x - 1;
                    }
                    if (newArrows[i] == '^')
                    {
                        current_y = current_y - 1;
                    }
                    if (newArrows[i] == 'v')
                    {
                        current_y = current_y + 1;
                    }
                }
                else
                {
                    if (newArrows[i] == '>')
                    {
                        current_x = current_x - 1;
                    }
                    if (newArrows[i] == '<')
                    {
                        current_x = current_x + 1;
                    }
                    if (newArrows[i] == '^')
                    {
                        current_y = current_y + 1;
                    }
                    if (newArrows[i] == 'v')
                    {
                        current_y = current_y - 1;
                    }
                }
            }
            Console.WriteLine("Current X and Y are: {0} and {1}", current_x, current_y);
        }
    }
}
