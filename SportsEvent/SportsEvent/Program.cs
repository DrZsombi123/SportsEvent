using System;
using System.Collections.Generic;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace SportsEvent
{


    public class SportsEvent
    {
        public double[] scores = new double[8];
        /// &lt;summary&gt;
        /// This method prompts the user to enter in 8 scores and stores
        /// them in the array scores.
        /// &lt;/summary&gt;
        public void ReadScores()
        {
            Console.WriteLine("Enter Eight Contestant Scores:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Judge {i+1} --> ");
                double score = Convert.ToDouble(Console.ReadLine());
                scores[i] = score;
            }
        }
        /// &lt;summary&gt;
        /// Determines which score in scores is the lowest
        /// &lt;/summary&gt;
        /// &lt;returns&gt;The lowest score in scores&lt;/returns&gt;
        public double Lowest(double[] tomb)
        {
            double low = tomb[0];
            foreach (double elem in tomb) { 
                if (elem < low)
                {
                    low = elem;
                }
            }
            return low;
        }
        /// &lt;summary&gt;
        /// Determines which score in scores is the highest
        /// &lt;/summary&gt;
        /// &lt;returns&gt;The highest score in scores&lt;/returns&gt;
        public double Highest(double[] tomb)
        {
            double high = tomb[0];
            foreach (double elem in tomb)
            {
                if (elem > high)
                {
                    high = elem;
                }
            }
            return high;
        }
        /// &lt;summary&gt;
        /// Calculates the average of scores with the lowest and highest scores
        /// thrown out.
        /// &lt;/summary&gt;
        /// &lt;returns&gt;The average&lt;/returns&gt;
        public double Average(double[] tomb)
        {
            double sum = 0;

            
            
            foreach (double elem in tomb)
            {
             sum += elem;   
            }
            return (sum-(Highest(tomb)+Lowest(tomb)))/6;

        }

        /// &lt;summary&gt;
        /// This method prints a summary report which includes the original
        //list of
    /// scores, the average of the scores, the lowest score, and the
//high/*est sco*/re.
    /// &lt;/summary&gt;
public void PrintSummary()
        {
            Console.WriteLine("Summary Report".PadLeft(20));
            Console.WriteLine("-".PadLeft(30), ".-");
            for (int i = 0; i < scores.Length; i++) {
                Console.Write($"{scores[i]} ");
            }
            Console.WriteLine($"Lowest Score = {Lowest(scores)}");
            Console.WriteLine($"Highest Score = {Highest(scores)}");
            Console.WriteLine($"Average Score = {Average(scores)}");

        }
        /// &lt;summary&gt;
        /// Program entry point.
        /// &lt;/summary&gt;
        /// &lt;param name=&quot;args&quot;&gt;Command-line arguments&lt;/param&gt;
        public static void Main(string[] args)
        {
            SportsEvent app = new SportsEvent();
            app.ReadScores();
            
            app.PrintSummary();
        }
    }
}
