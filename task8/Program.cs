// Задача 8: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Ведите число:  ");
int num = Convert.ToInt32(Console.ReadLine());


if (num < 1)
{
    Console.Write("Не верное значение");
}
else
{
    int count = -num;
    while (count <= num)
    {
        if (count % 2 == 0 && count>0)
        {
            Console.Write($"  {count}"  );
        }
        count++;
    }



}




