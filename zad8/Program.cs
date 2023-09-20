Console.WriteLine("введите число");//запрос на ввод числа
int N = Convert.ToInt32 (Console.ReadLine());//ввод числа
if (N<=0)//обработка ввода не положительного числа
{
    Console.WriteLine("введите положительное число");
}
else
{
    int i=1;//переход к первому числу
    while (i<N)
    {
        if (i%2 == 0)  Console.Write(i+" ");//вывод четных чисел
        i++;
    }    
}