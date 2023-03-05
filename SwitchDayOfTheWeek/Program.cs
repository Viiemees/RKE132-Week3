int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)
{
    case 0:
        Console.WriteLine("It`s Sunday");
        break;
        case 1:
        Console.WriteLine("It`s a Monday");
        break;
        case 2:
        Console.WriteLine("It`s a Tuesday");
        break;
        case 3:
        Console.WriteLine("It`s a Wednesday");
        break;
        case 4:
        Console.WriteLine("It`s a Thursday");
        break;
        case 5:
        Console.WriteLine("It`s a Fryday");
        break;
        case 6:
        Console.WriteLine("It`s a Saturday");
        break;
        default:
        Console.WriteLine("Oops. Your calendar must be broken.");
        break;
}
Console.WriteLine("Have a nice day!");