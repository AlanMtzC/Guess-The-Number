using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randomNumber = GenerateNumber(1, 101);
                int counter = 1;
                while (true)
                {
                    Console.Write("introduce un numero entre 1 y 100 (0 para quitar)");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                        return;
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("muy bajo, intenta de nuevo");
                        ++counter;
                        continue;
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("muy alto, intenta de nuevo");
                        ++counter;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("acertaste, el numero es {0}!", randomNumber);
                        if (counter == 1)
                            Console.WriteLine("y lo adivinaste de volada, punto bonus auuuu\n");
                        else
                            Console.WriteLine("te tomó {0} {1}.\n", counter, counter == 1 ? "intenta" : "intentos");
                        break;         
                    }
                }
            }

        }
        static int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max); 
        }
    }
}