namespace method_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial5 = calculateFactorial(5);
            Console.WriteLine(factorial5);
            Console.WriteLine(calculateFactorial(2));
            
        }
        static void getManu ()
        {
            Console.WriteLine(" Hello, This is Menue ");
            Console.WriteLine("1 - add");
            Console.WriteLine("2 - Divide");
        }
        //ggg
        static int calculateFactorial (int number )
        {
            int fact2 = 1;
            for( int i = number; i >1 ; i--)
            {
                fact2=fact2 * i;
                
            }
            return fact2;
        }
    }
}