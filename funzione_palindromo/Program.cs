Console.Write("insert the text= ");
String Text = Console.ReadLine();

Console.WriteLine("\n");
Console.WriteLine("you have insert this text= " + Text);

String ResultText = " ";

for (int i = Text.Length; i > 0; i--)
{
    ResultText += Text[i - 1];
}

Console.WriteLine("the result text is= " + ResultText);

if (string.Equals(Text, ResultText, StringComparison.OrdinalIgnoreCase)) 
{
    Console.WriteLine("\nthe insert text is polindrome");
}
else {
    Console.WriteLine("\nthe text is not polindrome");
}
