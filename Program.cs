namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Func<int, int> square = x => x * x;
            Func<int, int> square = (x) =>
            {
                Console.WriteLine(x);
                return x * x;
            };
            int result = square(6);
                Console.WriteLine(result);

            MathOperation mathOperation = add;
            int result2 = mathOperation(3,5);
            Console.WriteLine(result2);

            mathOperation = multiply;
            int result3 = mathOperation(4,6);
            Console.WriteLine(result3);
        }

        public delegate int MathOperation(int a, int b);
        static int add(int a, int b) => a+b;
        static int multiply(int a, int b) => a*b;
        static void abc() { }
    }
}