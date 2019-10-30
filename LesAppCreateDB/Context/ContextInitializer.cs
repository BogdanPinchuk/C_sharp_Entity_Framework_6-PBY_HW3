using LesAppLib.Models;
using LesAppLib.Models.Add;
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

            games.AddRange(new Game[]
            {
                new Game()
                {
                    Name = "The Need for Speed",
                    Release = new DateTime(1994, 8, 31),
                    Developers = new Developer[] { new Developer() { FullName = "EA Canada" } },
                    Platforms = new Platform[]
                    {
                        new Platform() { Name = "3DO" },
                        new Platform()
                        {
                            Name = "MS-DOS",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 83/100 }},
                        },
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 68.5/100 }},
                        },
                        new Platform() { Name = "Microsoft Windows" },
                        new Platform()
                        {
                            Name = "Sega Saturn",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 95/100 }},
                        },
                    },
                },
                new Game()
                {
                    Name = "Need for Speed II",
                    Release = new DateTime(1997, 3, 31),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Canada" },
                        new Developer() { FullName = "EA Seattle" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            { 
                                new Critic(){ Name = "GameRankings", Scores = 71.39/100 },
                                new Critic(){ Name = "Metacritic", Scores = 71/100 },
                            },
                        },
                        new Platform()
                        { 
                            Name = "Microsoft Windows",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 68.25/100 }},
                        }, 
                    },
                },
                new Game()
                {
                    Name = "Need for Speed III: Hot Pursuit",
                    Release = new DateTime(1998, 3, 25),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Canada" },
                        new Developer() { FullName = "EA Seattle" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 85.63/100 },
                                new Critic(){ Name = "Metacritic", Scores =  88/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Microsoft Windows",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 84.82/ 100 }},
                        },
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: High Stakes",
                    Release = new DateTime(1999, 3, 1),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Canada" },
                        new Developer() { FullName = "EA Seattle" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores =  84.38/100 },
                                new Critic(){ Name = "Metacritic", Scores =  86/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Microsoft Windows",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 83.08/100 }},
                        },
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Porsche Unleashed",
                    Release = new DateTime(2000, 2, 29),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Canada" },
                        new Developer() { FullName = "EA Seattle" },
                        new Developer() { FullName = "Pocketeers" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores =  74.5/100 },
                                new Critic(){ Name = "Metacritic", Scores =  78/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Microsoft Windows",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 84.36/100 }},
                        },
                        new Platform()
                        {
                            Name = "Game Boy Advance",
                            Critics = new Critic[]
                            { 
                                new Critic() { Name = "GameRankings", Scores = 59.25/100 },
                                new Critic(){ Name = "Metacritic", Scores = 62/100 },
                            },
                        },
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Hot Pursuit 2",
                    Release = new DateTime(2002, 10, 2),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Black Box" },
                        new Developer() { FullName = "EA Seattle" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores =  88.01/100 },
                                new Critic(){ Name = "Metacritic", Scores =  89/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Xbox",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores =  80.04/100 },
                                new Critic(){ Name = "Metacritic", Scores =  75/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Microsoft Windows",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores =  72.77/100 },
                                new Critic(){ Name = "Metacritic", Scores =  73/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "GameCub",
                            Critics = new Critic[]
                            {
                                new Critic() { Name = "GameRankings", Scores = 72.05/100 },
                                new Critic(){ Name = "Metacritic", Scores = 68/100 },
                            },
                        },
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Underground",
                    Release = new DateTime(2003, 11, 17),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Black Box" },
                        new Developer() { FullName = "Pocketeers" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 84.29/100 },
                                new Critic(){ Name = "Metacritic", Scores = 85/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Xbox",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 81.76/100 },
                                new Critic(){ Name = "Metacritic", Scores = 83/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Microsoft Windows",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 82.29/100 },
                                new Critic(){ Name = "Metacritic", Scores =  82/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "GameCub",
                            Critics = new Critic[]
                            {
                                new Critic() { Name = "GameRankings", Scores = 83.73/100 },
                                new Critic(){ Name = "Metacritic", Scores = 83/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Game Boy Advance",
                            Critics = new Critic[]
                            {
                                new Critic() { Name = "GameRankings", Scores = 77.33/100 },
                                new Critic(){ Name = "Metacritic", Scores = 77/100 },
                            },
                        },
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Underground 2",
                    Release = new DateTime(2004, 11, 9),
                    Developers = new Developer[]
                    {
                        new Developer() { FullName = "EA Black Box" },
                        new Developer() { FullName = "Pocketeers" },
                    },
                    Platforms = new Platform[]
                    {
                        new Platform()
                        {
                            Name = "PlayStation",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 80.77/100 },
                                new Critic(){ Name = "Metacritic", Scores = 82/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Xbox",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 82.61/100 },
                                new Critic(){ Name = "Metacritic", Scores = 77/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Microsoft Windows",
                            Critics = new Critic[]
                            {
                                new Critic(){ Name = "GameRankings", Scores = 83.5/100 },
                                new Critic(){ Name = "Metacritic", Scores =  82/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "GameCub",
                            Critics = new Critic[] { new Critic() { Name = "GameRankings", Scores = 79.98/100 }},
                        },
                        new Platform()
                        {
                            Name = "Game Boy Advance",
                            Critics = new Critic[]
                            {
                                new Critic() { Name = "GameRankings", Scores = 69.45/100 },
                                new Critic(){ Name = "Metacritic", Scores = 72/100 },
                            },
                        },
                        new Platform()
                        {
                            Name = "Nintendo DS",
                            Critics = new Critic[]
                            {
                                new Critic() { Name = "GameRankings", Scores = 65.44/100 },
                                new Critic(){ Name = "Metacritic", Scores = 65/100 },
                            },
                        },
                    },
                },
            });

            NFS nfs = new NFS()
            {
                TypeFace = "Need for Speed",
                Genre = "Racing",
                Publisher = "Electronic Arts",
                Games = games,
            };

            // збереження даних
            db.Games.AddRange(games);
            db.EA.Add(nfs);
            db.SaveChanges();
        }
    }
}