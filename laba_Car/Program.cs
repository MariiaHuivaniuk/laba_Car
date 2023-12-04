using System;

class Car
{
    public string Name;
    public string Color;
    public double Price;
    public const string CompanyName = "YourCompany";


    public Car()
    {
    }

   
    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

   
    public void Input()
    {
        Console.WriteLine("car details= ");
        Console.Write("Name= ");
        Name = Console.ReadLine();

        Console.Write("Color= ");
        Color = Console.ReadLine();

        Console.Write("Price= ");
        Price = Convert.ToDouble(Console.ReadLine());
    }

  
    public void Print()
    {
        Console.WriteLine($"Car details:\nName: {Name}\nColor: {Color}\nPrice: {Price:C}\nCompany: {CompanyName}");
    }

   
    public void ChangePrice(double percentage)
    {
        Price *= (1 - percentage / 100);
    }

   
    public void ChangeColor(string newColor)
    {
        if (Color.ToLower() == "white")
        {
            Color = newColor;
            Console.WriteLine($"Колір автомобіля змінено на {newColor}.");
        }
        else
        {
            Console.WriteLine("Перефарбовувати можна тільки білі машини. Поточний колір залишається незмінним.");
        }
    }


    public string PrintInfo()
    {
        return $"Car details: Name - {Name}, Color - {Color}, Price - {Price:C}, Company - {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
       
        Car[] cars = new Car[3];

        
        for (int i = 0; i < 3; i++)
        {
            cars[i] = new Car();
            cars[i].Input();
        }

        
        foreach (var car in cars)
        {
            car.ChangePrice(10);
        }

        Console.WriteLine("\nАвтомобілі після зниження цін на 10%:");
        foreach (var car in cars)
        {
            car.Print();
        }

        Console.Write("\nВведіть новий колір для перефарбування білих автомобілів: ");
        string newColor = Console.ReadLine();

        foreach (var car in cars)
        {
            car.ChangeColor(newColor);
        }

       
        Console.WriteLine("\nІнформація про автомобіль:");
        foreach (var car in cars)
        {
            Console.WriteLine(car.PrintInfo());
        }
    }
}