using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other_pizza_thing
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizza = Input("Enter your pizza");

            switch (pizza)
            {
                case "Cheese":
                case "Margharita":
                    Console.WriteLine("Vegetarian!");
                    break;

                case "Mighty meaty":
                case "Pepperoni":
                case "Ham":
                    Console.WriteLine("Not vegetarian");
                    break;
            }

            string music = Input("Favourite genre of music?");

            switch (music)
            {
                case "Classical":
                case "Pop":
                case "J-Pop":
                case "K-pop":
                    Console.WriteLine("Not a fan...");
                    break;

                case "Alternative":
                case "Rock":
                case "Metal":
                case "Indie":
                    Console.WriteLine("Yayyyy!");
                    break;

                case "Jazz":
                    Console.WriteLine("According to all known laws of aviation,\nthere is no way a bee should be able to fly.\nIts wings are too small to get its fat little body off the ground.\nThe bee, of course, flies anyway,\nbecause bees don't care what humans think is impossible.");
                    break;

                default:
                    Console.WriteLine("I NEED TO KNOW.");
                    break;
            }
        }


        /// <summary>
        /// Asks a question for the user
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The answer to said question</returns>
        private static string Input(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

    }
}
