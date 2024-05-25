// Программа для считывания данных из input.txt и проверки принадлежности точек цилиндрам

using System;
using System.IO;

class Program
{
    static void Main()
    {
        //Создание объекта класса "Прямой цилиндр" с данными от пользователя
        //Console.WriteLine("Введите данные для цилиндра (эллипса и высоты):");
        //string userInput = Console.ReadLine(); 

        // Не удалось реализовать ввод данных от пользователя 

        string path = @"C:\Users\user\Desktop\input.txt";
        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines)
        {
            try
            {
                string[] parts = line.Split('(', ',', ')', ' ');
                double r1 = double.Parse(parts[1]);
                double r2 = double.Parse(parts[2]);
                double h = double.Parse(parts[4]);

                Ellipse baseEllipse = new Ellipse(r1, r2);
                CylindricalShape cylinder = new CylindricalShape(baseEllipse, h);

                bool isInside = cylinder.IsPointInsideCylinder(cylinder);
                Console.WriteLine("Цилиндр с параметрами (" + r1 + "," + r2 + ") " + h + " внутри первого цилиндра: " + isInside);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при обработке строки: " + line + ". " + ex.Message);
            }
        }
    }
}
