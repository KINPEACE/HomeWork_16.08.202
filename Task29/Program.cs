// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

Console.Write("Введите 9 чисел через запятую: ");
string seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces(string series)
{
    string seriesNew = "";
    for(int i = 0; i < series.Length; i++)
    {
        if(series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

int[] ArrayOfNumbers(string seriesNew)
{
int[] ArrayOfNumbers = new int[1];
int j = 0;
for(int i = 0; i < seriesNew.Length; i++)
{
    string seriesNew1 = "";

while(seriesNew[i] != ',' && i < seriesNew.Length)
{
    seriesNew1 += seriesNew[i];
    i++;
}
ArrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
if(i < seriesNew.Length - 1)
{
    ArrayOfNumbers = ArrayOfNumbers.Concat(new int[] {0}).ToArray();
}
j++;
}
return ArrayOfNumbers;
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
        Console.Write(coll[index]);
        index++;
        if(index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);
PrintArray(arrayOfNumbers);