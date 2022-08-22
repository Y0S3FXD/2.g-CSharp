using System.Drawing;
static void ShowSpinner()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(100);
        }
    }
    ShowSpinner();
    Console.Write("spinner has finshed write something to go next");
    Console.ReadLine();
     static void MultiLineAnimation()
    {
        var counter = 0;
        for (int i = 0; i < 30; i++)
        {
            Console.Clear();

            switch (counter % 4)
            {
                case 0: {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║    │││ \\   ║");
                        Console.WriteLine("║    │││  O  ║");
                        Console.WriteLine("║    OOO     ║");
                        break;
                    };
                case 1:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    OOOO    ║");
                        break;
                    };
                case 2:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║   / │││    ║");
                        Console.WriteLine("║  O  │││    ║");
                        Console.WriteLine("║     OOO    ║");
                        break;
                    };
                case 3:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    OOOO    ║");
                        break;
                    };
            }
                
            counter++;
            Thread.Sleep(200);
        }
    }
MultiLineAnimation();
Console.Write("Line animation has finshed now write something again to go next:  ");
Console.ReadLine();
 static void ColorfulAnimation()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                Console.Clear();

                // steam
                Console.Write("       . . . . o o o o o o", Color.LightGray);
                for (int s = 0; s < j / 2; s++)
                {
                    Console.Write(" o", Color.LightGray);
                }
                Console.WriteLine();

                var margin = "".PadLeft(j);
                Console.WriteLine(margin + "                _____      o", Color.LightGray);
                Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);
                    if (j < 4)
                    {
                        Console.WriteLine("we did it bitch");
                    }
                Thread.Sleep(200);
            }
        }
    }
    ColorfulAnimation();

