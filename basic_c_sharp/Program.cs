string myLongString = @"This is a very
     very
          very
               long string";
Console.WriteLine(myLongString);


// Equals strings
Console.WriteLine("=> String equality");
string s1 = "Hello!";
string s2 = "Yo!";
string s3 = "Hello!";

Console.WriteLine("s1 = {0}", s1);
Console.WriteLine("s2 = {0}", s2);
Console.WriteLine();

// Test equality
Console.WriteLine("s1 == s2: {0}", s1 == s2);
Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");

Console.WriteLine("\n\ns1 == s3: {0}", s1 == s3);

Console.WriteLine("\n\ns1.Equals(s3): {0}", s1.Equals(s3));


Console.WriteLine("\ns1 == hello!: {0}", s1 == "hello!");

Console.WriteLine("\ns1 as Lower == hello!: {0}", s1.ToLower() == "hello!");

static void StringsEquality(){
  Console.WriteLine("=> String equality (Case Insensitive:");
  string s1 = "Hello!";
  string s2 = "HELLO!";
  Console.WriteLine("s1 = {0}", s1);
  Console.WriteLine("s2 = {0}", s2);
  Console.WriteLine();
  // Check the results of changing the default compare rules.
  Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
  Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
  Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}",
    s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));

  Console.WriteLine();
  Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2,
  s1.IndexOf("E"));
  Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));

  Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}",
    s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
  Console.WriteLine();

  Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.Ordinal): {0}", s1.IndexOf("E", StringComparison.Ordinal));
}

StringsEquality();


static void StringsAreImutable(){
 Console.WriteLine("=> Strings are Imutable:");
 string s1 = "Hi!";
 s1 = "Hello!";
 Console.WriteLine(s1);
}

StringsAreImutable();