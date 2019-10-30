using LesAppLib.Models.Add;
using System;
using System.Collections.Generic;

namespace LesAppLib.Models
{
    /// <summary>
    /// Гра
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Назва гри
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Реліз гри
        /// </summary>
        public DateTime Release { get; set; }
        /// <summary>
        /// Обложка
        /// </summary>
        public byte[] Poster { get; set; }
        /// <summary>
        /// Розробники
        /// </summary>
        public ICollection<Developer> Developers { get; set; }
        /// <summary>
        /// Платформи
        /// </summary>
        public ICollection<Platform> Platforms { get; set; }
        /// <summary>
        /// Директора
        /// </summary>
        public ICollection<Director> Directors { get; set; }

        /// <summary>
        /// Серія
        /// </summary>
        public NFS Series { get; set; }

        public Game()
        {
            Developers = new List<Developer>();
            Platforms = new List<Platform>();
            Directors = new List<Director>();
        }

    }
}