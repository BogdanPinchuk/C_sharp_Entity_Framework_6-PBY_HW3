using LesAppCreateDB.Context;
using LesAppLib.Models;
using LesAppLib.Models.Add;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
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
                // realization of Include()
                Console.WriteLine($"\tWe realize the: Include()\n");
                foreach (Platform i in db.Platforms.Include(t => t.Critics))
                {
                    Show(i.ToString() ?? "null", ConsoleColor.Red);
                    foreach (Critic j in i.Critics)
                    {
                        Show("\t" + j.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                }

                // realization of Find()
                {
                    Console.WriteLine($"\nDevelopers are {db.Developers.Include(t => t.Id).Count()}");
                    int temp = rnd.Next(0, db.Developers.Count());
                    Console.WriteLine($"\tWe realize the: Find({temp})");
                    Show(db.Developers.Find(temp).ToString(), ConsoleColor.Red);
                }

                // Load data
                db.Critics.Load();
                db.Developers.Load();
                db.Directors.Load();
                db.Platforms.Load();
                db.Games.Load();
                db.NFS.Load();

                #region first experement
                // testing range of years when games was realised: 2007 < x < 2015
                {
                    Show($"\n Type of sorting is: where().where()", ConsoleColor.Green);
                    var query = db.Games
                        .Where(t => t.Release.Year >= 2007)
                        .Where(t => t.Release.Year <= 2012)
                        .ToList();
                    int j = 0;
                    foreach (var i in query)
                    {
                        Show($"\t{++j}. " + i.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                }

                // testing range of years when games was realised: 2007 < x < 2015
                {
                    Show($"\n Type of sorting is: where().tolist().where()", ConsoleColor.Green);
                    var query = db.Games
                        .Where(t => t.Release.Year >= 2007)
                        .ToList()
                        .Where(t => t.Release.Year <= 2012)
                        .ToList();
                    int j = 0;
                    foreach (var i in query)
                    {
                        Show($"\t{++j}. " + i.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                }

                // testing range of years when games was realised: 2007 <= x <= 2012
                {
                    Show($"\n Type of sorting is: where().select().where()", ConsoleColor.Green);
                    var query = db.Games
                        .Where(t => t.Release.Year >= 2007)
                        .Select(t => t)
                        .Where(t => t.Release.Year <= 2012)
                        .ToList();
                    int j = 0;
                    foreach (var i in query)
                    {
                        Show($"\t{++j}. " + i.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                }
                #endregion

                // Примітка. В даному прикладі не спостерігається, що подвійне використання
                // where() якось впливає на результат фільтрації, або ж є підтвердженням того,
                // що list() між where() можна замінити select()

                #region second experement
                // testing when games has range count platforms: 2 <= x <= 3
                {
                    Show($"\n Type of sorting is: where().where()", ConsoleColor.Green);
                    var query = db.Games
                        .Where(t => t.Platforms.Count >= 2)
                        .Where(t => t.Platforms.Count <= 3)
                        .ToList();
                    int j = 0;
                    foreach (var i in query)
                    {
                        Show($"\t{++j}. " + i.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                }

                // testing range of years when games was realised: 2007 < x < 2015
                {
                    Show($"\n Type of sorting is: where().tolist().where()", ConsoleColor.Green);
                    var query = db.Games
                        .Where(t => t.Platforms.Count >= 2)
                        .ToList()
                        .Where(t => t.Platforms.Count <= 3)
                        .ToList();
                    int j = 0;
                    foreach (var i in query)
                    {
                        Show($"\t{++j}. " + i.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                }

                // testing range of years when games was realised: 2007 < x < 2015
                {
                    Show($"\n Type of sorting is: where().select().where()", ConsoleColor.Green);
                    var query = db.Games
                        .Where(t => t.Platforms.Count >= 2)
                        .Select(t => t)
                        .Where(t => t.Platforms.Count <= 3)
                        .ToList();
                    int j = 0;
                    foreach (var i in query)
                    {
                        Show($"\t{++j}. " + i.ToString() ?? "null", ConsoleColor.Yellow);
                    }
                } 
                #endregion
            }

            Console.WriteLine("\nFinish");
            // delay
            Console.ReadKey(true);
        }

        /// <summary>
        /// Present result in color
        /// </summary>
        /// <param name="s">string data</param>
        /// <param name="color">color of text</param>
        private static void Show(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
