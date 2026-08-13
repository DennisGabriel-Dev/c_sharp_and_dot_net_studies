object myPhrase = "dennis eh lindo";

if (myPhrase is string Abc)
{
  Console.WriteLine($"{Abc} is a {Abc.GetType().Name}");
  if(Abc.Length > 0)
  {
    Console.WriteLine("myPhrase has a content.");
  }
  else
  {
    Console.WriteLine("[warning] myPhrase doesn't has a content.");
  }
}

// same result
// if (myPhrase is string)
// {
//   string Abc = (string)myPhrase;
//   Console.WriteLine($"{Abc} is a {Abc.GetType().Name}");
//   if(Abc.Length > 0)
//   {
//     Console.WriteLine("myPhrase has a content.");
//   }
//   else
//   {
//     Console.WriteLine("[warning] myPhrase doesn't has a content.");
//   }
// }

int number = 2;
if (number is int num)
{
  Console.WriteLine($"{num} is a {num.GetType().Name}");
}


static void IfElsePatternMatchingUpdatedInCSharp9()
{
  Console.WriteLine("================ C# 9 If Else Pattern Matching Improvements ===============/n");
  object testItem1 = 123;
  Type t = typeof(string);
  char c = 'f';
  //Type patterns
  if (t is Type)
  {
    Console.WriteLine($"{t} is a Type");
  }
  //Relational, Conjuctive, and Disjunctive patterns
  if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
  {
    Console.WriteLine($"{c} is a character");
  };
  //Parenthesized patterns
  if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
  {
    Console.WriteLine($"{c} is a character or separator");
  };
  //Negative patterns
  if (testItem1 is not string)
  {
    Console.WriteLine($"{testItem1} is not a string");
  }
  if (testItem1 is not null)
  {
    Console.WriteLine($"{testItem1} is not null");
  }
  Console.WriteLine();
}


IfElsePatternMatchingUpdatedInCSharp9();


static void BuildingMyOwnMathing()
{
  char c = '-';
  Type cType = c.GetType();
  Console.WriteLine($"Type of 'c' is {cType}");

  Console.WriteLine(
    c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' 
    ? "makes part of alphabet" 
    : "'c' does not makes part of alphabet"
  );
}

BuildingMyOwnMathing();