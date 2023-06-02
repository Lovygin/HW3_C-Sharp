//Написать список кубов чисел от 1 до N, где N  введенное с консоли число.

Console.Clear();
Console.WriteLine("Please, enter integer value");
int N = int.Parse(Console.ReadLine());
int[] cubes = new int[N];
    for(int i = 1; i <= N; i++)
    {
        cubes[i-1] = (int)Math.Pow(i, 3);//Нужно написать (int) перед Math.Pow(...) ХЗ зачем и когда конкретно.
    }
    Console.WriteLine(cubes);
