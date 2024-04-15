string userEnt = "";
long userParse = 0;

Console.WriteLine("Введите число."); //Просим пользователя ввести число
userEnt = Console.ReadLine();

if (userEnt.Length == 0) //Проверяем наличие ввода
{
    Console.WriteLine("Ничего не введено!");
} else
{
    userParse = long.Parse(userEnt);

    if (userParse <= sbyte.MaxValue && userParse >= sbyte.MinValue) //sbyte
    {
        var x = (sbyte)userParse;
        Console.Write("1) ");
        Console.WriteLine(x);

    } else
    {
        Console.WriteLine($"1) Для приведения числа {userParse} к типу sbyte число не может быть больше {sbyte.MaxValue} и меньше {sbyte.MinValue}");
    }

    if (userParse <= short.MaxValue && userParse >= short.MinValue) //short
    {
        var x = (short)userParse;
        Console.Write("2) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"2) Для приведения числа {userParse} к типу short число не может быть больше {short.MaxValue} и меньше {short.MinValue}");
    }

    if (userParse <= int.MaxValue && userParse >= int.MinValue) //int
    {
        var x = (int)userParse;
        Console.Write("3) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"3) Для приведения числа {userParse} к типу int число не может быть больше {int.MaxValue} и меньше {int.MinValue}");
    }

    if (userParse <= long.MaxValue && userParse >= long.MinValue) //long
    {
        var x = (long)userParse;
        Console.Write("4) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"4) Для приведения числа {userParse} к типу long число не может быть больше {long.MaxValue} и меньше {long.MinValue}");
    }

    if (userParse <= byte.MaxValue && userParse >= byte.MinValue) //byte
    {
        var x = (byte)userParse;
        Console.Write("5) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"5) Для приведения числа {userParse} к типу byte число не может быть больше {byte.MaxValue} и меньше {byte.MinValue}");
    }

    if (userParse <= ushort.MaxValue && userParse >= ushort.MinValue) //ushort
    {
        var x = (ushort)userParse;
        Console.Write("6) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"6) Для приведения числа {userParse} к типу ushort число не может быть больше {ushort.MaxValue} и меньше {ushort.MinValue}");
    }

    if (userParse <= uint.MaxValue && userParse >= uint.MinValue) //uint
    {
        var x = (uint)userParse;
        Console.Write("7) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"7) Для приведения числа {userParse} к типу uint число не может быть больше {uint.MaxValue} и меньше {uint.MinValue}");
    }

    if ((ulong)userParse < ulong.MaxValue && userParse > (long)ulong.MinValue) //ulong
    {
        var x = (ulong)userParse;
        Console.Write("8) ");
        Console.WriteLine(x);

    }
    else
    {
        Console.WriteLine($"8) Для приведения числа {userParse} к типу ulong число не может быть больше {ulong.MaxValue} и меньше {ulong.MinValue}");
    }
}
