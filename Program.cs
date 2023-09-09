// Change the appearance
Console.Title = "dotnet";
// Console.Title = "OPPENHEIMER";
Console.ForegroundColor = ConsoleColor.Gray;

// Console.WriteLine("Hello, whatcha ur name? ");
// Console.ReadLine();

// Console.WriteLine("Im Death.\nThe destroyer of the world.");

// Console.WriteLine("What's ur superpower ?");
// Console.ReadLine();

// Console.WriteLine("Cool! Mine is destruction.");
// Console.ReadKey();

// Console.WriteLine("You have to get what you want ...");
// Console.ReadLine();

// Console.WriteLine("Intelligence is a very valuable thing, innit, my friend?...");
// Console.ReadLine();

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("There's only one thing that can blind a man as smart as you, Tommy. Love");
// Console.ReadLine();

// VARIABLES -------------------------------------------------------------------------------------------------------
// Console.WriteLine("What's ur name ?");

// string userName = Console.ReadLine();

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("Hello! " + userName + ", nice to meet you.");

// double num1;
// double num2;
// double num3;

// Console.Write("Input the first number: ");

// num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the second number: ");

// num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the third number: ");

// num3 = Convert.ToInt32(Console.ReadLine());

// double avgValue = (num1 + num2 + num3) / 3;

// Console.Write("Average of 3 nums: " + avgValue);

// CONDITIONS -------------------------------------------------------------------------------------------------------
Console.WriteLine("Tickets are 10$. Please insert cash.");

int ticPrice = 10;
int cash = Convert.ToInt32(Console.ReadLine());

if (cash < ticPrice)
{
  int insCash = ticPrice - cash;
  Console.ForegroundColor = ConsoleColor.Magenta;
  Console.WriteLine("Cash is not enough. Please insert the remaining cash: " + insCash + "$");
}
else if (cash > ticPrice)
{
  int remCash = cash - ticPrice;
  Console.ForegroundColor = ConsoleColor.Magenta;
  Console.WriteLine("Ouch, u have inserted extra cash.\nGrab ur tickets & remaining cash " + remCash + "$" + " from C2 at the SOFI Stadium");
}
else
{
  Console.ForegroundColor = ConsoleColor.Magenta;
  Console.WriteLine("Great!, grab ur tickets from C1 at the SOFI Stadium");
}