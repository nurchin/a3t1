namespace a3t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            int number ;
            number = int.Parse(Console.ReadLine());

            int count=0 ;

            if (number == 0 )
            {
                count = 1 ;
            }
            else if (number <0 ) { 
            number = -number ;
            
            }
            while (number > 0)
            {
                number = number / 10;
                count++;
            }

                Console.WriteLine($"Mertebe sayi: {count}");

            


        }
    }
}