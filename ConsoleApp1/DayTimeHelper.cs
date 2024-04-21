
namespace ConsoleApp1.test;

public static class DayTimeHelper
{
    public static void PrintMessage(DayTime dayTime)
    {
        switch (dayTime)
        {
            case DayTime.Morning:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Доброе утро");
                break;
            case DayTime.Afternoon:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Добрый день");
                Console.BackgroundColor = ConsoleColor.Black;
                break;
            case DayTime.Evening:
                Console.WriteLine("Добрый вечер");
                break;
            case DayTime.Night:
                Console.WriteLine("Доброй ночи");
                break;
        }
    }

}
public static class RecursiveFlex
{
    public static int Sum(int x, int y)
    {
        Console.WriteLine("Залупа");
        return Sum(x,y);
    }


}