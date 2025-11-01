namespace Calculator
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Calculator");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.Write("Option: ");
            var inputString = Console.ReadLine();
            short input;

            if (!short.TryParse(inputString, out input)) { Error(); }

            if (input >= 1 && input <= 4) Calculate.Standard(input);
            else if (input == 5) Environment.Exit(0);
            else Error();
        }
        public static void Error()
        {
            Console.WriteLine("Please enter a valid number!");
            Console.ReadKey();
            Show();
        }
    }
}