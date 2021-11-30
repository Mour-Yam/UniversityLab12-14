﻿using System;

namespace Project1
{
    class Program
    {
/*
Напишите объявление класса Rectangle (прямоугольник), который является производным от Square (квадрат), который, в свою очередь – производный от Shape(фигура).
В классе Shape объявите следующие защищенные члены-данные : цвет линий фигуры и толщина ее линий  и напишите 2 конструктора - по умолчанию и с параметрами.
В классах Square и Rectangle объявите защищенные члены-данные для хранения размеров каждой из фигур,
несколько конструкторов, вызывающих конструкторы базового класса, а также методы для вычисления площади и периметра фигур. 
В классе Rectangle обязательно используйте перекрывание методов базового класса Square. 
При необходимости добавьте в классы  методы доступа.
Напишите главную программу, в которой выполните создание объектов-фигур различных типов и их обработку.

Измените классы Shape->Square->Rectangle из предыдущего задания на виртуальные.
Для этого добавьте в класс Shape пустые методы для вычисления площади и периметра и перекройте их виртуальными методами в производных классах.
Не забудьте также и про виртуальные деструкторы.

Объявите в главной программе два указателя типа Shape и создайте два объекта типа Square и Rectangle в свободной памяти, сохранив их адреса в этих указателях.
Выполните обработку объектов путем вызова как виртуальных, так и не виртуальных методов классов.
Уничтожьте объекты и обнулите их указатели.
*/

        static void Main(string[] args)
        {
            Square s1 = new Square("Black", 0.5, 4.0);
            Rectangle s2 = new Rectangle("Blue", 0.45, 5.0, 6.0);

            Console.WriteLine($"Square Perimeter= {s1.Perimeter()}\nSquare Area= {s1.Area()}");
            Console.WriteLine($"Rectangle Perimeter= {s2.Perimeter()}\nRectangle Area= {s2.Area()}");

           //unsafe указатели не работают
        }
    }
}