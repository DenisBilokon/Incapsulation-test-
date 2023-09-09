using System;

public class Car
{
   
    private string make;   //cкрытые 
    private string model;
    private int year;
    private double speed;

    // Конструктор класса
    public Car(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.speed = 0; 
    }

    // Метод для скорости
    public void SetSpeed(double newSpeed)
    {
        if (newSpeed >= 0)
        {
            speed = newSpeed;
        }
        else
        {
            Console.WriteLine("Скорость не может быть отрицательной.");
        }
    }

    public double GetSpeed()
    {
        return speed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {make}, Модель: {model}, Год выпуска: {year}");
        Console.WriteLine($"Скорость: {speed} км/ч");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Corola", 2020); //Тойота корола или королла ?
        Car myCar2 = new Car("BMW", "7", 2015);
       
        myCar.SetSpeed(60);
        myCar2.SetSpeed(0);

        double currentSpeed = myCar.GetSpeed();
        double currentSpeed2 = myCar2.GetSpeed();

        myCar.DisplayInfo();
        Console.WriteLine($"Текущая скорость: {currentSpeed} км/ч");

        myCar2.DisplayInfo();

    }
}
