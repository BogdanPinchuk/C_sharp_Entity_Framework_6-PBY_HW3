using LesAppLib.Models;
using LesAppLib.Models.Add;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesAppCRUD.Context
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class NFSContext : DbContext
    {
        /// <summary>
        /// Збереження БД в папці документів
        /// </summary>
        private static readonly string doc = "name=\"NFSConnection\" connectionString=\"data source = (LocalDB)\\MSSQLLocalDB;" +
            "Initial Catalog = NFSDB; Integrated Security = True;\" providerName=\"System.Data.SqlClient\"";
        /// <summary>
        /// Збереження БД у вибраній користувачем папці
        /// </summary>
        private static readonly string exe = "name=\"NFSConnection\" connectionString=\"data source = (LocalDB)\\MSSQLLocalDB;" +
            $"Initial Catalog = {Path.GetDirectoryName(Application.ExecutablePath)}\\NFSDB;" +
            " Integrated Security = True;\" providerName=\"System.Data.SqlClient\"";

        /// <summary>
        /// Збереження БД в папці документів
        /// </summary>
        public NFSContext() 
            : base(doc) { }
        /// <summary>
        /// Можливість зберегти в папці з програмою, true - біля *.exe, false - в документах
        /// </summary>
        /// <param name="save"></param>
        public NFSContext(bool save)
            : base(save ? exe : doc) { }
        /// <summary>
        /// Можливість працювати із вказаним в процесі файлом БД
        /// </summary>
        /// <param name="filename">Шлях до БД</param>
        public NFSContext(string filename)
            : base(CreateConnect(filename)) { }

        /// <summary>
        /// Створення підключення за вказаним шляхом файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static string CreateConnect(string filename)
        {
            return new StringBuilder()
                .Append("name=\"NFSConnection\" connectionString=\"data source = (LocalDB)\\MSSQLLocalDB;")
                .Append($"Initial Catalog = |DataDirectory|\\{filename}; ")
                .Append("Integrated Security = True;\" providerName=\"System.Data.SqlClient\"")
                .ToString();
        }

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
        /// <summary>
        /// Ігри
        /// </summary>
        public virtual DbSet<Game> Games { get; set; }
        /// <summary>
        /// Серія ігр NFS
        /// </summary>
        public virtual DbSet<NFS> EA { get; set; }


    }
}
