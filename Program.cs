namespace Chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en siffra! ");
            int number = int.Parse(Console.ReadLine()); //omvandlar användarens svar till ett heltal


            for (int i = 0; i < number; i++) //En for loop för varje rad
            {
                

                for (int x = 0; number > x; x = x + 1) // en loop för antal pjäser
                {
                    Console.Write("0");
                    x++;

                    //Gör en if sats för att skriva ut exakt hur många pjäser som anges
                    if (number > x)  // Villkor
                    {
                        Console.Write("X");
                    }

                }
                Console.WriteLine(""); // Ny rad efter varje loop
            }


        }





    }
}
