using System;
using System.Collections.Generic;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                Console.Clear();
                using (StreamReader sr = File.OpenText(path)) {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream) {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate)) {
                            dictionary[candidate] += votes;
                        }
                        else {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictionary) {
                        System.Console.WriteLine(item.Key + ": " + item.Value);
                    }
                 Console.Clear();    
                }
            }
            catch (IOException e) {
                System.Console.WriteLine("An error occurred");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}