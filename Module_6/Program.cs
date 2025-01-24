namespace Module_6;

class Program
{
    class Circle
    {
        private double radius;
        public double Area => radius * radius * Math.PI;
        public double Curcumference => 2.0 * radius * Math.PI;
        public Circle(double radius)
        {
            this.radius = radius;
        }
    }

    class Triangle
    {
        private double a, b, c;
        public double Area => (a + b + c) / 2.0 * Math.Sqrt(a * a + b * b - c * c);
        public double Perimeter => a + b + c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    class Rectangle
    {
        private double a, b;
        
        public double Area => a * b;
        public double Perimeter => 2 * (a + b);

        public Rectangle()
        {
            a = 8;
            b = 10;
        }
        public Rectangle(double side)
        {
            a = b = side;
        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }
    
    static void Main( string[] args)
    {
        var circle = new Circle(10);
        Console.WriteLine($"Circle area: {circle.Area:F1}");
        Console.WriteLine($"Circle circumference: {circle.Curcumference:F1}");
        
        var triangle = new Triangle(10, 10, 10);
        Console.WriteLine($"Triangle area: {triangle.Area}");
        Console.WriteLine($"Triangle perimeter: {triangle.Perimeter}");

        var rectangle = new Rectangle(25);
        Console.WriteLine($"Rectangle area: {rectangle.Area}");
        Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");
    }
}