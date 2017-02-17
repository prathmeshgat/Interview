using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTitan
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] votes = new string[] { "Victor","Veronica","Ryan","Maria","Maria","Frah","Farah","Ryan", "Veronica" };

            string[] votes = new string[] {"a"};

            Console.WriteLine( electionWinner(votes));

            Console.Read();
        }

        static string electionWinner(string[] votes)
        {

            try
            {
                if (votes.Length == 0)
                    return null;

                Dictionary<string, int> votesDict = new Dictionary<string, int>();

                foreach (var item in votes)
                {
                    if (votesDict.ContainsKey(item))
                        votesDict[item]++;
                    else
                        votesDict[item] = 1;
                }
               
                var item1 = votesDict.Values.Max();

                List<string> finalCandidates = new List<string>();

                foreach (var item in votesDict)
                {

                    if (item.Value == item1)
                        finalCandidates.Add(item.Key);
                }

                finalCandidates = finalCandidates.OrderBy(x => x).ToList();

                return finalCandidates.Last();
            }
            catch(Exception)
            {
                return null;
            }
            
        }
    }
}
