namespace Module_6;

class Program
{
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    private class Car(double fuel = 10.0, int mileage = 100_000, TurnDirection turn = TurnDirection.None)
    {
        private double _fuel = fuel;
        private int _mileage = mileage;
        private TurnDirection _turn = turn;

        public void FillTank()
        { 
            _fuel = 50;
        }

        private void Drive()
        {
            _mileage++;
            _fuel -= 0.5;
        }

        private void Turn(TurnDirection turn)
        {
            _turn = turn;
        }

        public double CheckFuel() => _fuel;
        public int CheckMileage() => _mileage;
        public void Run()
        {
            Drive();   
        }
        public bool IsTurningLeft() => _turn == TurnDirection.Left;
        public bool IsTurningRight() => _turn == TurnDirection.Right;
    }
    
    
    static void Main( string[] args)
    {
        var car = new Car();

        car.Run();
        Console.WriteLine("Car is running...");
        Console.WriteLine($"Car fuel: {car.CheckFuel()}");
        Console.WriteLine($"Car mileage: {car.CheckMileage()}");
    }
}