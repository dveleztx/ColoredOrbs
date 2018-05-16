using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredOrbs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int randomNumber;

            // Create Orbs
            Orb[] orbs = new Orb[2];
            orbs[0] = new Orb(new Color(150, 100, 40, 200), 10, 0);
            orbs[1] = new Orb(new Color(100, 0, 50), 5);

            // Create Random Object
            Random random = new Random();

            // Get Color Schema of orb1
            Console.WriteLine($"Orb 1's blue value: {orbs[0].GetColor().GetBlue()}");
            Console.WriteLine($"Orb 1's green value: {orbs[0].GetColor().GetGreen()}");
            Console.WriteLine($"Orb 1's red value: {orbs[0].GetColor().GetRed()}");
            Console.WriteLine($"Orb 1's alpha value: {orbs[0].GetColor().GetAlpha()}");

            // Get Color Schema of orb2
            Console.WriteLine($"Orb 2's blue value: {orbs[1].GetColor().GetBlue()}");
            Console.WriteLine($"Orb 2's green value: {orbs[1].GetColor().GetGreen()}");
            Console.WriteLine($"Orb 2's red value: {orbs[1].GetColor().GetRed()}");
            Console.WriteLine($"Orb 2's alpha value: {orbs[1].GetColor().GetAlpha()}");

            // Randomly Throw Orbs
            while (true)
            {
                randomNumber = random.Next(0, 2);
                orbs[randomNumber].Throw();

                if (orbs[0].GetTimesThrown() == 50)
                {
                    orbs[0].Pop();
                }

                if (orbs[1].GetTimesThrown() == 50)
                {
                    orbs[1].Pop();
                }

                Console.WriteLine($"Number of times Orb 1 has been thrown: {orbs[0].GetTimesThrown()}");
                Console.WriteLine($"Number of times Orb 2 has been thrown: {orbs[1].GetTimesThrown()}");

                if (orbs[0].GetSize() == 0 && orbs[1].GetSize() == 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            // Verify Orbs were thrown 100 times
            Console.WriteLine($"Orb 1 was thrown: {orbs[0].GetTimesThrown()} times.");
            Console.WriteLine($"Orb 2 was thrown: {orbs[1].GetTimesThrown()} times.");

            Console.ReadKey();
        }
    }
}
