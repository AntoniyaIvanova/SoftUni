namespace _06._Songs_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] songs = Console.ReadLine()
                            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(songs);

            while (true)
            {
                if (!queue.Any())
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string song = tokens.Skip(1).ToString();

                if(command == "Play")
                {
                    queue.Dequeue();
                }
                else if(command == "Add")
                {                    
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        return;
                    }
                    queue.Enqueue(song);
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Format(", ", queue));
                }
            }
        }
    }
}
