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
using System.Diagnostics.SymbolStore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp;

namespace SpaceStation14_EventCardCreator
{
    public partial class EventBase : Form
    {
        int IdSelectEvent;
        public EventBase()
        {
            InitializeComponent();
            listView1.ContextMenuStrip = EventListContext;
        }

        private void UpdateTable() 
        {
            listView1.Items.Clear();
            for (int i = 0; i < SaveLoadService.E_list.Count; i++) 
            {
                var Item = new ListViewItem(SaveLoadService.E_list[i].MainProperties.EventName);
                Item.SubItems.Add(SaveLoadService.E_list[i].MainProperties.CreateDate);
                Item.SubItems.Add(SaveLoadService.E_list[i].MainProperties.Score);
                Item.SubItems.Add(SaveLoadService.E_list[i].MainProperties.Author);
                listView1.Items.Add(Item);
            }
        }

        private void OpenClassBase(object sender, EventArgs e)
        {
            ClassBase form = new ClassBase(this);
            form.Show();
        }


        private void CreateEventBase(object sender, EventArgs e)
        {
            if (SaveLoadService.status == BaseStatus.Edit)
            {
                DialogResult obj = MessageBox.Show("Текущая база не сохранена. Создать новую?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (obj == DialogResult.No) { return; }
                XMLService.CreateBase();
                UpdateTable();
            }
            else
            {
                if (!XMLService.CreateBase()) { return; }
                listView1.Enabled = true;
                button1.Enabled = true;
                EditTSMI.Enabled = true;
                UpdateTable();
            }
        }

        private void LoadEventBase(object sender, EventArgs e)
        {
            if (SaveLoadService.status == BaseStatus.Edit)
            { 
                DialogResult obj = MessageBox.Show("Текущая база не сохранена. Загрузить новую?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (obj == DialogResult.No) { return; }
                XMLService.LoadBase();
                UpdateTable();
            }
            else 
            {
                if (!XMLService.LoadBase()) { return; }
                listView1.Enabled = true;
                button1.Enabled = true;
                EditTSMI.Enabled = true;
                UpdateTable();
            }
        }

        private void SaveEventBase(object sender, EventArgs e)
        {
            if (SaveLoadService.status == BaseStatus.Unknown) { return; }
            XMLService.UpdateBase();
            this.Text = "База ивентов";
        }

        private void ItemSelect(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0) { return; }
            int iItem = listView1.SelectedItems[0].Index;
            IdSelectEvent = iItem;
            EventMainProperties evm = SaveLoadService.E_list[iItem].MainProperties;
            label6.Text = evm.EventName;
            label7.Text = evm.CreateDate;
            label8.Text = evm.Score + " из 10";
            label5.Text = evm.ShortDescription != ""? evm.ShortDescription :"Нет краткого описания";
            label9.Text = evm.Author != "" ? evm.Author : "Неизвестно";
            if (evm.Photo != "error") 
            {
                pictureBox1.Image = new Bitmap(ImageService.UnwrapImage(evm.Photo));
            }
            else
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
            progressBar1.Value = 0;
        }

        private void AddEvent(object sender, EventArgs e)
        {
            EventMain form = new EventMain();
            form.ShowDialog();
            if (form.GetDone()) 
            {
                UpdateTable();
                SaveLoadService.status = BaseStatus.Edit;
                this.Text = "База ивентов (*)";
            }
        }

        private void RemoveEvent(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0) { return; }
            int iItem = listView1.SelectedItems[0].Index;
            SaveLoadService.E_list.RemoveAt(iItem);
            UpdateTable();
            SaveLoadService.status = BaseStatus.Edit;
            this.Text = "База ивентов (*)";
        }

        private void EditEvent(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0) { return; }
            int iItem = listView1.SelectedItems[0].Index;
            EventProperties form = new EventProperties(iItem);
            form.ShowDialog();
            if (form.GetDone()) 
            {
                UpdateTable();
                SaveLoadService.status = BaseStatus.Edit;
                this.Text = "База ивентов (*)";
            }
        }

        private void ColumnSort(object sender, ColumnClickEventArgs e)
        {
            // Доработать уже после презентования
        }

        private void CreatePDF(object sender, MouseEventArgs e)
        {
            PDFService.SaveFile(IdSelectEvent);
            progressBar1.Value = 2;
        }
    }
}

/*
Доработать:
1. Каждое название ивента, класса, параметра должно быть уникальным; (выполнено)
2. Сделай PDF отображение и привяжи к кнопке; (выполнено)
3. Поставь try-catch там где ошибки могут быть;
4. Добавь настройки PDF;

Опционально:
1. Сортировку ивентов по столбцам;
2. Настройки приложения;
 */