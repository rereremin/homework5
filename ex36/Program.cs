// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

System.Console.WriteLine("Длина массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(ArraySize, 0, 11);
System.Console.Write("[");
System.Console.Write(String.Join(", ", array));
System.Console.Write("]");

int summa = EvenPositionSum(array);
System.Console.Write($" -> {summa}");
//////////////////////////////////////////////////
int EvenPositionSum(int[] FuncArray)
{
    int EvenPosSum = 0;
    for (int i = 0; i < FuncArray.Length; i++)
        if (i % 2 != 0) EvenPosSum += FuncArray[i];
    return EvenPosSum;
}

int[] FillArray(int size, int MinElement, int MaxElement)
{
    int[] FuncArray = new int[size];
    for (int i = 0; i < size; i++)
        FuncArray[i] = new Random().Next(MinElement, MaxElement + 1);
    return FuncArray;
}