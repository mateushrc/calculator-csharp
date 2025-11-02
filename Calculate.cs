namespace Calculator
{
    static class Calculate
    {
        public static void Standard(int input)
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            var inputString = Console.ReadLine();
            double x;

            if (!double.TryParse(inputString, out x)) { Menu.Error(); }
            Console.WriteLine("Enter the second value: ");
            inputString = Console.ReadLine();
            double y;

            if (!double.TryParse(inputString, out y)) { Menu.Error(); }
            var result = 0d;

            switch (input)
            {
                case 1: result = Sum(x, y); break;
                case 2: result = Subtraction(x, y); break;
                case 3: result = Multiplication(x, y); break;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Division by zero is impossible!");
                        Console.WriteLine("Press any key to return!");
                        Console.ReadKey();
                        Menu.Show();
                    }
                    else result = Division(x, y);
                    break;
            }

            Console.WriteLine($"Your result is: {result}");
            Console.WriteLine("Press any key to return!");
            Console.ReadKey();
            Menu.Show();

        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Subtraction(double x, double y)
        {
            return x - y;
        }
        public static double Multiplication(double x, double y)
        {
            return x * y;
        }
        public static double Division(double x, double y)
        {
            return x / y;
        }
    }
}