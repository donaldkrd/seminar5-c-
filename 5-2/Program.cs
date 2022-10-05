//Задайте одномерный массив, заполненный случайными числами (ограничил до 100). Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Введите размер массива");
int sum = 0;

int sizeArr = int.Parse(Console.ReadLine()!);
int[] array = new int[sizeArr];

FillArrayRandomarray(array);
PrintArray(array);

for (int i = 1; i < array.Length; i+=2)
    sum = sum + array[i];
    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

void FillArrayRandomarray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0 , 100);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}