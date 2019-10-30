using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesAppCRUD
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Постер до гри
        /// </summary>
        private Bitmap poster;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Устатновити директорію для БД
        /// </summary>
        /// <param name="path"></param>
        public void SetDirectoryDB(string path)
        {
            ///Application.ExecutablePath - addres executive file 
            AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetDirectoryName(path));
        }

        /// <summary>
        /// Закрить форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMenu_Click(object sender, EventArgs e)
            => this.Close();

        /// <summary>
        /// Інформація про програму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is used for create database.",
                "by Bogdan Pinchuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Завантаження зображення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadMenu_Click(object sender, EventArgs e)
        {
            // Запускаєм діалогове вікно в якому вибираємо файл зображення
            if (openPFile.ShowDialog() == DialogResult.OK)
            {
                // Пробуємо завантажити
                try
                {
                    using (Bitmap tempIm = new Bitmap(openPFile.FileName))
                    {
                        // Міняємо курсор на вид очікування
                        this.Cursor = Cursors.AppStarting;

                        // Присвоюємо зовнішній змінній картинку і "відпускаємо" файл
                        poster = (Bitmap)tempIm.Clone();

                        // Відображаємо картинку
                        pictureBox.Image = poster;

                        // Повертаємо курсор назад
                        this.Cursor = Cursors.Default;
                    }
                }
                catch (Exception)
                {
                    // Видаємо помилку у випадку невірного формату зображення
                    MessageBox.Show("Format of this file is unknown!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Picture didn`t load.");
            }
        }

        /// <summary>
        /// Створення БД в папці за замовчуванням (папка Documents)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentsCMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
