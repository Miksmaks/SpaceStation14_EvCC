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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceStation14_EventCardCreator
{
    public partial class EventProperties : Form
    {
        int Id;
        int SelectedClass;
        bool Done = false;
        public EventProperties(int Ind)
        {
            InitializeComponent();
            Id = Ind;
            listBox1.ContextMenuStrip = EventParams;
            UpdateTable();
            numericUpDown1.Value = Convert.ToInt32(SaveLoadService.E_list[Id].MainProperties.Score);
        }
        public bool GetDone() { return Done; }   
        public void UpdateTable() 
        {
            listBox1.Items.Clear();
            for (int i = 0; i < SaveLoadService.E_list[Id].Properties.Count; i++)
            {
                listBox1.Items.Add(SaveLoadService.E_list[Id].Properties[i].Name);
            }
        }

        private void SelectClass(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0) { return; }
            SelectedClass = listBox1.SelectedIndex;
            label2.Text = SaveLoadService.E_list[Id].Properties[SelectedClass].Name;
            EventClass obj = SaveLoadService.C_list.Find(x => x.Name == SaveLoadService.E_list[Id].Properties[SelectedClass].Name);
            comboBox1.Items.Clear();
            for (int i = 0; i < obj.Rates.Count; i++) 
            {
                comboBox1.Items.Add(obj.Rates[i]);
                if (SaveLoadService.E_list[Id].Properties[SelectedClass].Value == obj.Rates[i]) 
                {
                    comboBox1.SelectedIndex = i;
                }
            }
        }

        private void ClassAdd(object sender, EventArgs e)
        {
            AddClass form = new AddClass(Id);
            form.ShowDialog();
            UpdateTable();
            if (form.GetDone()) { Done = true; }
        }

        private void ClassDelete(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0) { return; }
            int iItem = listBox1.SelectedIndex;
            SaveLoadService.E_list[Id].Properties.RemoveAt(iItem);
            UpdateTable();
            Done = true;
        }

        private void SaveParams(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Параметр не выбран", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveLoadService.E_list[Id].Properties[SelectedClass].Value = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            Done = true;
            MessageBox.Show("Изменено!", "Изменение параметра", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeMark(object sender, MouseEventArgs e)
        {
            SaveLoadService.E_list[Id].MainProperties.Score = numericUpDown1.Value.ToString();
            Done = true;
        }
    }
}
