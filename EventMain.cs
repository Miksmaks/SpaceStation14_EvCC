using SpaceStation14_EventCardCreator.DataTypes;
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
using SpaceStation14_EventCardCreator.Services;
using System.Xml.Linq;

namespace SpaceStation14_EventCardCreator
{
    public partial class EventMain : Form
    {
        EventMainProperties properties;
        bool Done = false;
        public EventMain()
        {
            InitializeComponent();
            properties.Photo = "error";
            properties.Scheme = "error";
        }

        public bool GetDone() { return Done; }

        private void DropImage(object sender, DragEventArgs e)
        {
            button1.BackColor = Color.Gray;
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data == null) { return; }
            var files = data as string[];
            properties.Photo = ImageService.WrapImage(files[0]);
            button1.BackColor = Color.DarkGreen;
        }

        private void LoadFile(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "PNG|*.png";
            file.Multiselect = false;
            if (file.ShowDialog() != DialogResult.OK) { return; }
            if (!File.Exists(file.FileName))
            {
                MessageBox.Show("Файл не найден", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            properties.Photo = ImageService.WrapImage(file.FileName);
            button1.BackColor = Color.DarkGreen;
        }

        private void LoadScheme(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Gray;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "PNG|*.png";
            file.Multiselect = false;
            if (file.ShowDialog() != DialogResult.OK) { return; }
            if (!File.Exists(file.FileName))
            {
                MessageBox.Show("Файл не найден", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            properties.Scheme = ImageService.WrapImage(file.FileName);
            button3.BackColor = Color.DarkGreen;
        }

        private void DropScheme(object sender, DragEventArgs e)
        {
            button3.BackColor = Color.Gray;
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data == null) { return; }
            var files = data as string[];
            properties.Scheme = ImageService.WrapImage(files[0]);
            button3.BackColor = Color.DarkGreen;
        }

        private void AddEvent(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Название не указано", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (SaveLoadService.E_list.FindIndex(x => x.MainProperties.EventName == textBox1.Text) != -1) 
            {
                MessageBox.Show("Этот ивент уже есть в базе", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            properties.EventName = textBox1.Text;
            properties.Score = "0";
            properties.CreateDate = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}";
            properties.ShortDescription = textBox2.Text;
            properties.Description = textBox3.Text;
            properties.Author = textBox4.Text;
            SaveLoadService.E_list.Add(new EventLine(properties));
            Done = true;
            Close();
        }

        private void DragSchemeEffect(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DragImageEffect(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
