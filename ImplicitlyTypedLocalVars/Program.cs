static void DeclareImplicitVars()
{
  var myInt = 0;
  var myBool = true;
  var myString = "C# is so good...";

  Console.WriteLine("myInt is a {0}", myInt.GetType().Name);
  Console.WriteLine("myBool is a {0}", myBool.GetType().Name);
  Console.WriteLine("myString is a {0}", myString.GetType().Name);
}


DeclareImplicitVars();