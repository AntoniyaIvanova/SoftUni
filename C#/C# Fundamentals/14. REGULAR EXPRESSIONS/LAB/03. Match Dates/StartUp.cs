﻿namespace _03._Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match date in matches)

            Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: { date.Groups["month"].Value}, Year: { date.Groups["year"].Value}");
        }
    }
}