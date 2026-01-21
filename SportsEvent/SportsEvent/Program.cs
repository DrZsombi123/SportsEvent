using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace SportsEvent
{


    public class SportsEvent
    {
        private double[] scores = new double[8];
        /// &lt;summary&gt;
        /// This method prompts the user to enter in 8 scores and stores
        /// them in the array scores.
        /// &lt;/summary&gt;
        public void ReadScores()
        {
            // TODO : Implement reading 8 scores from the user
        }
        /// &lt;summary&gt;
        /// Determines which score in scores is the lowest
        /// &lt;/summary&gt;
        /// &lt;returns&gt;The lowest score in scores&lt;/returns&gt;
        public double Lowest()
        {
            // TODO : Determine the lowest score
            return 0;
        }
        /// &lt;summary&gt;
        /// Determines which score in scores is the highest
        /// &lt;/summary&gt;
        /// &lt;returns&gt;The highest score in scores&lt;/returns&gt;
        public double Highest()
        {
            // TODO : Determine the highest score
            return 0;
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
            // TODO : Print summary report
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
