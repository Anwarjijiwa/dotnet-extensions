// See https://aka.ms/new-console-template for more information
string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
Console.WriteLine(str1.Length);

// TODO: Access individual characters
Console.WriteLine(str1[14]);

// TODO: Iterate over a string like any other sequence of values
foreach (char ch in str1) {
  Console.Write(ch);
  if (ch == 'b') {
    Console.WriteLine();
    break;
  }
}

// TODO: String Concatenation         
string outstr;
outstr = String.Concat(strs);


// TODO: Joining strings together with Join
outstr = String.Join('.', strs);
Console.WriteLine(outstr);
outstr = String.Join("---", strs);
Console.WriteLine(outstr);

// TODO: Replacing content
string outstr1 = str1.Replace("Fox", "cat");
Console.WriteLine($"{outstr1}");