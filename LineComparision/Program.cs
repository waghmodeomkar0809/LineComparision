// See https://aka.ms/new-console-template for more information
using LineComparision;

Comparision comparison = new Comparision(1,2,3,4);
double line1 = comparison.CalculateLength();
Console.WriteLine("Length of first line" +line1);
Comparision LineComparision = new Comparision(1,2,3,4);
double Line2 = comparison.CalculateLength();
Console.WriteLine("Length of second line" + Line2);
if (line1 == Line2)
{
    Console.WriteLine("Line1 is equal to Line2");
}
else
{
    Console.WriteLine("Line1 is not equals to Line2");
}

