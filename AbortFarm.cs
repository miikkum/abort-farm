using System;
using System.Collections;

namespace AbortFarm
{
    class Source
    {
        static string resource = "Aya";
        string name;
        int stages;
        int[] clearSeconds;
        double[] dropRates;
        public Source(string name, int stages, int[] clearSeconds, double[] dropRates)
        {
            this.name = name;
            this.stages = stages;
            this.clearSeconds = clearSeconds;
            this.dropRates = dropRates;
        }
        static void Main(string[] args)
        {
            ArrayList sources = new ArrayList();

            // 4 parameters for a drop location: name, number of stages, list of completion times up to and including a stage
            // ({120,240} means a minute for stage 1, two minutes to complete two stages), list of drop rates per stage
            // If a stage has a bonus drop (i.e. open world bounties), just add the drop rate again at the end
            // Example attributes;
            // "Cambion Drift bounty 5-15", 3, new int[] { 84, 164, 240 }, new double[] { 0, 0.0752, 0.3056, 0.3056 }
            // Name is "Cambion Drift bounty 5-15", and it has 3 stages that take 84, 164 and 240 seconds to complete up to stage 1, 2 and 3, respectively
            // The drop rates for each stage for the resource is 0%, 7.52% and 30.56% for each stage, but since there is a possible bonus, we specify 30.56% again


            // List the sources for the resource and attached drop rates
            // TODO: Times are fictional, so more 'real' times should be added. Cambion drift endless is weird, so it's not correctly implemented. At all.

            Source ghoul15 = new Source("Ghoul Purge 15-25",4,new int[] { 73, 164, 240, 320 }, new double[]{ 0.2647, 0.0874, 0.0874,0 }); sources.Add(ghoul15);
            //Source ghoul40 = new Source("Ghoul Purge 40-50",4, new int[] { 90, 165, 240, 320 }, new double[] { 0.2647, 0.0874, 0.0874, 0 }); sources.Add(ghoul40);
            //Source cetus10 = new Source("Cetus bounty 10-30",3, new int[] { 84, 164, 240 }, new double[] { 0, 0.0588, 0.1458, 0.1458 }); sources.Add(cetus10);
            //Source cetus20A = new Source("Cetus bounty 20-40 Rotation A", 4, new int[] { 84, 164, 240, 320 }, new double[] { 0, 0.0734, 0.0734, 0.2, 0.2 }); sources.Add(cetus20A);
            //Source cetus20B = new Source("Cetus bounty 20-40 Rotation B", 4, new int[] { 84, 164, 240, 320 }, new double[] { 0, 0.0814, 0.0814, 0.2059, 0.2059 }); sources.Add(cetus20B);
            //Source cetus20C = new Source("Cetus bounty 20-40 Rotation C", 4, new int[] { 84, 164, 240, 320 }, new double[] { 0, 0.0867, 0.0867, 0.2174, 0.2174 }); sources.Add(cetus20C);
            //Source cetus30AB = new Source("Cetus bounty 30-50 Rotation A & B", 5, new int[] { 84, 164, 240, 320, 400 }, new double[] { 0, 0.1124, 0.1124, 0.1099, 0.2703, 0.2703 }); sources.Add(cetus30AB);
            //Source cetus30C = new Source("Cetus bounty 30-50 Rotation C", 5, new int[] { 84, 164, 240, 320, 400 }, new double[] { 0, 0.1087, 0.1087, 0.1064, 0.2778, 0.2778 }); sources.Add(cetus30C);
            Source cetus40 = new Source("Cetus bounty 40-60", 5, new int[] { 84, 164, 240, 320, 400 }, new double[] { 0, 0.3304, 0.3304, 0.2568, 0.3878, 0.3878 }); sources.Add(cetus40);
            //Source vallis5 = new Source("Orb Vallis bounty 5-15", 3, new int[] { 84, 164, 240 }, new double[] { 0, 0, 0.0833, 0.0833 }); sources.Add(vallis5);
            //Source vallis10 = new Source("Orb Vallis bounty 10-30", 3, new int[] { 84, 164, 240 }, new double[] { 0, 0.0588, 0.2, 0.2 }); sources.Add(vallis10);
            //Source vallis20 = new Source("Orb Vallis bounty 20-40", 4, new int[] { 84, 164, 240, 300 }, new double[] { 0, 0.125, 0.125, 0.25, 0.25 }); sources.Add(vallis20);
            //Source vallis30 = new Source("Orb Vallis bounty 30-50", 5, new int[] { 84, 164, 240, 300, 370 }, new double[] { 0, 0.1473, 0.1473, 0.1304, 0.4488, 0.4488 }); sources.Add(vallis30);
            Source vallis40 = new Source("Orb Vallis bounty 40-60", 5, new int[] { 84, 164, 240, 300, 370 }, new double[] { 0, 0.25, 0.25, 0.2143, 0.5, 0.5 }); sources.Add(vallis40);
            //Source necralisk5 = new Source("Cambion Drift bounty 5-15", 3, new int[] { 84, 164, 240 }, new double[] { 0, 0.0752, 0.3056, 0.3056 }); sources.Add(necralisk5);
            //Source necralisk15 = new Source("Cambion Drift bounty 15-25", 3, new int[] { 84, 164, 240 }, new double[] { 0, 0.1471, 0.2, 0.2 }); sources.Add(necralisk15);
            //Source necralisk25A = new Source("Cambion Drift bounty 25-30 (Endless Rotation A)", 3, new int[] { 84, 164, 240 }, new double[] { 0.0526, 0.0526, 0.0649 }); sources.Add(necralisk25A);
            //Source necralisk25B = new Source("Cambion Drift bounty 25-30 (Endless Rotation B)", 3, new int[] { 84, 164, 240 }, new double[] { 0.1429, 0.1118, 0.0886 }); sources.Add(necralisk25B);
            //Source necralisk25C = new Source("Cambion Drift bounty 25-30 (Endless Rotation C)", 3, new int[] { 84, 164, 240 }, new double[] { 0.0526, 0.0649, 0.0886 }); sources.Add(necralisk25C);
            //Source necralisk30 = new Source("Cambion Drift bounty 30-40", 5, new int[] { 84, 164, 240, 300, 370 }, new double[] { 0, 0.1781, 0.1781, 0.1398, 0.2453, 0.2453 }); sources.Add(necralisk30);
            Source necralisk40 = new Source("Cambion Drift bounty 40-60", 5, new int[] { 84, 164, 240, 300, 370 }, new double[] { 0, 0.2857, 0.2857, 0.2222, 0.4348, 0.4348 }); sources.Add(necralisk40);
            Source ukko = new Source("Ukko Capture", 1, new int[] { 60 }, new double[] { 0.0833 }); sources.Add(ukko);

            string minString = "";
            int min = 20000;

            // To get the average time per resource, we use [time for completion] / [resource drop rate]
            // Since we're looking at multiple consecutive stages we need to use some probability theory
            // If a stage has 25% drop and the next stage has 20% drop rate, we check the compound probability like so;
            // 1 - ([Probability of NOT getting resource from stage 1] * [Probability of NOT getting resource from stage 2])
            // 1 - (0.75 * 0.8) = 1 - 60% = 40%. In this example, we expect getting the resource 40% of the time if we do two stages before aborting
            foreach (Source s in sources)
            {
                // We want to evaluate aborting after each stage to find how many stages we want to complete
                for (int i = 0; i < s.stages; i++)
                {
                    double prob = 1;
                    double bonusprob = 1;
                    for(int j = 0; j <= i; j++)
                    {
                        // Probability of NOT getting the resource
                        prob *= (1-s.dropRates[j]);
                        if( j == s.stages-1 && s.dropRates.Length > s.stages)
                        {
                            bonusprob = prob*(1 - s.dropRates[j+1]);
                        }
                    }

                    // The probability of actually getting the resource = 100% - Chance not getting the resource
                    prob = (1 - prob);
                    bonusprob = (1 - bonusprob);

                    if(prob != 0)
                    {
                        // We can store the fastest found method
                        if (s.clearSeconds[i] / prob < min)
                        {
                            min = (int)(s.clearSeconds[i] / prob);
                            minString = "Fastest: " + s.name + " stage " + (i + 1) + " - " + (int)(s.clearSeconds[i]/prob) + " seconds per " + resource;
                        }
                        // Print evaluation for each stage (seconds per resource)
                        Console.WriteLine(s.name + " stage " + (i+1) + " (" + s.clearSeconds[i] + "s): " + (int)(s.clearSeconds[i] / prob) + " seconds per " + resource);
                        // Check if there is a bonus attached to the bounty and how it affects the efficiency
                        if (bonusprob != 0)
                        {
                            if (s.clearSeconds[i] / bonusprob < min)
                            {
                                min = (int)(s.clearSeconds[i] / bonusprob);
                                minString = "Fastest: " + s.name + " stage " + (i + 1) + " with bonus - " + (int)(s.clearSeconds[i] / bonusprob) + " seconds per " + resource;
                            }
                            Console.WriteLine(s.name + " stage " + (i + 1) + " with bonus (" + s.clearSeconds[i] + "s): " + (int)(s.clearSeconds[i] / bonusprob) + " seconds per " + resource);
                        }
                    }
                }
            }

            // Print the fastest method
            Console.WriteLine();
            Console.WriteLine(minString);
        }
    }
}
