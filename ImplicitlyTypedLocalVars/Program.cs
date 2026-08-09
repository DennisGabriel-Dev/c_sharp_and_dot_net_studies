static void DeclareImplicitVars()
{
  Console.WriteLine("DeclareImplicitVars()");
  var myInt = 0;
  var myBool = true;
  var myString = "C# is so good...";

  Console.WriteLine("myInt is a {0}", myInt.GetType().Name);
  Console.WriteLine("myBool is a {0}", myBool.GetType().Name);
  Console.WriteLine("myString is a {0}", myString.GetType().Name);
}


DeclareImplicitVars();

Console.WriteLine("-----------------------------------");

static void DeclareImplicitNumerics()
{
  Console.WriteLine("DeclareImplicitNumerics()");
  var myUInt = 0u;
  var myInt = 0;
  var myLong = 0L;
  var myDouble = 0.0;
  var myFloat = 0.5F;
  var myDecimal = 0.5M;

  Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
  Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
  Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
  Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
  Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
  Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
}

DeclareImplicitNumerics();

Console.WriteLine("-----------------------------------");

static void LinqQueryOverInts()
{
  Console.WriteLine("LinqQueryOverInts()");
  int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 4, 8 };
  
  var subset = from i in numbers where i < 10 select i;

  Console.Write("Values in subset: ");
  foreach (var num in subset)
  {
    Console.Write("{0}, ", num);
  }
  Console.WriteLine();

  Console.WriteLine("subset is a: {0}", subset.GetType().Name);
  Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
}

LinqQueryOverInts();