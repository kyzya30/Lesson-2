using System;

namespace HW_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите зарплату:");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стаж работы:");
            int years = int.Parse(Console.ReadLine());
            if (years < 5) { Console.WriteLine("Премия составляет {0}", salary*0.1); }
            if (years >=5 && years <10) { Console.WriteLine("Премия составляет {0}", salary * 0.15); }
            if (years >= 10 && years < 15) { Console.WriteLine("Премия составляет {0}", salary * 0.25); }
            if (years >= 15 && years < 20) { Console.WriteLine("Премия составляет {0}", salary * 0.35); }
            if (years >= 20 && years < 25) { Console.WriteLine("Премия составляет {0}", salary * 0.45); }
            if (years >= 25) { Console.WriteLine("Премия составляет {0}", salary * 0.50); }
        }
    }
}
