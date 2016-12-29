using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmassTree
{
    class XmassTree
    {
        private bool adj = false;
        private int dim;
        public XmassTree(int s)
        {
            dim = s % 2 == 1 ? s : s + 1;

        }

        public void draw()
        {
            
            int p = dim * 2 - 1;
            Random random = new Random();
            for (int j = 0; j < dim; j++)
            {
                for (int i = 0; i < p; i++)
                {
                    if (i >= dim - j && i < p - dim + j)
                    {
                        if (random.Next() % 100 < 85 || adj ||i==dim-j || i>p-dim+j-2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(random.Next()%100>50?"<":">");
                            adj = false;
                        }
                        else if (random.Next() % 100 > 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("(0)");
                            i = i + 2;
                            adj = true;
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("(0)");
                            i = i + 2;
                            adj = true;

                        }
                    }
                    else if (j == 0 && i==p/2-1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("(#)");
                        i = i + 2;
                    }
                    else
                    {
                        if (random.Next() % 100 < 70 ||adj)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" ");
                            adj = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("*");
                            adj = true;
                        }
                        
                    }

                }
              
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            adj = false;
            for (int j = 0; j < dim/10+1; j++)
            {

                for (int i = 0; i < p; i++)
                {
                    if (i >= dim - 2 && i < p - dim + 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("H");
                    }
                    else
                    {
                        if ((random.Next() % 100 < 85) || adj)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            adj = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("*");
                            adj = true;
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
