using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    internal class ProgramExerciseVotation
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Votation: ");
            Console.WriteLine("-------------------------");
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    int totalVotes = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }

                        totalVotes += votes;
                    }
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);

                    }
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Total Votes: " + totalVotes);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}