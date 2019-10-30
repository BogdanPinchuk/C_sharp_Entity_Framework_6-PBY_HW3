using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://uk.wikipedia.org/wiki/Need_for_Speed_(серія_ігор)
// https://en.wikipedia.org/wiki/Need_for_Speed

namespace LesAppLib.Models
{
    /// <summary>
    /// Need for Speed (серія ігор)
    /// </summary>
    public class NFS
    {
        /// <summary>
        /// Логотип
        /// </summary>
        public string TypeFace { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Видавець
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// Гра
        /// </summary>
        public virtual ICollection<Game> Games { get; set; }

        public NFS()
        {
            Games = new List<Game>();
        }
    }
}
