
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int j = Convert.ToInt32(Console.ReadLine());
if (i<j)
{
  Console.WriteLine("Первое число "  +  i  + " меньше чем второе " + j);
}
else 
{
  Console.WriteLine("Второе число " + j + " больше чем первое " + i);
}


