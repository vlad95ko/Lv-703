//HomeWork3
//Task1
Console.WriteLine("Hi,please type yout name and surname");
string fullname = Console.ReadLine();
fullname = fullname.ToLower();
char char_1 = 'a';
char char_2 = 'e';
char char_3 = 'i';
char char_4 = 'o';
int num_of_a = fullname.Count(A => (A == char_1));
Console.WriteLine($"the letter a is repeated {num_of_a} times");
int num_of_e = fullname.Count(A => (A == char_2));
Console.WriteLine($"the letter e is repeated {num_of_e} times");
int num_of_i = fullname.Count(A => (A == char_3));
Console.WriteLine($"the letter i is repeated {num_of_i} times");
int num_of_o = fullname.Count(A => (A == char_4));
Console.WriteLine($"the letter o is repeated {num_of_o} times");
Console.WriteLine();

//Task2
Console.WriteLine("To know how many days in any month,type the name of the month");
string input_month = Console.ReadLine();

switch (input_month.ToLower())
{
    case "january":
        Console.WriteLine("in January 31 days");
        break;
    case "february":
        Console.WriteLine("Which year?");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 4 == 0)
        {
            if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))

                Console.WriteLine($"In February {year} 29 days");
            else
                Console.WriteLine($"In February {year} 28 days");
        }
        else
            Console.WriteLine($"In February {year} 28 days");
        break;
    case "march":
        Console.WriteLine("in March 31 days");
        break;
    case "april":
        Console.WriteLine("in April 30 days");
        break;
    case "may":
        Console.WriteLine("in May 31 days");
        break;
    case "june":
        Console.WriteLine("in June 30 days");
        break;
    case "july":
        Console.WriteLine("in July 31 days");
        break;
    case "august":
        Console.WriteLine("in August 31 days");
        break;
    case "september":
        Console.WriteLine("in September 30 days");
        break;
    case "october":
        Console.WriteLine("in October 31 days");
        break;
    case "november":
        Console.WriteLine("in November 30 days");
        break;
    case "december":
        Console.WriteLine("in December 31 days");
        break;
}
Console.WriteLine();

//Task3
Console.WriteLine("Please type ten integer numbers one by one");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());
int g = Convert.ToInt32(Console.ReadLine());
int h = Convert.ToInt32(Console.ReadLine());
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
if (a > 0 && b > 0 && c > 0 && d > 0 && e > 0)
{
    Console.WriteLine($"sum of the first five numbers = {a + b + c + d + e}");
}
else Console.WriteLine($"sum of the last five numbers = {f + g + h + i + j}");