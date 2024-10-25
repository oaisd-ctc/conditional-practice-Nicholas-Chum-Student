
public class Program
{
    public static void Main(string[] args)
    {
        CheckForPositiveNegativeZero();
        FindMinimum(1, 2, 3);
        FindMaximum(1, 2, 3);
        IsDivisibleBy5(10);
        CheckEvenOrOdd(4);
        CheckVowelOrConsonant('e');
        DisplayDayOfWeek(1);
    }    
    public static void CheckForPositiveNegativeZero()
    {
        Console.WriteLine("Give me a number");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Your number is positive!");
        }
        else if (number < 0)
        {
            Console.WriteLine("Your number is negative");
        }
        else
        {
            Console.WriteLine("Your number is zero");
        }
    }
    
    public static void FindMinimum(int num1, int num2, int num3)
    {
        int min = num1;

        if (num2 < min)
        {
            min = num2;
        }

        if (num3 < min)
        {
            min = num3;
        }

        Console.WriteLine($"The minimum value is {min}");
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 < min)
        {
            max = num2;
        }

        if (num3 < min)
        {
            max = num3;
        }

        Console.WriteLine($"The minimum value is {max}");
    }

    public static void IsDivisibleBy5(int number)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine($"{number} is divisible by 5.");
        }
        else
        {
            Console.WriteLine($"{number} is not divisible by 5.");
        }
    }

    public static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine($"{letter} is a vowel.");
        }
        else
        {
            Console.WriteLine($"{letter} is a consonant.");
        }
    }

    public static void DisplayDayOfWeek()
    {
        switch (day)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Please input a number between 0 and 6");
                break;
        }
    }
}