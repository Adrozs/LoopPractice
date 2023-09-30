namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Övning 1
            /*Console.WriteLine("Enter a number (0-10) to see it's multiplication table: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(value * i);
            }*/

            // Övning 2
            /* skip pga gjorde i skolan*/

            // Övning 3
            /*Console.WriteLine("Choose a pattern 1, 2, 3 or 4: ");
             int selection = int.Parse(Console.ReadLine());

             Console.WriteLine();

             // selection 1
             if (selection == 1)
             {
                 for (int i = 0; i < 4; i++)
                 {    
                     for (int j = 0; j < i; j++)
                     {

                         Console.Write(j+1);
                     }
                     Console.WriteLine(i+1);
                 }

             }

             // selection 2
             if (selection == 2)
             {
                 for (int i = 0; i < 4; i++)
                 {
                     for (int j = 0; j <= i; j++)
                     {
                         Console.Write("4");

                     }
                     Console.WriteLine();

                 }
             }

             // selection 3
             if (selection == 3)
             {
                 for (int i = 1; i <= 4; i++)
                 {
                     for (int j = 0; j < i; j++)
                     {
                         Console.Write(i);

                     }
                     Console.WriteLine();

                 }
             }

             // selection 4
             if (selection == 4)
             {
                 for (int i = 1; i <= 4; i++)
                 {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                 }
             }
             */

            // Övning 4 (pyramid)
            Console.WriteLine("Choose a pattern 1, 2, 3 or 4: ");
             int selection = int.Parse(Console.ReadLine());

             Console.WriteLine();

             // selection 1
             if (selection == 1)
             {

                    for (int i = 0; i < 4; i++)
                    {
                        for (int s = 4; s > i; s--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(j + 1);
                            Console.Write(" ");
                        }
                    Console.WriteLine(i + 1);
                    }
                

             }

             // selection 2
             if (selection == 2)
             {
                 for (int i = 0; i < 4; i++)
                 {
                    for (int s = 4; s > i; s--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                     {
                         Console.Write("4");
                         Console.Write(" ");

                    }
                     Console.WriteLine();

                 }
             }

            // selection 3
            if (selection == 3)
             {
                 for (int i = 1; i <= 4; i++)
                 {
                    for (int s = 4; s >= i; s--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                     {
                         Console.Write(i);
                         Console.Write(" ");

                    }
                     Console.WriteLine();

                 }
             }

             // selection 4
             if (selection == 4)
             
                 for (int i = 1; i <= 4; i++)
                 {
                    for (int s = 4; s > i; s--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                 }
        }
    }
}