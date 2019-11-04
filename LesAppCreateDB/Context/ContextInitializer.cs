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
            // створеення розробників
            Developer[] developers = new Developer[]
            {
                new Developer() { FullName = "EA Canada" },     //0
                new Developer() { FullName = "EA Seattle" },
                new Developer() { FullName = "Pocketeers" },
                new Developer() { FullName = "EA Black Box" },
                new Developer() { FullName = "Rovio Mobile" },
                new Developer() { FullName = "Global VR" },     //5
                new Developer() { FullName = "Exient Entertainment" },
                new Developer() { FullName = "Firebrand Games" },
                new Developer() { FullName = "Slightly Mad Studiost" },
                new Developer() { FullName = "EA Bright Light" },
                new Developer() { FullName = "EA Redwood Shores" }, //10
                new Developer() { FullName = "EA Montreal" },
                new Developer() { FullName = "Quicklime Games" },
                new Developer() { FullName = "EA Singapore" },
                new Developer() { FullName = "Criterion Games" },
                new Developer() { FullName = "Straight Right" },   //15
                new Developer() { FullName = "Ghost Games" },
            };

            // створення критиків
            Critic[] gr = new Critic[]
            {
                new Critic() { Name = "GameRankings", Scores = 83.00/100 },    //0
                new Critic() { Name = "GameRankings", Scores = 68.50/100 },
                new Critic() { Name = "GameRankings", Scores = 95.00/100 },
                new Critic() { Name = "GameRankings", Scores = 71.39/100 },
                new Critic() { Name = "GameRankings", Scores = 68.25/100 },
                new Critic() { Name = "GameRankings", Scores = 85.63/100 }, // 5
                new Critic() { Name = "GameRankings", Scores = 84.82/100 },
                new Critic() { Name = "GameRankings", Scores = 84.38/100 },
                new Critic() { Name = "GameRankings", Scores = 83.08/100 },
                new Critic() { Name = "GameRankings", Scores = 74.50/100 },
                new Critic() { Name = "GameRankings", Scores = 84.36/100 }, //10
                new Critic() { Name = "GameRankings", Scores = 59.25/100 },
                new Critic() { Name = "GameRankings", Scores = 88.01/100 },
                new Critic() { Name = "GameRankings", Scores = 80.04/100 },
                new Critic() { Name = "GameRankings", Scores = 72.77/100 },
                new Critic() { Name = "GameRankings", Scores = 72.05/100 }, //15
                new Critic() { Name = "GameRankings", Scores = 84.29/100 },
                new Critic() { Name = "GameRankings", Scores = 81.76/100 },
                new Critic() { Name = "GameRankings", Scores = 82.29/100 },
                new Critic() { Name = "GameRankings", Scores = 83.73/100 },
                new Critic() { Name = "GameRankings", Scores = 77.33/100 }, //20
                new Critic() { Name = "GameRankings", Scores = 80.77/100 },
                new Critic() { Name = "GameRankings", Scores = 82.61/100 },
                new Critic() { Name = "GameRankings", Scores = 83.50/100 },
                new Critic() { Name = "GameRankings", Scores = 79.98/100 },
                new Critic() { Name = "GameRankings", Scores = 69.45/100 }, //25
                new Critic() { Name = "GameRankings", Scores = 65.44/100 },
                new Critic() { Name = "GameRankings", Scores = 83.05/100 },
                new Critic() { Name = "GameRankings", Scores = 82.59/100 },
                new Critic() { Name = "GameRankings", Scores = 81.56/100 },
                new Critic() { Name = "GameRankings", Scores = 81.50/100 }, //30
                new Critic() { Name = "GameRankings", Scores = 79.36/100 },
                new Critic() { Name = "GameRankings", Scores = 46.89/100 },
                new Critic() { Name = "GameRankings", Scores = 67.33/100 },
                new Critic() { Name = "GameRankings", Scores = 78.47/100 },
                new Critic() { Name = "GameRankings", Scores = 77.51/100 }, //35
                new Critic() { Name = "GameRankings", Scores = 76.26/100 },
                new Critic() { Name = "GameRankings", Scores = 74.25/100 },
                new Critic() { Name = "GameRankings", Scores = 73.28/100 },
                new Critic() { Name = "GameRankings", Scores = 71.00/100 },
                new Critic() { Name = "GameRankings", Scores = 75.04/100 }, //40
                new Critic() { Name = "GameRankings", Scores = 69.33/100 },
                new Critic() { Name = "GameRankings", Scores = 66.50/100 },
                new Critic() { Name = "GameRankings", Scores = 65.39/100 },
                new Critic() { Name = "GameRankings", Scores = 74.83/100 },
                new Critic() { Name = "GameRankings", Scores = 72.87/100 }, //45
                new Critic() { Name = "GameRankings", Scores = 72.17/100 },
                new Critic() { Name = "GameRankings", Scores = 69.12/100 },
                new Critic() { Name = "GameRankings", Scores = 63.94/100 },
                new Critic() { Name = "GameRankings", Scores = 60.64/100 },
                new Critic() { Name = "GameRankings", Scores = 60.38/100 }, //50
                new Critic() { Name = "GameRankings", Scores = 64.58/100 },
                new Critic() { Name = "GameRankings", Scores = 62.66/100 },
                new Critic() { Name = "GameRankings", Scores = 61.70/100 },
                new Critic() { Name = "GameRankings", Scores = 58.20/100 },
                new Critic() { Name = "GameRankings", Scores = 58.00/100 }, //55
                new Critic() { Name = "GameRankings", Scores = 53.92/100 },
                new Critic() { Name = "GameRankings", Scores = 50.50/100 },
                new Critic() { Name = "GameRankings", Scores = 83.59/100 },
                new Critic() { Name = "GameRankings", Scores = 82.84/100 },
                new Critic() { Name = "GameRankings", Scores = 82.36/100 }, //60
                new Critic() { Name = "GameRankings", Scores = 69.60/100 },
                new Critic() { Name = "GameRankings", Scores = 73.31/100 },
                new Critic() { Name = "GameRankings", Scores = 71.71/100 },
                new Critic() { Name = "GameRankings", Scores = 63.83/100 },
                new Critic() { Name = "GameRankings", Scores = 88.86/100 }, //65
                new Critic() { Name = "GameRankings", Scores = 87.21/100 },
                new Critic() { Name = "GameRankings", Scores = 86.19/100 },
                new Critic() { Name = "GameRankings", Scores = 45.83/100 },
                new Critic() { Name = "GameRankings", Scores = 83.08/100 },
                new Critic() { Name = "GameRankings", Scores = 81.91/100 }, //70
                new Critic() { Name = "GameRankings", Scores = 80.40/100 },
                new Critic() { Name = "GameRankings", Scores = 70.00/100 },
                new Critic() { Name = "GameRankings", Scores = 69.92/100 },
                new Critic() { Name = "GameRankings", Scores = 68.20/100 },
                new Critic() { Name = "GameRankings", Scores = 64.04/100 }, //75
                new Critic() { Name = "GameRankings", Scores = 60.14/100 },
                new Critic() { Name = "GameRankings", Scores = 86.46/100 },
                new Critic() { Name = "GameRankings", Scores = 85.09/100 },
                new Critic() { Name = "GameRankings", Scores = 83.44/100 },
                new Critic() { Name = "GameRankings", Scores = 83.05/100 }, //80
                new Critic() { Name = "GameRankings", Scores = 81.50/100 },
                new Critic() { Name = "GameRankings", Scores = 79.00/100 },
                new Critic() { Name = "GameRankings", Scores = 80.59/100 },
                new Critic() { Name = "GameRankings", Scores = 79.08/100 },
                new Critic() { Name = "GameRankings", Scores = 73.67/100 }, //85
                new Critic() { Name = "GameRankings", Scores = 71.43/100 },
            };
            Critic[] mc = new Critic[]
            {
                new Critic() { Name = "Metacritic", Scores = 71.00/100 },  //0
                new Critic() { Name = "Metacritic", Scores = 88.00/100 },
                new Critic() { Name = "Metacritic", Scores = 86.00/100 },
                new Critic() { Name = "Metacritic", Scores = 78.00/100 },
                new Critic() { Name = "Metacritic", Scores = 62.00/100 },
                new Critic() { Name = "Metacritic", Scores = 89.00/100 },  //5
                new Critic() { Name = "Metacritic", Scores = 75.00/100 },
                new Critic() { Name = "Metacritic", Scores = 73.00/100 },
                new Critic() { Name = "Metacritic", Scores = 68.00/100 },
                new Critic() { Name = "Metacritic", Scores = 85.00/100 },
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },  //10
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },
                new Critic() { Name = "Metacritic", Scores = 82.00/100 },
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },
                new Critic() { Name = "Metacritic", Scores = 77.00/100 },
                new Critic() { Name = "Metacritic", Scores = 82.00/100 },  //15
                new Critic() { Name = "Metacritic", Scores = 77.00/100 },
                new Critic() { Name = "Metacritic", Scores = 82.00/100 },
                new Critic() { Name = "Metacritic", Scores = 72.00/100 },
                new Critic() { Name = "Metacritic", Scores = 65.00/100 },
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },  //20
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },
                new Critic() { Name = "Metacritic", Scores = 82.00/100 },
                new Critic() { Name = "Metacritic", Scores = 82.00/100 },
                new Critic() { Name = "Metacritic", Scores = 80.00/100 },
                new Critic() { Name = "Metacritic", Scores = 45.00/100 },  //25
                new Critic() { Name = "Metacritic", Scores = 78.00/100 },
                new Critic() { Name = "Metacritic", Scores = 77.00/100 },
                new Critic() { Name = "Metacritic", Scores = 75.00/100 },
                new Critic() { Name = "Metacritic", Scores = 75.00/100 },
                new Critic() { Name = "Metacritic", Scores = 74.00/100 },  //30
                new Critic() { Name = "Metacritic", Scores = 73.00/100 },
                new Critic() { Name = "Metacritic", Scores = 74.00/100 },
                new Critic() { Name = "Metacritic", Scores = 70.00/100 },
                new Critic() { Name = "Metacritic", Scores = 67.00/100 },
                new Critic() { Name = "Metacritic", Scores = 74.00/100 },  //35
                new Critic() { Name = "Metacritic", Scores = 73.00/100 },
                new Critic() { Name = "Metacritic", Scores = 72.00/100 },
                new Critic() { Name = "Metacritic", Scores = 70.00/100 },
                new Critic() { Name = "Metacritic", Scores = 61.00/100 },
                new Critic() { Name = "Metacritic", Scores = 62.00/100 },  //40
                new Critic() { Name = "Metacritic", Scores = 57.00/100 },
                new Critic() { Name = "Metacritic", Scores = 64.00/100 },
                new Critic() { Name = "Metacritic", Scores = 59.00/100 },
                new Critic() { Name = "Metacritic", Scores = 65.00/100 },
                new Critic() { Name = "Metacritic", Scores = 59.00/100 },  //45
                new Critic() { Name = "Metacritic", Scores = 54.00/100 },
                new Critic() { Name = "Metacritic", Scores = 52.00/100 },
                new Critic() { Name = "Metacritic", Scores = 84.00/100 },
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },
                new Critic() { Name = "Metacritic", Scores = 83.00/100 },  //50
                new Critic() { Name = "Metacritic", Scores = 69.00/100 },
                new Critic() { Name = "Metacritic", Scores = 69.00/100 },
                new Critic() { Name = "Metacritic", Scores = 70.00/100 },
                new Critic() { Name = "Metacritic", Scores = 62.00/100 },
                new Critic() { Name = "Metacritic", Scores = 89.00/100 },  //55
                new Critic() { Name = "Metacritic", Scores = 88.00/100 },
                new Critic() { Name = "Metacritic", Scores = 86.00/100 },
                new Critic() { Name = "Metacritic", Scores = 50.00/100 },
                new Critic() { Name = "Metacritic", Scores = 84.00/100 },
                new Critic() { Name = "Metacritic", Scores = 82.00/100 },  //60
                new Critic() { Name = "Metacritic", Scores = 81.00/100 },
                new Critic() { Name = "Metacritic", Scores = 64.00/100 },
                new Critic() { Name = "Metacritic", Scores = 68.00/100 },
                new Critic() { Name = "Metacritic", Scores = 65.00/100 },
                new Critic() { Name = "Metacritic", Scores = 64.00/100 },  //65
                new Critic() { Name = "Metacritic", Scores = 69.00/100 },
                new Critic() { Name = "Metacritic", Scores = 86.00/100 },
                new Critic() { Name = "Metacritic", Scores = 84.00/100 },
                new Critic() { Name = "Metacritic", Scores = 79.00/100 },
                new Critic() { Name = "Metacritic", Scores = 84.00/100 },  //70
                new Critic() { Name = "Metacritic", Scores = 78.00/100 },
                new Critic() { Name = "Metacritic", Scores = 80.00/100 },
                new Critic() { Name = "Metacritic", Scores = 80.00/100 },
                new Critic() { Name = "Metacritic", Scores = 75.00/100 },
                new Critic() { Name = "Metacritic", Scores = 76.00/100 },  //75
                new Critic() { Name = "Metacritic", Scores = 76.00/100 },
            };

            // створення платформ
            Platform[] platforms = new Platform[]
            {
                new Platform()
                { 
                    Name = "3DO"
                },  //0
                new Platform() 
                {
                    Name = "MS-DOS",
                    Critics = new Critic[] { gr[0] },
                },
                new Platform()
                {
                    Name = "PlayStation",
                    Critics = new Critic[] { gr[1] },
                },
                new Platform() 
                { 
                    Name = "Microsoft Windows" 
                },
                new Platform()
                {
                    Name = "Sega Saturn",
                    Critics = new Critic[] { gr[2] },
                },
                new Platform()
                {
                    Name = "PlayStation",
                    Critics = new Critic[] { gr[3], mc[0] },
                },  //5
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[4] },
                },
                new Platform()
                {
                    Name = "PlayStation",
                    Critics = new Critic[] { gr[5], mc[1], },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[6] },
                },
                new Platform()
                {
                    Name = "PlayStation",
                    Critics = new Critic[] { gr[7], mc[2] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[8] },
                },  //10
                new Platform()
                {
                    Name = "PlayStation",
                    Critics = new Critic[] { gr[9], mc[3] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[10] },
                },
                new Platform()
                {
                    Name = "Game Boy Advance",
                    Critics = new Critic[] { gr[11], mc[4] },
                },
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[12], mc[5] },
                },
                new Platform()
                {
                    Name = "Xbox",
                    Critics = new Critic[] { gr[13], mc[6] },
                },  //15
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[14], mc[7] },
                },
                new Platform()
                {
                    Name = "GameCub",
                    Critics = new Critic[] { gr[15], mc[8] },
                },
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[16], mc[9] },
                },
                new Platform()
                {
                    Name = "Xbox",
                    Critics = new Critic[] { gr[17], mc[11] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[18], mc[12] },
                },  //20
                new Platform()
                {
                    Name = "GameCub",
                    Critics = new Critic[] { gr[19], mc[13] },
                },
                new Platform()
                {
                    Name = "Game Boy Advance",
                    Critics = new Critic[] { gr[20], mc[14] },
                },
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[21], mc[15] },
                },
                new Platform()
                {
                    Name = "Xbox",
                    Critics = new Critic[] { gr[22], mc[16] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[23], mc[17] },
                },  //25
                new Platform()
                {
                    Name = "GameCub",
                    Critics = new Critic[] { gr[24] },
                },
                new Platform()
                {
                    Name = "Game Boy Advance",
                    Critics = new Critic[] { gr[25], mc[18] },
                },
                new Platform()
                {
                    Name = "Nintendo DS",
                    Critics = new Critic[] { gr[26], mc[19] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[27], mc[20] },
                },
                new Platform()
                {
                    Name = "Xbox",
                    Critics = new Critic[] { gr[28], mc[21] },
                },  //30
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[29], mc[22] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[30], mc[23] },
                },
                new Platform()
                {
                    Name = "GameCube",
                    Critics = new Critic[] { gr[31], mc[24] },
                },
                new Platform()
                {
                    Name = "Nintendo DS",
                    Critics = new Critic[] { gr[32], mc[25] },
                },
                new Platform()
                {
                    Name = "Game Boy Advance",
                    Critics = new Critic[] { gr[33] },
                },  //35
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[34], mc[26] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[35], mc[27] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[36], mc[28] },
                },
                new Platform()
                {
                    Name = "GameCube",
                    Critics = new Critic[] { gr[37], mc[29] },
                },
                new Platform()
                {
                    Name = "Xbox",
                    Critics = new Critic[] { gr[38], mc[30] },
                },  //40
                new Platform()
                {
                    Name = "PlayStation Portable",
                    Critics = new Critic[] { gr[39], mc[31] },
                },
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[40], mc[32] },
                },
                new Platform()
                {
                    Name = "Game Boy Advance",
                    Critics = new Critic[] { gr[41] },
                },
                new Platform()
                {
                    Name = "Nintendo DS",
                    Critics = new Critic[] { gr[42], mc[33] },
                },
                new Platform()
                {
                    Name = "Wii",
                    Critics = new Critic[] { gr[43], mc[34] },
                },  //45
                new Platform()
                {
                    Name = "Mac OS X",
                },
                new Platform()
                {
                    Name = "Zeebo",
                },
                new Platform()
                {
                    Name = "Nintendo DS",
                    Critics = new Critic[] { gr[44], mc[35] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[45], mc[36] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[46], mc[37] },
                },  //50
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[47], mc[38] },
                },
                new Platform()
                {
                    Name = "Wii",
                    Critics = new Critic[] { gr[48], mc[39] },
                },
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[49], mc[40] },
                },
                new Platform()
                {
                    Name = "PlayStation Portable",
                    Critics = new Critic[] { gr[50], mc[41] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[51], mc[42] },
                },  //55
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[52], mc[43] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[53], mc[44] },
                },
                new Platform()
                {
                    Name = "Nintendo DS",
                    Critics = new Critic[] { gr[54], mc[45] },
                },
                new Platform()
                {
                    Name = "PlayStation 2",
                    Critics = new Critic[] { gr[55] },
                },
                new Platform()
                {
                    Name = "Wii",
                    Critics = new Critic[] { gr[56], mc[46] },
                },  //60
                new Platform()
                {
                    Name = "PlayStation Portable",
                    Critics = new Critic[] { gr[57], mc[47] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[58], mc[48] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[59], mc[49] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[60], mc[50] },
                },
                new Platform()
                {
                    Name = "PlayStation Portable",
                    Critics = new Critic[] { gr[61], mc[51] },
                },  //65
                new Platform()
                {
                    Name = "Wii",
                    Critics = new Critic[] { gr[62], mc[52] },
                },
                new Platform()
                {
                    Name = "Nintendo DS",
                    Critics = new Critic[] { gr[63], mc[53] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[64], mc[54] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[65], mc[55] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[66], mc[56] },
                },  //70
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[67], mc[57] },
                },
                new Platform()
                {
                    Name = "Wii",
                    Critics = new Critic[] { gr[68], mc[58] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[69], mc[59] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[70], mc[60] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[71], mc[61] },
                },  //75
                new Platform()
                {
                    Name = "Wii",
                    Critics = new Critic[] { gr[72], mc[62] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[73], mc[63] },
                },
                new Platform()
                {
                    Name = "Nintendo 3DS",
                    Critics = new Critic[] { gr[74], mc[64] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[75], mc[65] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[76], mc[66] },
                },  //80
                new Platform()
                {
                    Name = "Wii U",
                    Critics = new Critic[] { gr[77], mc[67] },
                },
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[78], mc[68] },
                },
                new Platform()
                {
                    Name = "PS Vita",
                    Critics = new Critic[] { gr[79], mc[69] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[80], mc[70] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[81], mc[71] },
                },  //85
                new Platform()
                {
                    Name = "PlayStation 3",
                    Critics = new Critic[] { gr[82], mc[72] },
                },
                new Platform()
                {
                    Name = "PlayStation 4",
                    Critics = new Critic[] { gr[83], mc[73] },
                },
                new Platform()
                {
                    Name = "Xbox One",
                    Critics = new Critic[] { gr[84], mc[74] },
                },
                new Platform()
                {
                    Name = "Microsoft Windows",
                    Critics = new Critic[] { gr[85], mc[75] },
                },
                new Platform()
                {
                    Name = "Xbox 360",
                    Critics = new Critic[] { gr[86], mc[76] },
                },  //90
            };

            // створення БД ігор
            Game[] games = new Game[]
            {
                new Game()
                {
                    Name = "The Need for Speed",
                    Release = new DateTime(1994, 8, 31),
                    Developers = new Developer[] { developers[0] },
                    Platforms = new Platform[]
                    {
                        platforms[0],
                        platforms[1],
                        platforms[2],
                        platforms[3],
                        platforms[4],
                    },
                },  //0
                new Game()
                {
                    Name = "Need for Speed II",
                    Release = new DateTime(1997, 3, 31),
                    Developers = new Developer[]
                    {
                        developers[0],
                        developers[1],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[5],
                        platforms[6],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed III: Hot Pursuit",
                    Release = new DateTime(1998, 3, 25),
                    Developers = new Developer[]
                    {
                        developers[0],
                        developers[1],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[7],
                        platforms[8],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: High Stakes",
                    Release = new DateTime(1999, 3, 1),
                    Developers = new Developer[]
                    {
                        developers[0],
                        developers[1],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[9],
                        platforms[10],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Porsche Unleashed",
                    Release = new DateTime(2000, 2, 29),
                    Developers = new Developer[]
                    {
                        developers[0],
                        developers[1],
                        developers[2],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[11],
                        platforms[12],
                        platforms[13],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Hot Pursuit 2",
                    Release = new DateTime(2002, 10, 2),
                    Developers = new Developer[]
                    {
                        developers[1],
                        developers[3],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[14],
                        platforms[15],
                        platforms[16],
                        platforms[17],
                    },
                },  //5
                new Game()
                {
                    Name = "Need for Speed: Underground",
                    Release = new DateTime(2003, 11, 17),
                    Developers = new Developer[]
                    {
                        developers[2],
                        developers[3],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[18],
                        platforms[19],
                        platforms[20],
                        platforms[21],
                        platforms[22],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Underground 2",
                    Release = new DateTime(2004, 11, 9),
                    Developers = new Developer[]
                    {
                        developers[2],
                        developers[3],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[23],
                        platforms[24],
                        platforms[25],
                        platforms[26],
                        platforms[27],
                        platforms[28],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Most Wanted",
                    Release = new DateTime(2005, 11, 11),
                    Developers = new Developer[] { developers[0] },
                    Platforms = new Platform[]
                    {
                        platforms[29],
                        platforms[30],
                        platforms[31],
                        platforms[32],
                        platforms[33],
                        platforms[34],
                        platforms[35],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Carbon",
                    Release = new DateTime(2006, 10, 30),
                    Developers = new Developer[]
                    {
                        developers[0],
                        developers[3],
                        developers[4],
                        developers[5],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[36],
                        platforms[37],
                        platforms[38],
                        platforms[39],
                        platforms[40],
                        platforms[41],
                        platforms[42],
                        platforms[43],
                        platforms[44],
                        platforms[45],
                        platforms[46],
                        platforms[47],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: ProStreet",
                    Release = new DateTime(2007, 11, 14),
                    Developers = new Developer[] { developers[3] },
                    Platforms = new Platform[]
                    {
                        platforms[48],
                        platforms[49],
                        platforms[50],
                        platforms[51],
                        platforms[52],
                        platforms[53],
                        platforms[54],
                    },
                },  //10
                new Game()
                {
                    Name = "Need for Speed: Undercover",
                    Release = new DateTime(2008, 11, 18),
                    Developers = new Developer[]
                    {
                        developers[3],
                        developers[6],
                        developers[7],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[55],
                        platforms[56],
                        platforms[57],
                        platforms[58],
                        platforms[59],
                        platforms[60],
                        platforms[61],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Shift",
                    Release = new DateTime(2009, 09, 15),
                    Developers = new Developer[]
                    {
                        developers[3],
                        developers[8],
                        developers[9],
                        developers[10],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[62],
                        platforms[63],
                        platforms[64],
                        platforms[65],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Nitro",
                    Release = new DateTime(2009, 11, 03),
                    Developers = new Developer[]
                    {
                        developers[7],
                        developers[11],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[66],
                        platforms[67],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: World",
                    Release = new DateTime(2010, 07, 27),
                    Developers = new Developer[]
                    {
                        developers[12],
                        developers[13],
                    },
                    Platforms = new Platform[] { platforms[68] },
                },
                new Game()
                {
                    Name = "Need for Speed: Hot Pursuit 2010",
                    Release = new DateTime(2010, 11, 16),
                    Developers = new Developer[] { developers[12] },
                    Platforms = new Platform[]
                    {
                        platforms[69],
                        platforms[70],
                        platforms[71],
                        platforms[72],
                    },
                },  //15
                new Game()
                {
                    Name = "Need for Speed: Shift 2 Unleashed",
                    Release = new DateTime(2011, 03, 29),
                    Developers = new Developer[]
                    {
                        developers[8],
                        developers[15],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[73],
                        platforms[74],
                        platforms[75],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: The Run",
                    Release = new DateTime(2011, 11, 15),
                    Developers = new Developer[]
                    {
                        developers[3],
                        developers[7],
                    },
                    Platforms = new Platform[]
                    {
                        platforms[76],
                        platforms[77],
                        platforms[78],
                        platforms[79],
                        platforms[80],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Most Wanted 2012",
                    Release = new DateTime(2012, 10, 30),
                    Developers = new Developer[] { developers[14] },
                    Platforms = new Platform[]
                    {
                        platforms[81],
                        platforms[82],
                        platforms[83],
                        platforms[84],
                        platforms[85],
                    },
                },
                new Game()
                {
                    Name = "Need for Speed: Rivals",
                    Release = new DateTime(2013, 11, 15),
                    Developers = new Developer[] { developers[16] },
                    Platforms = new Platform[]
                    {
                        platforms[86],
                        platforms[87],
                        platforms[88],
                        platforms[89],
                        platforms[90],
                    },
                },
            };

            NFS nfs = new NFS()
            {
                TypeFace = "Need for Speed",
                Genre = "Racing",
                Publisher = "Electronic Arts",
                Games = games,
            };

            // збереження даних
            db.Developers.AddRange(developers);
            db.Critics.AddRange(gr);
            db.Critics.AddRange(mc);
            db.Platforms.AddRange(platforms);
            db.Games.AddRange(games);
            db.NFS.Add(nfs);
            db.SaveChanges();
        }
    }
}