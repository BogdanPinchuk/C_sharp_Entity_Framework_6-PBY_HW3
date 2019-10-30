using LesAppLib.Models.Add;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAppDB.Context
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class NFSContext : DbContext
    {
        static NFSContext()
        {

        }

        public NFSContext() 
            : base("NFSConnection"){ }

        /// <summary>
        /// Критики
        /// </summary>
        public virtual DbSet<Critic> Critics { get; set; }
        /// <summary>
        /// Розробники
        /// </summary>
        public virtual DbSet<Developer> Developers { get; set; }
        /// <summary>
        /// Директора
        /// </summary>
        public virtual DbSet<Director> Directors { get; set; }
        /// <summary>
        /// Платформи
        /// </summary>
        public  virtual DbSet<Platform> Platforms { get; set; }
    }
}
