System.Console.WriteLine("Длина массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(ArraySize, 100, 1000);
System.Console.Write(String.Join(", ", array));
int res = EvenNumbers(array);
System.Console.WriteLine($" -> {res}");

////////////////////////////////////////////////////
int EvenNumbers(int[] FuncArray)
{
    int EvenAmount = 0;
    foreach (int item in FuncArray)
        if(item % 2 == 0) EvenAmount++;
    return EvenAmount;
}


int[] FillArray(int size, int MinElement, int MaxElement)
{
    int[] FuncArray = new int[size];
    for (int i = 0; i < size; i++)
        FuncArray[i] = new Random().Next(MinElement, MaxElement + 1);
    return FuncArray;
}