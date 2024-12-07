using System;

public class Rectangle
{
    protected double a1, a2, b1, b2; // Коефіцієнти прямокутника
    protected double x, y; // Координати точки

    // Віртуальний метод для задання коефіцієнтів
    public virtual void SetCoefficients()
    {
        Console.WriteLine("Enter coefficient a1 (right edge): ");
        a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b1 (left edge): ");
        b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient a2 (top edge): ");
        a2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b2 (bottom edge): ");
        b2 = double.Parse(Console.ReadLine());
    }

    // Віртуальний метод для перевірки точки
    public virtual void CheckPoint()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());

        if (b1 <= x && x <= a1 && b2 <= y && y <= a2)
        {
            Console.WriteLine("The point is inside the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is outside the rectangle.");
        }
    }

    // Віртуальний метод для виведення коефіцієнтів
    public virtual void DisplayCoefficients()
    {
        Console.WriteLine($"Rectangle coefficients: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}");
    }
}

public class Parallelepiped : Rectangle
{
    private double a3, b3; // Додаткові коефіцієнти
    private double z; // Координата z для точки

    // Перевизначений метод для задання коефіцієнтів
    public override void SetCoefficients()
    {
        base.SetCoefficients();
        Console.WriteLine("Enter coefficient a3 (top edge in z): ");
        a3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b3 (bottom edge in z): ");
        b3 = double.Parse(Console.ReadLine());
    }

    // Перевизначений метод для перевірки точки
    public override void CheckPoint()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        z = double.Parse(Console.ReadLine());

        if (b1 <= x && x <= a1 && b2 <= y && y <= a2 && b3 <= z && z <= a3)
        {
            Console.WriteLine("The point is inside the parallelepiped.");
        }
        else
        {
            Console.WriteLine("The point is outside the parallelepiped.");
        }
    }

    // Перевизначений метод для виведення коефіцієнтів
    public override void DisplayCoefficients()
    {
        Console.WriteLine($"Parallelepiped coefficients: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}, a3 = {a3}, b3 = {b3}");
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        Rectangle obj;
        Console.WriteLine("Enter '1' for Rectangle or '2' for Parallelepiped:");
        int choice = int.Parse(Console.ReadLine());

        // Динамічний вибір класу на основі вводу користувача
        if (choice == 1)
        {
            obj = new Rectangle();
        }
        else if (choice == 2)
        {
            obj = new Parallelepiped();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            return;
        }

        // Виклик методів через базовий клас
        obj.SetCoefficients();
        obj.CheckPoint();
        obj.DisplayCoefficients();
    }
}
