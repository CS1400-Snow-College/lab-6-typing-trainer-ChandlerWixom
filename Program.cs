// Chandler Wixom, 3/12/2025, Lab 6 Typing Trainer 
using System.Diagnostics;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine("Hello, this program is a typing trainer.You will be given a random set of lines and your job is to type it out as fast and accuratly as posible.\n\tPress any key to start...");
Stopwatch stopwatch = new Stopwatch(); // creates a stopwatch
Console.ReadKey(true);
Console.Clear();


string[] sentances = new string[5];
sentances[0] = "Gloinks are small mischievous critters that steal anything and everything they run into!\nWhy do these humanoid hash-browns do this? How do you stop them?\nThat's for you to find out. Now, good luck, and have fun, my little superstars!";
sentances[1] = "Ah, biscuits! I'm sorry, I ruined your card game, then made you have an awkward moment with your dad.";
sentances[2] = "As they say in russian... Whoops, I should have predicted that someone could escape out of a ventilation shaft using discarded mirrors as stairs.";
sentances[3] = "Oh God! What have I done? I've set all my notes and books and stuff on fire and now I can't study for my exams...\nI'll flunk out and my folks'll be pissed off as hell... I'll get a blanket... the blanket's on fire.\nWe'd better call the fire department.";
sentances[4] = "I see the hard facts of life! I am realistic, something you're incapable of!\nYou'd be better off with one of those stupid little morons like Charlene who you could just sleep with and throw away when you're done!\nYou can't cope with a mature woman!";

Random rand = new Random();
int which = rand.Next(0, 5); // creates a random a selects one of the sentances to be used
Console.Write(sentances[which]);
Console.SetCursorPosition(0, 0);
stopwatch.Start();

int missedKeys = 0;
for (int i = 0; i < sentances[which].Length; i++) // goes through all char in the string 
{
    var tempkey = Console.ReadKey(true).KeyChar; // reads the key without writeing it but it saves the key

    if (tempkey == sentances[which][i]) // if the key is acurate then its writes it in green
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(sentances[which][i]);
        Console.ForegroundColor = ConsoleColor.White;

    }
    else // if the key isnt accurate then it writes it in red and adds to the missed counter
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(sentances[which][i]);
        Console.ForegroundColor = ConsoleColor.White;
        if (sentances[which][i] != Convert.ToChar("\n")) // i have litteraly no clue how to write \n as a char??? but his helps prevent false misses lol iduno
        {
            missedKeys++;
        }
    }


}
stopwatch.Stop();
double timeSpent = stopwatch.ElapsedMilliseconds / 1000; // turns stopwatch time into seconds not milliseconds

double acuracy = 100 / (double)sentances[which].Length * (sentances[which].Length - (double)missedKeys);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine($"You missed {missedKeys} of {sentances[which].Length} keys.\tGiving you an acuracy of {acuracy:00.00}%.");
Console.Write($"That took you {timeSpent} seconds.");

//This counts the words in the sentance then finds the words per minute
int Words = sentances[which].Split().Length;
double timeSeconds = stopwatch.ElapsedMilliseconds / 1000;
double wpm = Words / timeSeconds * 60;
Console.WriteLine($"\tWords Per Minutes {wpm:00}");
