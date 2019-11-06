using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAppLib.Models.Add
{
    /// <summary>
    /// Критик
    /// </summary>
    public class Critic
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
        /// Оцінка - балів
        /// </summary>
        public double Scores { get; set; }

        /// <summary>
        /// Платформа
        /// </summary>
        public ICollection<Platform> Platforms { get; set; }

        public Critic()
        {
            Platforms = new List<Platform>();
        }

        public override string ToString()
            => $"Name of critic: {Name}, rate in {Scores * 100:N2}";
        
    }
}
