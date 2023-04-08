// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введи день недели цифрой (от 1 до 7) : ");
int NumberDay = int.Parse(Console.ReadLine());


if(NumberDay == 1)
    {
        Console.WriteLine( "Понедельник");
    }
else
    {
        if(NumberDay == 2)
            {
                Console.WriteLine( "Вторник");
            }
        else
            {
                if(NumberDay == 3)
                Console.WriteLine( "Среда");     
            }
            if(NumberDay == 4)
            {
                Console.WriteLine( "Четверг");
            }
        else
            {
                if(NumberDay == 5)
                Console.WriteLine( "Пятница");     
            }
            if(NumberDay == 6)
            {
                Console.WriteLine( "Субботу");
            }
        else
            {
                if(NumberDay == 7)
                Console.WriteLine( "Воскресенье");     
            }
    }