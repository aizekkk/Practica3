
using System;

class Point
{
   
    private int x;
    private int y;

   
    public Point()
    {
        x = 0;
        y = 0;
    }

   
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

   
    public int X
    {
        get { return x; }
        set { x = value; }
    }

  
    public int Y
    {
        get { return y; }
        set { y = value; }
    }


    public int Scalar
    {
        set
        {
            x *= value;
            y *= value;
        }
    }

   
    public void Show()
    {
        Console.WriteLine($"Точка: ({x}, {y})");
    }

    public double Distance()
    {
        return Math.Sqrt(x * x + y * y);
    }

   
    public void Move(int a, int b)
    {
        x += a;
        y += b;
    }

   
    public int this[int index]
    {
        get
        {
            if (index == 0)
                return x;
            else if (index == 1)
                return y;
            else
                throw new IndexOutOfRangeException(
                    "Ошибка: индекс должен быть 0 или 1.");
        }

        set
        {
            if (index == 0)
                x = value;
            else if (index == 1)
                y = value;
            else
                throw new IndexOutOfRangeException(
                    "Ошибка: индекс должен быть 0 или 1.");
        }
    }

  
    public static Point operator ++(Point p)
    {
        p.x++;
        p.y++;
        return p;
    }

   
    public static Point operator --(Point p)
    {
        p.x--;
        p.y--;
        return p;
    }

  
    public static bool operator true(Point p)
    {
        return p.x == p.y;
    }

    
    public static bool operator false(Point p)
    {
        return p.x != p.y;
    }

   
    public static Point operator +(Point p, int scalar)
    {
        return new Point(p.x + scalar, p.y + scalar);
    }
}

class Program
{
    static void Main()
    {
       
        Point p1 = new Point();

       
        Point p2 = new Point(3, 4);

        Console.WriteLine("Начальные точки:");
        p1.Show();
        p2.Show();

      
        Console.WriteLine(
            $"Расстояние до точки p2: {p2.Distance()}");

     
        p2.Move(2, 3);
        Console.WriteLine("\nПосле перемещения p2 на (2, 3):");
        p2.Show();

     
        p2.X = 10;
        p2.Y = 10;

        Console.WriteLine("\nПосле изменения координат:");
        p2.Show();

     
        Console.WriteLine($"\np2[0] = {p2[0]}");
        Console.WriteLine($"p2[1] = {p2[1]}");

      
        p2.Scalar = 2;

        Console.WriteLine("\nПосле умножения на 2:");
        p2.Show();

       
        p2++;
        Console.WriteLine("\nПосле p2++:");
        p2.Show();

    
        p2--;
        Console.WriteLine("\nПосле p2--:");
        p2.Show();

     
        Point p3 = p2 + 5;

        Console.WriteLine("\nПосле p2 + 5:");
        p3.Show();

      
        if (p2)
            Console.WriteLine("\nУ p2 координаты X и Y совпадают.");
        else
            Console.WriteLine("\nУ p2 координаты X и Y не совпадают.");
    }
}
