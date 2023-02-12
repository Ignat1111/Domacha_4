// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
System.Console.WriteLine("Введите число ");
int num1 = int.Parse(Console.ReadLine()!);
int count = 1;
for (int i = 1; i <=num1; i++)
{
   count *=i;
}
System.Console.WriteLine(count);


