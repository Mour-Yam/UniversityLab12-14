using System;

namespace Project2
{
    class Program
    {
/*
Напишите объявления для следующих диаграмм классов, включив в него члены-данные, конструкторы по умолчанию и с параметрами , методы доступа,
методы ввода-вывода для клавиатуры и экрана и т.д. : Vehicle->Car and Bus 
*/
        static void Main(string[] args)
        {
            Car v1 = new Car("abs123", "Mazda", "2015", 200.5);
            Bus v2 = new Bus("kr321", "Marcedes-benz", "2010", 42);
        }
    }
}
