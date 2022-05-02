// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int number1, number2;
 
Console.WriteLine("Введите два числа : ");
 
number1 = Convert.ToInt32(Console.ReadLine());
 
number2 = Convert.ToInt32(Console.ReadLine());
 
    if (number1 > number2)
 
    {
 
    Console.WriteLine("{0} - большее число", number1);

    Console.WriteLine("{0} - меньшее число", number2);
 
    }
 
    else
 
    {
 
    Console.WriteLine("{0} - большее число ", number2);
    
    Console.WriteLine("{0} - меньшее число", number1);
 
    }
 
Console.ReadLine();