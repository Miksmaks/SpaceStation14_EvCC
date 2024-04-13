using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceStation14_EventCardCreator.DataTypes;
using SpaceStation14_EventCardCreator.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceStation14_EventCardCreator
{
    public partial class ClassBase : Form
    {
        Form ParentForm;
        public ClassBase(Form parent)
        {
            InitializeComponent();
            listBox1.ContextMenuStrip = ClassMenu;
            ParentForm = parent;
            UpdateTableClass();
        }

        private void UpdateTableClass() 
        {
            listBox1.Items.Clear();
            for (int i = 0; i < SaveLoadService.C_list.Count; i++)
            {
                listBox1.Items.Add(SaveLoadService.C_list[i].Name);
            }
        }

        private void UpdateTableParams(int Ind)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < SaveLoadService.C_list[Ind].Rates.Count; i++)
            {
                listBox2.Items.Add(SaveLoadService.C_list[Ind].Rates[i]);
            }
        }

        private void AddClass(object sender, EventArgs e)
        {
            EditClass form = new EditClass();
            form.ShowDialog();
            if (form.GetDone()) 
            {
                UpdateTableClass();
                SaveLoadService.status = BaseStatus.Edit;
                ParentForm.Text = "База ивентов (*)";
            }
        }

        private void DeleteClass(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0) { return; }
            int iItem = listBox1.SelectedIndex;
            SaveLoadService.C_list.RemoveAt(iItem);
            UpdateTableClass();
            SaveLoadService.status = BaseStatus.Edit;
            ParentForm.Text = "База ивентов (*)";
        }

        private void CheckParams(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0) { return; }
            int iItem = listBox1.SelectedIndex;
            UpdateTableParams(iItem);
        }
    }
}
