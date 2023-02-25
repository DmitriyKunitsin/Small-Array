// See https://aka.ms/new-console-template for more information
Console.WriteLine("Сколько элементов в массиве ? ");
int NewArray = int.Parse(Console.ReadLine());
int[] Array = new int[NewArray];
for (int i = 0;i < NewArray; i++)
{
    Console.WriteLine($"значение элемента массива: {i}");
    Array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Значения массива ");
for (int i = 0; i < Array.Length; i++)
{
    
    Console.WriteLine(Array[i]);
}
Console.Write("Значение минимального элемента массива : ");
Console.WriteLine(Array.Min());
Console.ReadLine();