//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("введите число:");
string number1 = Console.ReadLine();
Zadacha13(number1);

void Zadacha13(string number1)
{
    if (number1.Length < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else if (number1[2] !=0)
    {
        Console.WriteLine(number1[2]);
    }

    }




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine ("введите число дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("это рабочий день понедельник");
}
else if (number == 2)
{
    Console.WriteLine("это рабочий день вторник");
}

else if (number == 3)
{
    Console.WriteLine("это рабочий день среда");
}
else if (number == 4)
{
    Console.WriteLine("это рабочий день четверг");
}
else if (number == 5)
{
    Console.WriteLine("это рабочий день пятница");
}
else if (number == 6)
{
    Console.WriteLine("это выходной день суббота");
}
else if (number == 7)
{
    Console.WriteLine("это выходной день воскресенье");
}
else Console.WriteLine("введено значение не соответсвующее условию");