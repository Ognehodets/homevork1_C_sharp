Console.WriteLine("введите первое число");//запрос на ввод первого числа
int a = Convert.ToInt32 (Console.ReadLine());//ввод первого числа
Console.WriteLine("введите второе число");//запрос на ввод первого числа
int b = Convert.ToInt32 (Console.ReadLine());//ввод второго числа
if (a>b) Console.WriteLine("первое число больше второго");
else if (a<b) Console.WriteLine("второе число больше первого");
else Console.WriteLine("числа равны");