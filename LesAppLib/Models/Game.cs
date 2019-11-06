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
        /// ID
        /// </summary>
        public int Id { get; set; }
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
        public virtual ICollection<Developer> Developers { get; set; }
        /// <summary>
        /// Платформи
        /// </summary>
        public virtual ICollection<Platform> Platforms { get; set; }
        /// <summary>
        /// Директора
        /// </summary>
        public virtual ICollection<Director> Directors { get; set; }

        /// <summary>
        /// Серія
        /// </summary>
        public NFS NFS { get; set; }

        public Game()
        {
            Developers = new List<Developer>();
            Platforms = new List<Platform>();
            Directors = new List<Director>();
        }

        public override string ToString()
            => $"Game: {Name}, was realesed {Release.ToShortDateString()} on {Platforms?.Count ?? 0} platforms";

    }
}