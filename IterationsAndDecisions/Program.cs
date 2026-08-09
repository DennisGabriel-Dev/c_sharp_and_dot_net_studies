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