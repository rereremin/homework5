// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

System.Console.WriteLine("Длина массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(ArraySize, 0, 15);

int min = MinElement(array);
int max = MaxElement(array);
int difference = MinMaxDiff(min, max);

System.Console.Write("[");
System.Console.Write(String.Join(", ", array));
System.Console.Write("]");
System.Console.Write($" -> {difference}");

/////////////////////////////////////////////////////////////////////
int MinMaxDiff(int FuncMin, int FuncMax)
{
    return FuncMax - FuncMin;
}

int MaxElement(int[] FuncArray)
{
    int max = FuncArray[0];
    for (int i = 0; i < FuncArray.Length; i++)
       if(FuncArray[i] > max) max = FuncArray[i];
    return max;
}

int MinElement(int[] FuncArray)
{
    int min = FuncArray[0];
    for (int i = 0; i < FuncArray.Length; i++)
       if(FuncArray[i] < min) min = FuncArray[i]; 
    return min;
}

int[] FillArray(int size, int MinElement, int MaxElement)
{
    int[] FuncArray = new int[size];
    for (int i = 0; i < size; i++)
        FuncArray[i] = new Random().Next(MinElement, MaxElement + 1);
    return FuncArray;
}
