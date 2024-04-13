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
    public partial class AddClass : Form
    {
        int Id;
        bool Done;
        public AddClass(int id)
        {
            InitializeComponent();
            UpdateClasses();
            Id = id;
        }

        public bool GetDone() { return Done; }

        void UpdateClasses() 
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < SaveLoadService.C_list.Count; i++) 
            {
                comboBox1.Items.Add(SaveLoadService.C_list[i].Name);
            }
        }
        void UpdateParams(int iClass) 
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < SaveLoadService.C_list[iClass].Rates.Count; i++)
            {
                comboBox2.Items.Add(SaveLoadService.C_list[iClass].Rates[i]);
            }
        }

        private void ClassChange(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) { return; }
            UpdateParams(comboBox1.SelectedIndex);
        }

        private void SaveClass(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1) 
            {
                MessageBox.Show("Есть пустые поля", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            SaveLoadService.E_list[Id].Properties.Add(new EventProperty(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString()));
            Done = true;
            Close();
        }
    }
}
