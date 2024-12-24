using System;
using System.Collections.Generic;

namespace GarageLibrary
{
    public class Garage
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public Garage()
        {
            Cars = new List<Car>();
        }
        public void ShowAll()
        {
            Console.WriteLine($"Гараж: {Name}, Адрес: {Address}");
            foreach (var car in Cars)
            {
                car.Show();
            }
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
    }

    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }

        public void Show()
        {
            Console.WriteLine($"Владелец: {Owner}, Гос. номер: {Number}");
        }
    }
}
//Сапарбаев Руслан 34 ИС
