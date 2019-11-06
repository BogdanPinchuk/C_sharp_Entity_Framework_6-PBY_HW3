using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAppLib.Models.Add
{
    /// <summary>
    /// Платформа
    /// </summary>
    public class Platform
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Назва
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ігри
        /// </summary>
        public virtual ICollection<Game> Games { get; set; }
        /// <summary>
        /// Критики
        /// </summary>
        public virtual ICollection<Critic> Critics { get; set; }

        public Platform()
        {
            Games = new List<Game>();
            Critics = new List<Critic>();
        }

        public override string ToString()
            => $"Platform for game: {Name}, has {Critics.Count} critics";
    }
}
