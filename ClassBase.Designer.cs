namespace SpaceStation14_EventCardCreator
{
    partial class ClassBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClassAddTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassRemoveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 384);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CheckParams);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Классы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(289, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(271, 384);
            this.listBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Значения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassMenu
            // 
            this.ClassMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassAddTSMI,
            this.ClassRemoveTSMI});
            this.ClassMenu.Name = "ClassMenu";
            this.ClassMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // ClassAddTSMI
            // 
            this.ClassAddTSMI.Name = "ClassAddTSMI";
            this.ClassAddTSMI.Size = new System.Drawing.Size(180, 22);
            this.ClassAddTSMI.Text = "Добавить класс";
            this.ClassAddTSMI.Click += new System.EventHandler(this.AddClass);
            // 
            // ClassRemoveTSMI
            // 
            this.ClassRemoveTSMI.Name = "ClassRemoveTSMI";
            this.ClassRemoveTSMI.Size = new System.Drawing.Size(180, 22);
            this.ClassRemoveTSMI.Text = "Удалить класс";
            this.ClassRemoveTSMI.Click += new System.EventHandler(this.DeleteClass);
            // 
            // ClassBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "ClassBase";
            this.Text = "Классификации";
            this.ClassMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ClassMenu;
        private System.Windows.Forms.ToolStripMenuItem ClassAddTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClassRemoveTSMI;
    }
}