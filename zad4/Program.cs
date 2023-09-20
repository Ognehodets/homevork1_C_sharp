Console.WriteLine("введите первое число");//запрос на ввод первого числа
int a = Convert.ToInt32 (Console.ReadLine());//ввод первого числа
Console.WriteLine("введите второе число");//запрос на ввод первого числа
int b = Convert.ToInt32 (Console.ReadLine());//ввод второго числа
Console.WriteLine("введите второе число");//запрос на ввод первого числа
int c = Convert.ToInt32 (Console.ReadLine());//ввод третьего числа
int max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.WriteLine("наибольшее число равно "+max);