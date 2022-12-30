using System;
using System.Threading.Tasks;

namespace PracticeXX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] panel;
            string temp;

            panel = new string[25, 15];
            for(int y = 0; y < panel.GetLength(0); y++)
            {
                for(int x=0; x< panel.GetLength(1); x++)
                {
                    if (x == 0 || y == 0 || x == panel.GetLength(1) - 1 || y == panel.GetLength(0) - 1)
                    {
                        panel[y, x] = "■";
                    }
                    else
                    {
                        panel[y, x] = "  ";

                    }
                }
            }

            for (int y = 0; y < panel.GetLength(0); y++)
            {
                for (int x = 0; x < panel.GetLength(1); x++)
                {
                    Console.Write(panel[y,x]);
                }
                Console.WriteLine();
            }

            panel[0, panel.GetLength(1) / 2] = "★";
            Console.WriteLine(panel[0, panel.GetLength(1) / 2]);

            for (int y = 0; y < panel.GetLength(0); y++)
            {
                for (int x = 0; x < panel.GetLength(1); x++)
                {
                    Console.Write(panel[y, x]);
                }
                Console.WriteLine();
            }

            
                for(int i= 0; i <panel.GetLength(0)-2; i++)
                {
                    
                    temp = panel[i+1, panel.GetLength(1) / 2];
                    panel[i+1, panel.GetLength(1) / 2] = panel[i, panel.GetLength(1) / 2];
                    panel[i, panel.GetLength(1) / 2] = temp;

                    for (int y = 0; y < panel.GetLength(0); y++)
                    {
                        for (int x = 0; x < panel.GetLength(1); x++)
                        {
                            Console.Write(panel[y, x]);
                            
                        }
                        Console.WriteLine();
                    }
                    Task.Delay(200).Wait();
                }


        }
    }
}