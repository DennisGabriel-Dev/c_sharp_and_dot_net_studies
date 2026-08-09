static void ForLoopExample()
{
  Console.WriteLine("ForLoopExample()");
  for (int i = 0; i < 5; i++)
  {
    Console.WriteLine("Number is: {0}", i);
  }
}

ForLoopExample();

Console.WriteLine("----------------------");

static void ForEachExample()
{
  Console.WriteLine("ForEachExample()");
  string[] cars = { "Ford", "BMW", "Yugo", "Honda" };

  foreach(string car in cars)
  {
    Console.WriteLine(car);
  }
}

ForEachExample();
Console.WriteLine("----------------------");
static void LinqQueryOverInts()
{
  Console.WriteLine("LinqQueryOverInts()");
  int[] numbers = {10, 20, 30, 40, 1, 2, 3, 4};

  var filterInts = from num in numbers where num > 10 select num;

  Console.WriteLine("Values in subset: ");
  foreach(int n in filterInts)
  {
    Console.WriteLine(n);
  }
}

LinqQueryOverInts();
Console.WriteLine("----------------------");

static void WhileLoopExample()
{
  Console.WriteLine("WhileLoopExample()");
  string userIsDone = "";
  while(userIsDone != "yes")
  {
    Console.WriteLine("In while loop");
    Console.Write("Are you done? [yes]/[no] -> ");
    userIsDone = Console.ReadLine() ?? "no";
    userIsDone = userIsDone.ToLower();
  }
}
WhileLoopExample();
Console.WriteLine("----------------------");


static void DoWhileLoopExample()
{
  Console.WriteLine("DoWhileLoopExample()");
  string userIsDone = "";
  do
  {
    Console.WriteLine("In while loop");
    Console.Write("Are you done? [yes]/[no] -> ");
    userIsDone = Console.ReadLine() ?? "no";
    userIsDone = userIsDone.ToLower();
  }
  while(userIsDone != "yes");
}
DoWhileLoopExample();