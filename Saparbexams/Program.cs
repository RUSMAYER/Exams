using System;
using System.Runtime.ConstrainedExecution;
using GarageLibrary;

namespace GarageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage
            {
                Name = "Мой Гараж",
                Address = "Улица Примерная, 1"
            };

            garage.AddCar(new Car { Owner = "Иванов И.И.", Number = "A123BC" });
            garage.AddCar(new Car { Owner = "Петров П.П.", Number = "B456CD" });
            garage.AddCar(new Car { Owner = "Сидоров С.С.", Number = "C789EF" });
            garage.ShowAll();
            Console.WriteLine("Работу выполнил Сапарбаев Руслан 34ИС");
            Console.ReadKey();
        }
    }

}
