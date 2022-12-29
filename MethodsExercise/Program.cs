namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Questions();

            int answer = Add(5, 2);
            Console.WriteLine(answer);
            int answer2 = Subtract(6, 3);
            Console.WriteLine(answer2);
            int answer3 = Multiply(10, 4);
            Console.WriteLine(answer3);
            int answer4 = Divide(64, 8);
            Console.WriteLine(answer4);
            double answer5 = Modulus(15, 2.6);
            Console.WriteLine(answer5);

        }

        public static void Questions()
        {
            Console.WriteLine("What is your name?");    

            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();
            Console.WriteLine($"{userName}, whose favorite color is {userColor}, was walking along and attacked by his favorite animal, which is a/n {userAnimal}, while listening to and his favorite band, {userBand}");

        }

        public static int Add(int x, int y)
        { return x + y; }
        public static int Subtract(int x, int y)
        { return x - y; }
        public static int Multiply(int x, int y)
        { return x * y; }
        public static int Divide(int x, int y)
        { return x / y; }   
        public static double Modulus(double x, double y)
        { return x % y; }

    }
}
