/*Write a program that calculates the (average) of all elements in an array,
then prints only the numbers greater than the average.*/
/*
using System.Runtime.Intrinsics.X86;

int[] array = new int[10];
var x = 0;
var avg = 0;
for(int i = 1; i <= 10; i++) 

{ 
    Console.WriteLine($"Enter a {i} Number :");
    
    array[i-1] = Convert.ToInt32(Console.ReadLine());

}
Console.Write($"the numbers greater than the average: ");
foreach (int i in array)
{

    x = (x + i);
     avg = x / array.Length;

   
}
foreach (int i in array) { if (i > avg) { Console.Write($"_{i}_"); } }

Console.WriteLine($"The Average = {avg}"); */
//--------------------------------------------------------------------------------------------

/*Write a program that asks the user to enter several numbers (an array),
then prints the numbers in reverse order.*/
/*Console.WriteLine($"Enter how many num you need :");

int  x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];



for (int i = 1; i <= x; i++)

{
    Console.WriteLine($"Enter a {i} Number :");

    array[i - 1] = Convert.ToInt32(Console.ReadLine());
}

    int y = x;
Console.Write($"The result = ");
    for (int j = y - 1; j >= 0; j--)
        {
        Console.Write($"_ {array[j]}_");
}
*/

//--------------------------------------------------------------------------------------------
/*Write a program that finds the first character in a text (string) that does not repeat anywhere else in the string.*/

Console.WriteLine($"Enter a string :");

string str = Console.ReadLine();



Dictionary<char, int> dic = new Dictionary<char, int>();

foreach (var item in str)
{
    if (dic.ContainsKey(item))

    { dic[item]++; }

    else

    { dic[item] = 1; }

}

bool b = dic.ContainsValue(1);
if (b) {

    Console.WriteLine($"{dic.Values} _ {dic.ContainsKey}" );
}
