using LesAppLib.Models;
using LesAppLib.Models.Add;
using System;
using System.Data.Entity;
using System.IO;
using System.Text;

namespace LesAppCreateDB.Context
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class NFSContext : DbContext
    {
        static NFSContext()
        {
            // установка шляху до БД
            /*AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetDirectoryName(Environment.CurrentDirectory));*/

            // ініціалізація БД
            Database.SetInitializer(new ContextInitializer());
        }

        public NFSContext() 
            : base("NFSConnection") { }

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
        public virtual DbSet<Platform> Platforms { get; set; }
        /// <summary>
        /// Ігри
        /// </summary>
        public virtual DbSet<Game> Games { get; set; }
        /// <summary>
        /// Серія ігр NFS
        /// </summary>
        public virtual DbSet<NFS> NFS { get; set; }


    }
}
