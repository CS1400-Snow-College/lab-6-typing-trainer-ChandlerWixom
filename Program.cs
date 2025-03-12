// Chandler Wixom, 3/12/2025, Lab 6 Typing Trainer 
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine("Hello, this program is a typing trainer.You will be given a random set of lines and your job is to type it out as fast and accuratly as posible.\n\tPress any key to start...");
Console.ReadKey(true);
Console.Clear();

string[] sentances = new string[5];
sentances[0] = "Gloinks are small mischievous critters that steal anything and everything they run into!\nWhy do these humanoid hash-browns do this? How do you stop them?\nThat's for you to find out. Now, good luck, and have fun, my little superstars!";
sentances[1] = "Ah, biscuits! I'm sorry, I ruined your card game, then made you have an awkward moment with your dad.";
sentances[2] = "As they say in russian... Whoops, I should have predicted that someone could escape out of a ventilation shaft using discarded mirrors as stairs.";
sentances[3] = "Oh God! What have I done? I've set all my notes and books and stuff on fire and now I can't study for my exams...\nI'll flunk out and my folks'll be pissed off as hell... I'll get a blanket... the blanket's on fire.\nWe'd better call the fire department.";
sentances[4] = "I see the hard facts of life! I am realistic, something you're incapable of!\nYou'd be better off with one of those stupid little morons like Charlene who you could just sleep with and throw away when you're done!\nYou can't cope with a mature woman!";

Random rand = new Random();
int which = rand.Next(0,5);


Console.Write(sentances[which]);
Console.SetCursorPosition(0,0);




for (int i = 0; i < sentances[which].Length; i++)
{
    var tempkey = Console.ReadKey(true).KeyChar;

if (tempkey == sentances[which][i])
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(sentances[which][i]);
    Console.ForegroundColor = ConsoleColor.White;

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(sentances[which][i]);
    Console.ForegroundColor = ConsoleColor.White;
}

   
}

