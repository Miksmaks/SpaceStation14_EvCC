using SpaceStation14_EventCardCreator.Services;
using SpaceStation14_EventCardCreator.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStation14_EventCardCreator
{
    public partial class EditClass : Form
    {
        bool Done = false;
        List<string> Params = new List<string>(); 
        public EditClass()
        {
            InitializeComponent();
            listBox1.ContextMenuStrip = DelPar;
        }

        public bool GetDone() { return Done; }

        private void UpdateTable() 
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Params.Count; i++) 
            {
                listBox1.Items.Add(Params[i]);
            }
        }

        private void AddParam(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "") { return; }
            if (Params.FindIndex(x => x == textBox2.Text) != -1){ return; }
            Params.Add(textBox2.Text);
            UpdateTable();
        }

        private void Edit(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Класс без имени", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (Params.Count < 2) 
            {
                MessageBox.Show("Параметров должно быть минимум 2", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SaveLoadService.C_list.FindIndex(x => x.Name == textBox1.Text) != -1)
            {
                MessageBox.Show("Этот класс уже есть в базе", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveLoadService.C_list.Add(new EventClass(textBox1.Text, Params));
            Done = true;
            Close();
        }

        private void DeleteParam(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0) { return; }
            int iItem = listBox1.SelectedIndex;
            Params.RemoveAt(iItem);
            UpdateTable();
        }
    }
}
