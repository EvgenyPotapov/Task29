//Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.


Console.Clear();

int[] FillArray()
{
    int[] array = new int[8];
    int lengtn = array.Length;
    int index = 0;
    while (index < lengtn)
    {
        array[index] = new Random().Next(1, 99);
        index++;
    }
    return array;
}

void PrintArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    Console.Write("[");
    while (index < length)
    {
        Console.Write(number[index]);
        if (index != length - 1)
        {
            Console.Write(", ");
        }
        index++;
    }
    Console.Write("]");
}

void IfPrintArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(number[index]);
        if (index != length - 1) ;
        {
            Console.Write(", ");
        }
        index++;
    }
}

int[] array = FillArray(); 


IfPrintArray(array);
Console.Write(" -> ");
PrintArray(array);