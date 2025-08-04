namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaofCircle()
        {
            Console.WriteLine("what is the area of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"This area of a circle with a raadius of {radius} is {Math.Round(AreaOfCircle(radius),2)}");
        }
        
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
           
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            PrintAreaofCircle();
            
        }
    }
}
