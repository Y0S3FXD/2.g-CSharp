//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

#region Variables
Console.WriteLine("Hello alien \nWhat is your galaxy name?");

//<Type> <Name> = <Value> ;
string Name;

//Reading a string from the console
Name = Console.ReadLine();
Thread.Sleep(1000);
//Writing it back to the console
Console.WriteLine("hahahahahaaa, welcome " + Name + ", its great to meet you man!");
Thread.Sleep(2000);

#endregion

Console.WriteLine("Do you want to know what humanbeings have done to this earth?");
Thread.Sleep(2000);
Console.WriteLine("I dont think you can write english, You can Use Arrows To move arround");
Thread.Sleep(2000);
Console.WriteLine("Press upwards arrow ↑ For Yes \nPress Downwards ↓ arrow for no");
/*
* There are many different data types which can be explored in the Microsoft C# documentation, see link below.
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
*/
string upar = "Press UpArrow ↑";
string downar = "Press Downarrow ↓";
string rightar = "Press Rightarrow →";
string leftar = "Press Leftarrow ←";

#region storytelling1
if (Console.ReadKey().Key == ConsoleKey.UpArrow)
{
    Console.WriteLine("im glad you wanna listen to this!");
    Thread.Sleep(500);
    Console.WriteLine("Im just wondering what generation you wanna hear about?\n1.Gen " + upar + " \n2.Gen " + downar + " \n3.Gen "
    + rightar + "\n4.Gen =" + leftar);
/*

if (Console.ReadKey().Key == ConsoleKey.UpArrow)
{
    Console.WriteLine("im glad you wanna listen to this!");
    Thread.Sleep(500);
    Console.WriteLine("Im just wondering what generation you wanna hear about?\n1.Gen " + upar + " \n2.Gen " + downar + " \n3.Gen "
    + rightar + "\n4.Gen =" + leftar);
    Thread.Sleep(500);
    if (Console.ReadKey().Key == ConsoleKey.UpArrow)
    {
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
            }
            else
            {
                Thread.Sleep(5000);
                Console.WriteLine(apologizemsg);
                Thread.Sleep(2000);
                Console.WriteLine("The Rest of the story");
            }
        }
    }
}
if (Console.ReadKey().Key == ConsoleKey.DownArrow)
{
    Thread.Sleep(1000);
    Console.WriteLine("Welcome to Gen.2 This is the funniest Gen because here you can play with  ")
}
*/
var Keychose = Console.ReadKey();
Random rnd = new Random();

switch (Keychose.Key)
{
    case ConsoleKey.UpArrow:
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
        Console.WriteLine("Well" + Name + "Welcome to Gen 2, This is an exciting generation, because here The  \"X man Game\" Was invented, So get ready to try it out");
        string[] Herosname = new string[] {"Sokolala", "Bomshakalaka", "Tsikolima", "kosko"};
        int indx = rnd.Next(Herosname.Length);
        Console.WriteLine($"Name: {Herosname[indx]}"); 
        break;
    case ConsoleKey.RightArrow:
    case ConsoleKey.LeftArrow:
        break;
}
#endregion