using LesAppLib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace LesAppCreateDB.Context
{
    /// <summary>
    /// Ініціаолізатор бази даних
    /// </summary>
    public class ContextInitializer : DropCreateDatabaseAlways<NFSContext>
    {
        protected override void Seed(NFSContext db)
        {
            // створення БД ігор
            List<Game> games = new List<Game>();

            games.Add(new Game()
            {
                Name = "The Need for Speed",
                Release = new DateTime(1994, 8, 31),
            });

        }
    }
}