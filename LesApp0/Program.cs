using LesAppCreateDB.Context;
using LesAppLib.Models;
using LesAppLib.Models.Add;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        private static readonly Random rnd = new Random();

        static void Main()
        {
            // join unicode
            Console.OutputEncoding = Encoding.Unicode;

            // connect to DataBase
            using (NFSContext db = new NFSContext())
            {
                // завантаження даних
                db.Critics.Load();
                db.Developers.Load();
                db.Directors.Load();
                db.Platforms.Load();
                db.Games.Load();
                db.NFS.Load();

                // realization of First()
                {
                    Console.WriteLine($"Developers are {db.Developers.Count()}");
                    int temp = rnd.Next(0, db.Developers.Count());
                    Console.WriteLine($"\tWe realize the: Find({temp})");
                    Show(db.Developers.Find(temp).ToString(), ConsoleColor.Red);
                }

                // realization of FirstOrDefault()
                {
                    Console.WriteLine($"\nDevelopers are {db.Developers.Count()}");
                    int temp = rnd.Next(db.Developers.Count() + 1, db.Developers.Count() + 11);
                    Console.WriteLine($"\tWe realize the: FirstOrDefault({temp})");
                    Show(db.Developers.FirstOrDefault(t => t.Id == temp)?.ToString() ?? "null", ConsoleColor.Red);
                }

                // realization of OrderBy()
                {
                    Console.WriteLine($"\nPlatforms are {db.Platforms.Count()}");
                    var query = db.Platforms.OrderBy(t => t.Name).ToList();
                    Console.WriteLine($"\tWe realize the: OrderBy(t => t.Name)");
                    foreach (Platform i in query)
                    {
                        Show(i.ToString() ?? "null", ConsoleColor.Green);
                    }
                }

                // realization of Min()
                {
                    Console.WriteLine($"\nGames are {db.Games.Count()}");
                    int temp = db.Games?.Min(t => t.Platforms.Count) ?? 0;
                    Console.WriteLine($"\tWe realize the: Min(t => t.Platforms.Count)");
                    Show($"Minimum count of support platforms are {temp.ToString()}", ConsoleColor.Yellow);
                    var query = db.Games.Where(t => t.Platforms.Count == temp).ToList();
                    foreach (Game i in query)
                    {
                        Show(i.ToString() ?? "null", ConsoleColor.Red);
                        foreach (Platform j in i.Platforms)
                        {
                            Show("\t" + j.ToString() ?? "null", ConsoleColor.Yellow);
                        }
                    }
                }

                // realization of Maх()
                {
                    Console.WriteLine($"\nGames are {db.Games.Count()}");
                    int temp = db.Games?.Max(t => t.Platforms.Count) ?? 0;
                    Console.WriteLine($"\tWe realize the: Max(t => t.Platforms.Count)");
                    Show($"Maximum count of support platforms are {temp.ToString()}", ConsoleColor.Yellow);
                    var query = db.Games.Where(t => t.Platforms.Count == temp).ToList();
                    foreach (Game i in query)
                    {
                        Show(i.ToString() ?? "null", ConsoleColor.Red);
                        foreach (Platform j in i.Platforms)
                        {
                            Show("\t" + j.ToString() ?? "null", ConsoleColor.Yellow);
                        }
                    }
                }

                // realization of Average()
                {
                    Console.WriteLine($"\nGames are {db.Games.Count()}");
                    double temp = db.Games?.Average(t => t.Platforms.Count) ?? 0;
                    Console.WriteLine($"\tWe realize the: Average(t => t.Platforms.Count)");
                    Show($"Average count of support platforms are {temp:N2}", ConsoleColor.Yellow);
                }

            }

            Console.WriteLine("\nFinish");
            // delay
            Console.ReadKey(true);
        }

        /// <summary>
        /// Present result in color
        /// </summary>
        /// <param name="s">string data</param>
        /// <param name="color">console color</param>
        private static void Show(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
