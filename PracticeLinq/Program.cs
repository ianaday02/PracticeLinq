using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> {"Call of Duty", "Mario Bros", "Just Dance", "Fall Guys" };


            var sorted = videoGames.OrderBy(x => x.Length).ToList<string>();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}

