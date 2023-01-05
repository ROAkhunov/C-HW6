// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int CheckMoreZero(int [] array)
{
    int size= array.Length;
    int count=0;
    for (int i = 0; i < size; i++)
    {
        count+=array[i]>0?1:0;
    }
    return count;
}
int [] GetIntArr(string [] array)
{
  int size= array.Length;
    int [] newArray=new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray [i]=int.Parse(array[i]);
    }
    return newArray;   
}
Console.WriteLine("Введите числа через пробел");
string [] inputArray = Console.ReadLine().Split();
int [] resArray = GetIntArr(inputArray);
Console.WriteLine($"[{String.Join(",",resArray)}]");
// int a = resArray[2];
// System.Console.WriteLine(a);
int count = CheckMoreZero(resArray);
Console.WriteLine($"Чисел больше нуля: {count}");
