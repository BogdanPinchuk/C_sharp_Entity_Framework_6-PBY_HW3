using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAppLib.Models.Add
{
    /// <summary>
    /// Розробник
    /// </summary>
    public class Developer
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
        public virtual ICollection<Game> Games { get; set; }

        public Developer()
        {
            Games = new List<Game>();
        }
    }
}
