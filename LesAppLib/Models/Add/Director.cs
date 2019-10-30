using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAppLib.Models.Add
{
    /// <summary>
    /// Директор
    /// </summary>
    public class Director
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ПІБ
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Ігри
        /// </summary>
        public ICollection<Game> Games { get; set; }

        public Director()
        {
            Games = new List<Game>();
        }

        public override string ToString()
            => $"Name of director: {FullName}";
    }
}
