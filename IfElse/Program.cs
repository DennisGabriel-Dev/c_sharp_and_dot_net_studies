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
   Console.WriteLine("================ BuildingMyOwnMathing ===============/n");
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


static void ConditionRefReference()
{
  Console.WriteLine("================ ConditionRefReference ===============/n");
  int[] smallArray = new int[] { 1, 2, 3, 4, 5};
  int[] largeArray = new int[] { 10, 20, 30, 40, 50 };

  int index = 7;
  ref int refValue = ref ((index < 5)
   ? ref smallArray[index]
   : ref largeArray[index - 5]);
  
  refValue = 0;

  index = 2;
  ((index < 5)
    ? ref smallArray[index]
    : ref largeArray[index - 5]) = 100;
  Console.WriteLine(string.Join(" ", smallArray));
  Console.WriteLine(string.Join(" ", largeArray));
}

ConditionRefReference();


static void SwitchStatement()
{
  Console.WriteLine("================ SwitchStatement ===============/n");
  Console.WriteLine("1 [C#], 2 [Java]");
  Console.WriteLine("Please pick your language:");

  string langChoice = Console.ReadLine();
  int n = int.Parse(langChoice);

  switch(n)
  {
    case 1:
      Console.WriteLine("Good choice, C# is a fine language");
      break;
    case 2:
      Console.WriteLine("Nice, Java is a great language as well");
      break;
    default:
      Console.WriteLine("Well... good luck with that!");
      break;
    }
}

SwitchStatement();