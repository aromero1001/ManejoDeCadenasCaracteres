using System.Collections.Specialized;
using System.Text;

StringCollection misStrings = new StringCollection();

// 2. Agregar elementos
// Cada string es UN OBJETO más en el HEAP
misStrings.Add("Goku");
misStrings.Add("Vegeta");
misStrings.Add("Trunks");

Console.WriteLine(misStrings[0]);

foreach (String? s in misStrings) 
{ 
    Console.WriteLine(s);
}

var conLinq = misStrings.Cast<string>().Where(s => s.StartsWith("G"));


StringBuilder sb = new StringBuilder();

sb.Append('-',6);
sb.Append(" Mundo");


sb.AppendLine();

sb.Replace('-', '*');





foreach (char c in sb.ToString())
{
    Console.Write(c);
}

