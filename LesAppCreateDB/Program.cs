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
                db.Games.Load();
                db.EA.Load();
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
