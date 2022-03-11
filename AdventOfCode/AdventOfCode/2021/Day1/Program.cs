using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var measurements = ParseInput("2021/Day1/day1input.txt");

            var higher = 0;
            int? lastValue = null;

            foreach (int measurement in measurements)
            {
                if (lastValue == null)
                {
                    lastValue = measurement;
                    continue;
                }

                if (measurement > lastValue)
                    higher++;

                lastValue = measurement;
            }

            Console.WriteLine(higher);
        }

        private static List<int> ParseInput(string input)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), input);
            var lines = File.ReadAllLines(path);

            var list = new List<int>();

            foreach (string line in lines)
            {
                var measurement = int.Parse(line);
                list.Add(measurement);
            }

            return list;
        }
    }
}
