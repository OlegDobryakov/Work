System.Console.Write("Введите общее количество строк: ");
int size = int.Parse(Console.ReadLine()!);
string [] array = new string [size];
string [] array2 = new string [size];
System.Console.Write("Введите строки: ");
for (int i = 0; i < array.Length; i++)
{
  string str = Console.ReadLine()!;
    array[i] = str;  
}