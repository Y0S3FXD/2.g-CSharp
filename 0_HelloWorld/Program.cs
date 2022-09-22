using System;
using System.Reflection.PortableExecutable;
Random rnd = new Random();

 
Console.WriteLine("Hello alien \nWhat is your galaxy name?");

string Name;

Name = Console.ReadLine();
Thread.Sleep(1000);
Console.WriteLine("hahahahahaaa, welcome " + Name + ", its great to meet you man!");
Thread.Sleep(2000);

 

Console.WriteLine("Do you want to know what humanbeings have done to this earth?");
Thread.Sleep(2000);
Console.WriteLine("I dont think you can write english, You can Use Arrows To move arround");
Thread.Sleep(2000);
Console.WriteLine("Press upwards arrow ↑ For Yes \nPress Downwards ↓ arrow for no");

string upar = "Press UpArrow ↑";
string downar = "Press Downarrow ↓";
string rightar = "Press Rightarrow →";
string leftar = "Press Leftarrow ←";

 
if (Console.ReadKey().Key == ConsoleKey.UpArrow)
{
    Console.WriteLine("im glad you wanna listen!");
    Thread.Sleep(500);
    Console.WriteLine("Im just wondering what generation you wanna hear about?\n1.Gen " + upar + " \n2.Gen " + downar + " \n3.Gen "
    + rightar + "\n4.Gen =" + leftar);
}
void Move(ConsoleKey direction)
{
    switch (direction)
    {
        case ConsoleKey.UpArrow:
        case ConsoleKey.W:
            Console.WriteLine("Well," + Name + " Welcome to Generation 1");
            Thread.Sleep(500);
            Console.WriteLine("Ur father, fathers, fathers's, fathers'ss was a good man for what he did :) \ni wish that you agree \nYes"
             + upar + "\nNo" + downar);
            if (Console.ReadKey().Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Im so glad to hear that buddy");
                Thread.Sleep(1000);
                Console.WriteLine("Give me a minute im crying ;( ");
                string apologizemsg = "ok im sorry for the waiting, Dont go away ";
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(apologizemsg);
                    Thread.Sleep(1300);
                    Console.WriteLine("The Rest of the story");
                    Console.ReadKey();
                }
            }

            break;
        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            Console.WriteLine("Well" + Name + "Welcome to Gen 2, This is an exciting generation, \nbecause here The  \"Mortal Combat\" Was invented, So get ready to try it out");
            string[] Herosname = new string[] { "Sokolala", "Bomshakalaka", "Tsikolima", "kosko", "morow", "shikololo", "sexy lady" };
            int indx = rnd.Next(Herosname.Length);
            Thread.Sleep(1000);
            Console.WriteLine($"Your Hero Name: {Herosname[indx]}" + "He did so much in the old time");
            Thread.Sleep(1000);
            int tell = 0;
            int speed = 50;
            for (int i = 0; speed < 350; i++)
            {

                tell++;
                if (tell == 4)
                {
                    tell = 0;
                }
                int add = 10;
                speed = speed + add;
                Thread.Sleep(speed);
                Console.Clear();
                Console.Write(Herosname[tell]);

            }
            string Ally = Herosname[indx];
            string enemy = Herosname[tell];
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("its going to be " + Ally + " Versus " + enemy);
            Thread.Sleep(500);
            Console.WriteLine("Good luck :)");
            Console.ReadKey();
            break;
        case ConsoleKey.RightArrow:
        case ConsoleKey.LeftArrow:
            break;
        default:
            Console.WriteLine("Something is wrong, we are in default case we should be in somewhere else");
            Console.ReadKey();
            break;
    }
}

var _key = Console.ReadKey().Key;
Move(_key);


Console.WriteLine("I hope you had some fun :) ");