// Напишите цикл, который принимает на вход два числа (A и B) и возводит число А в натуральную степень В.

int Cycle(int A,int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result = result * A;
    }
        return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень B: ");
int B = Convert.ToInt32(Console.ReadLine());

int cycle = Cycle(A, B);
Console.WriteLine("Ответ: " + cycle);