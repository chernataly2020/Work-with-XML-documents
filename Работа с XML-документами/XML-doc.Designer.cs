namespace Работа_с_XML_документами
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОткрытьДокумент = new System.Windows.Forms.ToolStripMenuItem();
            this.сПомощьюXmlDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПомощьюXmlTextReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПомощьюXmlValidationgReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СохранитьДокумент = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ДобавитьЗаказ = new System.Windows.Forms.Button();
            this.Адрес = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ДатаЗаказа = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ДобавитьТовар = new System.Windows.Forms.Button();
            this.Цена = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.НазваниеТовара = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьДокументToolStripMenuItem,
            this.ОткрытьДокумент,
            this.СохранитьДокумент,
            this.закрытьToolStripMenuItem});
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(45, 20);
            this.Файл.Text = "Файл";
            // 
            // создатьДокументToolStripMenuItem
            // 
            this.создатьДокументToolStripMenuItem.Name = "создатьДокументToolStripMenuItem";
            this.создатьДокументToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.создатьДокументToolStripMenuItem.Text = "Создать документ";
            this.создатьДокументToolStripMenuItem.Click += new System.EventHandler(this.создатьДокументToolStripMenuItem_Click);
            // 
            // ОткрытьДокумент
            // 
            this.ОткрытьДокумент.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сПомощьюXmlDocumentToolStripMenuItem,
            this.сПомощьюXmlTextReaderToolStripMenuItem,
            this.сПомощьюXmlValidationgReaderToolStripMenuItem});
            this.ОткрытьДокумент.Name = "ОткрытьДокумент";
            this.ОткрытьДокумент.Size = new System.Drawing.Size(204, 22);
            this.ОткрытьДокумент.Text = "Открыть документ...";
            this.ОткрытьДокумент.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сПомощьюXmlDocumentToolStripMenuItem
            // 
            this.сПомощьюXmlDocumentToolStripMenuItem.Name = "сПомощьюXmlDocumentToolStripMenuItem";
            this.сПомощьюXmlDocumentToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.сПомощьюXmlDocumentToolStripMenuItem.Text = "с помощью XmlDocument";
            this.сПомощьюXmlDocumentToolStripMenuItem.Click += new System.EventHandler(this.сПомощьюXmlDocumentToolStripMenuItem_Click);
            // 
            // сПомощьюXmlTextReaderToolStripMenuItem
            // 
            this.сПомощьюXmlTextReaderToolStripMenuItem.Name = "сПомощьюXmlTextReaderToolStripMenuItem";
            this.сПомощьюXmlTextReaderToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.сПомощьюXmlTextReaderToolStripMenuItem.Text = "с помощью XmlTextReader";
            this.сПомощьюXmlTextReaderToolStripMenuItem.Click += new System.EventHandler(this.сПомощьюXmlTextReaderToolStripMenuItem_Click);
            // 
            // сПомощьюXmlValidationgReaderToolStripMenuItem
            // 
            this.сПомощьюXmlValidationgReaderToolStripMenuItem.Name = "сПомощьюXmlValidationgReaderToolStripMenuItem";
            this.сПомощьюXmlValidationgReaderToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.сПомощьюXmlValidationgReaderToolStripMenuItem.Text = "с помощью XmlValidationgReader";
            this.сПомощьюXmlValidationgReaderToolStripMenuItem.Click += new System.EventHandler(this.сПомощьюXmlValidationgReaderToolStripMenuItem_Click);
            // 
            // СохранитьДокумент
            // 
            this.СохранитьДокумент.Name = "СохранитьДокумент";
            this.СохранитьДокумент.Size = new System.Drawing.Size(204, 22);
            this.СохранитьДокумент.Text = "Сохранить документ...";
            this.СохранитьДокумент.Click += new System.EventHandler(this.СохранитьДокумент_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.справкаToolStripMenuItem1.Text = "О программе...";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 190);
            this.panel1.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(524, 180);
            this.treeView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ДобавитьЗаказ);
            this.groupBox1.Controls.Add(this.Адрес);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ДатаЗаказа);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый заказ";
            // 
            // ДобавитьЗаказ
            // 
            this.ДобавитьЗаказ.Location = new System.Drawing.Point(211, 77);
            this.ДобавитьЗаказ.Name = "ДобавитьЗаказ";
            this.ДобавитьЗаказ.Size = new System.Drawing.Size(113, 23);
            this.ДобавитьЗаказ.TabIndex = 4;
            this.ДобавитьЗаказ.Text = "Добавить заказ";
            this.ДобавитьЗаказ.UseVisualStyleBackColor = true;
            this.ДобавитьЗаказ.Click += new System.EventHandler(this.ДобавитьЗаказ_Click);
            // 
            // Адрес
            // 
            this.Адрес.Location = new System.Drawing.Point(386, 34);
            this.Адрес.Name = "Адрес";
            this.Адрес.Size = new System.Drawing.Size(142, 20);
            this.Адрес.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес:";
            // 
            // ДатаЗаказа
            // 
            this.ДатаЗаказа.Location = new System.Drawing.Point(53, 33);
            this.ДатаЗаказа.Name = "ДатаЗаказа";
            this.ДатаЗаказа.Size = new System.Drawing.Size(148, 20);
            this.ДатаЗаказа.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ДобавитьТовар);
            this.groupBox2.Controls.Add(this.Цена);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.НазваниеТовара);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Новый товар";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ДобавитьТовар
            // 
            this.ДобавитьТовар.Location = new System.Drawing.Point(207, 78);
            this.ДобавитьТовар.Name = "ДобавитьТовар";
            this.ДобавитьТовар.Size = new System.Drawing.Size(120, 23);
            this.ДобавитьТовар.TabIndex = 4;
            this.ДобавитьТовар.Text = "Добавить товар";
            this.ДобавитьТовар.UseVisualStyleBackColor = true;
            this.ДобавитьТовар.Click += new System.EventHandler(this.ДобавитьТовар_Click);
            // 
            // Цена
            // 
            this.Цена.Location = new System.Drawing.Point(430, 36);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(98, 20);
            this.Цена.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цена:";
            // 
            // НазваниеТовара
            // 
            this.НазваниеТовара.Location = new System.Drawing.Point(81, 36);
            this.НазваниеТовара.Name = "НазваниеТовара";
            this.НазваниеТовара.Size = new System.Drawing.Size(161, 20);
            this.НазваниеТовара.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работа с XML-документами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Файл;
        private System.Windows.Forms.ToolStripMenuItem ОткрытьДокумент;
        private System.Windows.Forms.ToolStripMenuItem СохранитьДокумент;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ДобавитьЗаказ;
        private System.Windows.Forms.TextBox Адрес;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ДатаЗаказа;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox НазваниеТовара;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Цена;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ДобавитьТовар;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem создатьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПомощьюXmlDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПомощьюXmlTextReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПомощьюXmlValidationgReaderToolStripMenuItem;
    }
}

