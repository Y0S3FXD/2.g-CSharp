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
Console.WriteLine("I dont think you can write english, \nPress upwards arrow ↑ For Yes \nPress Downwards ↓ arrow for no");
/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*
* Programmers use these different types to better communicate their thoughts and optimize the program
* C# have, at the time of writing; 10 different types of numbers, choosing the right ones can be key to your objective.
*
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
    Console.WriteLine("Im just wondering what generation you wanna hear about?\n 1.Gen " + upar + " \n2.Gen " + downar + " \n3.Gen "
    + rightar + "\n4.Gen =" + leftar);
    Thread.Sleep(500);
    if (Console.ReadKey().Key == ConsoleKey.UpArrow)
    {
        Console.WriteLine("Well," + Name + " Welcome to Generation 1");
        Thread.Sleep(300);
        Console.WriteLine("Ur father, fathers, fathers's, fathers'ss was a good man for what he did :) \n i wish that you agree \n Yes"
         + upar + "\n No" + downar);
        if (Console.ReadKey().Key == ConsoleKey.UpArrow)
        {
            Console.WriteLine("Im so glad to hear that buddy");
            Thread.Sleep(1000);
            Console.WriteLine("Give me a minute im crying ;( ");
            string apologizemsg = "ok im sorry for the waiting, Dont go away ";
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {

                Console.WriteLine(apologizemsg);
                Thread.Sleep(400);
                Console.WriteLine("The Rest of the story");
            }
            else
            {
                Thread.Sleep(10000);
                Console.WriteLine(apologizemsg);
                Thread.Sleep(1000);
                Console.WriteLine("The Rest of the story");
            }
        }
        Console.WriteLine("The Rest of the story");
        Console.WriteLine("...");
        Console.ReadLine();

    }
}

Console.WriteLine("The end");
#endregion