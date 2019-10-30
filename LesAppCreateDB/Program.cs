using LesAppCreateDB.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAppCreateDB
{
    class Program
    {
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

                Show(db.Critics.Local);
                Show(db.Developers.Local);
                Show(db.Platforms.Local);
                Show(db.Games.Local);
                Show(db.NFS.Local);
            }

            Console.WriteLine("Finish");
            // delay
            Console.ReadKey(true);
        }

        private static void Show<T>(IEnumerable<T> data)
        {
            foreach (var i in data)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\n" + new string('#', 80) + "\n");
        }
    }
}
