using System;

namespace ConsoleApp36
{
    class Program
    {
        struct poezd
        {
            public string direction;
            public DateTime departure_time;
            public int platform_number;
            public int path_number;
        }
        static void Main(string[] args)
        {
            //1 задание
            Console.WriteLine("введите время 1: ");
            var data1 = DateTime.Parse(Console.ReadLine()).Second;
            Console.WriteLine("введите время 2: ");
            var data2 = DateTime.Parse(Console.ReadLine()).Second;
            var sec = data1 - data2;
            Console.WriteLine("разница в секундах равна: " + Math.Abs(sec));

            //2 задание
            poezd[] poezds = new poezd[1];
            for (var i = 0; i < poezds.Length; i++)
            {
                Console.WriteLine("введите направление: ");
                poezds[i].direction = Console.ReadLine();
                Console.WriteLine("введите время отправления");
                poezds[i].departure_time = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("введите номер платформы");
                poezds[i].platform_number = int.Parse(Console.ReadLine());
                Console.WriteLine("введите номер пути");
                poezds[i].path_number = int.Parse(Console.ReadLine());
                var date = poezds[i].departure_time - DateTime.Now;
                Console.WriteLine($"Поезд следованием {poezds[i].direction} отправляется от {poezds[i].platform_number} платформы {poezds[i].path_number} пути через {Math.Abs(date.Minutes)} мин.");
            }
        }
    }
}
