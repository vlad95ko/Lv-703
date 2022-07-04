//task1
Console.WriteLine("Enter text");
string str = Console.ReadLine();
str = str.ToLower();
char ch1 = 'a';
char ch2 = 'o';
char ch3 = 'i';
char ch4 = 'e';
int num1a = str.Count(f => (f == ch1));
Console.WriteLine($"Символiв: а {num1a} ");
int num2o = str.Count(f => (f == ch2));
Console.WriteLine($"Символiв: o {num2o} ");
int num3i = str.Count(f => (f == ch3));
Console.WriteLine($"Символiв i {num3i} ");
int num4e = str.Count(f => (f == ch4));
Console.WriteLine($"Символiв e {num4e} ");
//task2
Console.WriteLine("Введіть номер місяця: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть номер року");
int year = int.Parse(Console.ReadLine());
Console.WriteLine($"У твому місяці{DateTime.DaysInMonth(year, month)}");
//task3
Console.WriteLine("Введіть 10 чисел");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());
int num6 = int.Parse(Console.ReadLine());
int num7 = int.Parse(Console.ReadLine());
int num8 = int.Parse(Console.ReadLine());
int num9 = int.Parse(Console.ReadLine());
int num10 = int.Parse(Console.ReadLine());
if (num1 >= 0 && num2 >= 0 && num3 >= 0 && num4 >= 0 && num5 >= 0)
{
    Console.WriteLine(num1 + num2 + num3 + num4 + num5);
}
else
{
    Console.WriteLine(num6 * num7 * num8 * num9 * num10);
}