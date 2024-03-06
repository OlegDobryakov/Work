string[] FillingArray(string[] array, int size)
{
    int characters = 0;
    int w = 0;
    string[] array2 = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            characters++;
        }
        if (characters <= 3)
        {
            array2[w] = array[i];
            w++;

        }
        characters = 0;
    }
    return array2;
}
System.Console.Write("Введите общее количество строк: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = new string[size];
string[] array2 = new string[size];
System.Console.Write("Введите строки: ");
for (int i = 0; i < array.Length; i++)
{
    string str = Console.ReadLine()!;
    array[i] = str;
}
array2 = FillingArray(array, size);
foreach (string e in array2)
{
    System.Console.Write(e + " ");
}