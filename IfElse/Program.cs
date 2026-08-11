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