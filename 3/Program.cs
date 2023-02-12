// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("Введите число");
int num=int.Parse(Console.ReadLine()!);
int count = 0;
for (int i=0; i < num; i++)
{
   count = i*i*i;
   if(count % 2 ==0);
}
System.Console.WriteLine(count);