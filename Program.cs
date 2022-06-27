namespace HW2Kovalenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hw2/1
            float a;
            float b;
            float c;
            Console.WriteLine($"Введiть значення: a , b i c, та перевiрте чи входять вони в промiжок вiд -5 до 5");
            Console.WriteLine($"a=");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"b=");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"c=");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine((a >= -5) & (a <= 5) ? "a входить у промiжок" : "а не входить у промiжок");
            Console.WriteLine((b >= -5) & (b <= 5) ? "b входить у промiжок" : "b не входить у промiжок");
            Console.WriteLine((c >= -5) & (c <= 5) ? "c входить у промiжок" : "c не входить у промiжок");

            //hw2/2
            int num1;
            int num2;
            int num3;
            Console.WriteLine($"Введiть num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введiть num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введiть num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine($"{num1} min, {num3} max");
            }
            else if (num2 < num3 && num3 < num1)
            {
                Console.WriteLine($"{num2} min, {num1} max");
            }
            else if (num3 < num2 && num1 < num2)
            {
                Console.WriteLine($"{num3} min, {num2} max");
            }
            else if (num2 < num1 && num1 < num3)
            {
                Console.WriteLine($"{num2} min, {num3} max");
            }
            else if (num1 < num3 && num3 < num2)
            {
                Console.WriteLine($"{num1} min, {num2} max");
            }
            else
            {
                Console.WriteLine($"{num3} min, {num1} max");
            }
            //hw2/2.1
            int nom1;
            int nom2;
            int nom3;
            Console.WriteLine("Введiть перше число");
            nom1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть друге число");
            nom2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть третє число");
            nom3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("min");
            Console.WriteLine(Math.Min(nom1, Math.Min(nom2, nom3)));
            Console.WriteLine("max");
            Console.WriteLine(Math.Max(nom1, Math.Max(nom2, nom3)));

            //hw2.3

            Console.WriteLine("Введіть номер помилки");
            int error = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(Errors), error));

            //hw2.4
            Dog myDog = new Dog();
            myDog.ReadValues();
            Console.WriteLine(myDog);
        }

        struct Dog
        {
            private string _name;
            private string _mark;
            private int _age;

            public override string ToString()
            {
                return $"Iм'я собаки {_name}, порода {_mark}, вiк {_age} рокiв";
            }

            public void ReadValues()
            {
                Console.WriteLine("Enter name");
                _name = Console.ReadLine();
                Console.WriteLine("Enter mark");
                _mark = Console.ReadLine();
                Console.WriteLine("Enter age");
                _age = Convert.ToInt32(Console.ReadLine());
            }
        }

        enum Errors
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound,
        }
    }
}