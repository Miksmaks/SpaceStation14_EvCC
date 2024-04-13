namespace SpaceStation14_EventCardCreator
{
    partial class EventBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadBaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseSettingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClassTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PdfSettingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EventListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddEventTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EventDeleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EventEditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.EventListContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.EditTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateBaseTSMI,
            this.LoadBaseTSMI,
            this.SaveBaseTSMI,
            this.BaseSettingsTSMI});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateBaseTSMI
            // 
            this.CreateBaseTSMI.Name = "CreateBaseTSMI";
            this.CreateBaseTSMI.Size = new System.Drawing.Size(207, 22);
            this.CreateBaseTSMI.Text = "Создать базу ивентов";
            this.CreateBaseTSMI.Click += new System.EventHandler(this.CreateEventBase);
            // 
            // LoadBaseTSMI
            // 
            this.LoadBaseTSMI.Name = "LoadBaseTSMI";
            this.LoadBaseTSMI.Size = new System.Drawing.Size(207, 22);
            this.LoadBaseTSMI.Text = "Загрузить базу ивентов";
            this.LoadBaseTSMI.Click += new System.EventHandler(this.LoadEventBase);
            // 
            // SaveBaseTSMI
            // 
            this.SaveBaseTSMI.Name = "SaveBaseTSMI";
            this.SaveBaseTSMI.Size = new System.Drawing.Size(207, 22);
            this.SaveBaseTSMI.Text = "Сохранить базу ивентов";
            this.SaveBaseTSMI.Click += new System.EventHandler(this.SaveEventBase);
            // 
            // BaseSettingsTSMI
            // 
            this.BaseSettingsTSMI.Name = "BaseSettingsTSMI";
            this.BaseSettingsTSMI.Size = new System.Drawing.Size(207, 22);
            this.BaseSettingsTSMI.Text = "Настройки";
            // 
            // EditTSMI
            // 
            this.EditTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditClassTSMI,
            this.PdfSettingsTSMI});
            this.EditTSMI.Enabled = false;
            this.EditTSMI.Name = "EditTSMI";
            this.EditTSMI.Size = new System.Drawing.Size(73, 20);
            this.EditTSMI.Text = "Изменить";
            // 
            // EditClassTSMI
            // 
            this.EditClassTSMI.Name = "EditClassTSMI";
            this.EditClassTSMI.Size = new System.Drawing.Size(197, 22);
            this.EditClassTSMI.Text = "Редактировать классы";
            this.EditClassTSMI.Click += new System.EventHandler(this.OpenClassBase);
            // 
            // PdfSettingsTSMI
            // 
            this.PdfSettingsTSMI.Name = "PdfSettingsTSMI";
            this.PdfSettingsTSMI.Size = new System.Drawing.Size(197, 22);
            this.PdfSettingsTSMI.Text = "Настройки PDF";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Enabled = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(418, 456);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnSort);
            this.listView1.DoubleClick += new System.EventHandler(this.ItemSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата создания";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Оценка";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(436, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 423);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(100, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "---";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "---";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 61);
            this.label6.TabIndex = 9;
            this.label6.Text = "---";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 206);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 179);
            this.label5.TabIndex = 8;
            this.label5.Text = "---";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Краткое описание:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Оценка:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата создания:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название ивента:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(600, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать PDF страницу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreatePDF);
            // 
            // EventListContext
            // 
            this.EventListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEventTSMI,
            this.EventDeleteTSMI,
            this.EventEditTSMI});
            this.EventListContext.Name = "EventListContext";
            this.EventListContext.Size = new System.Drawing.Size(163, 70);
            // 
            // AddEventTSMI
            // 
            this.AddEventTSMI.Name = "AddEventTSMI";
            this.AddEventTSMI.Size = new System.Drawing.Size(162, 22);
            this.AddEventTSMI.Text = "Добавить ивент";
            this.AddEventTSMI.Click += new System.EventHandler(this.AddEvent);
            // 
            // EventDeleteTSMI
            // 
            this.EventDeleteTSMI.Name = "EventDeleteTSMI";
            this.EventDeleteTSMI.Size = new System.Drawing.Size(162, 22);
            this.EventDeleteTSMI.Text = "Удалить ивент";
            this.EventDeleteTSMI.Click += new System.EventHandler(this.RemoveEvent);
            // 
            // EventEditTSMI
            // 
            this.EventEditTSMI.Name = "EventEditTSMI";
            this.EventEditTSMI.Size = new System.Drawing.Size(162, 22);
            this.EventEditTSMI.Text = "Изменить ивент";
            this.EventEditTSMI.Click += new System.EventHandler(this.EditEvent);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(5, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "---";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(5, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Автор:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Автор";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = global::SpaceStation14_EventCardCreator.Properties.Resources.ss14_фон;
            this.pictureBox1.Location = new System.Drawing.Point(259, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(758, 456);
            this.progressBar1.Maximum = 2;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 27);
            this.progressBar1.TabIndex = 4;
            // 
            // EventBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 495);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EventBase";
            this.Text = "База ивентов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EventListContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateBaseTSMI;
        private System.Windows.Forms.ToolStripMenuItem LoadBaseTSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveBaseTSMI;
        private System.Windows.Forms.ToolStripMenuItem BaseSettingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem EditTSMI;
        private System.Windows.Forms.ToolStripMenuItem EditClassTSMI;
        private System.Windows.Forms.ToolStripMenuItem PdfSettingsTSMI;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip EventListContext;
        private System.Windows.Forms.ToolStripMenuItem AddEventTSMI;
        private System.Windows.Forms.ToolStripMenuItem EventDeleteTSMI;
        private System.Windows.Forms.ToolStripMenuItem EventEditTSMI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

