using System;
Console.WriteLine("***** Fun with type conversions *****");
// Add two shorts and print the result.
short numb1 = 9, numb2 = 21;
Console.WriteLine("{0} + {1} = {2}",
  numb1, numb2, Add(numb1, numb2));
static int Add(int x, int y)
{
  return x + y;
}

Console.WriteLine("\nUsing narrowing operation with cast.");

Console.WriteLine("***** Fun with type conversions *****");
    short numb3 = 30000, numb4 = 30000;
    // Explicitly cast the int into a short (and allow loss of data).
    short answer = (short)Add(numb3, numb4);
    Console.WriteLine("{0} + {1} = {2}",
      numb3, numb4, answer);
    //NarrowingAttempt();
    Console.ReadLine();