namespace uchet_rezerva
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrazovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opitrabotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podgotovkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDrezervDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchetrezervDataSet = new uchet_rezerva.uchetrezervDataSet();
            this.uchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.UchetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.vremia = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.rezervTableAdapter1 = new uchet_rezerva.uchetrezervDataSetTableAdapters.RezervTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.uchetrezervDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.doljnostiDataGridViewTextBoxColumn,
            this.obrazovanieDataGridViewTextBoxColumn,
            this.opitrabotiDataGridViewTextBoxColumn,
            this.podgotovkaDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iddocumentDataGridViewTextBoxColumn,
            this.idsotrudnikDataGridViewTextBoxColumn,
            this.iDrezervDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.uchetBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.Location = new System.Drawing.Point(13, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1515, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // doljnostiDataGridViewTextBoxColumn
            // 
            this.doljnostiDataGridViewTextBoxColumn.DataPropertyName = "Doljnosti";
            this.doljnostiDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.doljnostiDataGridViewTextBoxColumn.Name = "doljnostiDataGridViewTextBoxColumn";
            // 
            // obrazovanieDataGridViewTextBoxColumn
            // 
            this.obrazovanieDataGridViewTextBoxColumn.DataPropertyName = "Obrazovanie";
            this.obrazovanieDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.obrazovanieDataGridViewTextBoxColumn.Name = "obrazovanieDataGridViewTextBoxColumn";
            // 
            // opitrabotiDataGridViewTextBoxColumn
            // 
            this.opitrabotiDataGridViewTextBoxColumn.DataPropertyName = "Opit_raboti";
            this.opitrabotiDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            this.opitrabotiDataGridViewTextBoxColumn.Name = "opitrabotiDataGridViewTextBoxColumn";
            // 
            // podgotovkaDataGridViewTextBoxColumn
            // 
            this.podgotovkaDataGridViewTextBoxColumn.DataPropertyName = "Podgotovka";
            this.podgotovkaDataGridViewTextBoxColumn.HeaderText = "Подготовка";
            this.podgotovkaDataGridViewTextBoxColumn.Name = "podgotovkaDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "Nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // iddocumentDataGridViewTextBoxColumn
            // 
            this.iddocumentDataGridViewTextBoxColumn.DataPropertyName = "id_document";
            this.iddocumentDataGridViewTextBoxColumn.HeaderText = "ID-документа";
            this.iddocumentDataGridViewTextBoxColumn.Name = "iddocumentDataGridViewTextBoxColumn";
            // 
            // idsotrudnikDataGridViewTextBoxColumn
            // 
            this.idsotrudnikDataGridViewTextBoxColumn.DataPropertyName = "id_sotrudnik";
            this.idsotrudnikDataGridViewTextBoxColumn.HeaderText = "ID-сотрудник";
            this.idsotrudnikDataGridViewTextBoxColumn.Name = "idsotrudnikDataGridViewTextBoxColumn";
            // 
            // iDrezervDataGridViewTextBoxColumn
            // 
            this.iDrezervDataGridViewTextBoxColumn.DataPropertyName = "ID_rezerv";
            this.iDrezervDataGridViewTextBoxColumn.HeaderText = "ID-резерв";
            this.iDrezervDataGridViewTextBoxColumn.Name = "iDrezervDataGridViewTextBoxColumn";
            // 
            // uchetBindingSource1
            // 
            this.uchetBindingSource1.DataMember = "Uchet";
            this.uchetBindingSource1.DataSource = this.uchetrezervDataSet;
            // 
            // uchetrezervDataSet
            // 
            this.uchetrezervDataSet.DataSetName = "uchetrezervDataSet";
            this.uchetrezervDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uchetBindingSource
            // 
            this.uchetBindingSource.DataMember = "Uchet";
            this.uchetBindingSource.DataSource = this.uchetrezervDataSet;
            // 
            // uchetTableAdapter
            // 
            this.uchetTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.калькуляторToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1587, 41);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.справочникToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(171, 37);
            this.справочникToolStripMenuItem.Text = "Справочник";
            this.справочникToolStripMenuItem.Click += new System.EventHandler(this.справочникToolStripMenuItem_Click);
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.калькуляторToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(178, 37);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(426, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "КАДРОВЫЙ РЕЗЕРВ\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vremia
            // 
            this.vremia.AutoSize = true;
            this.vremia.Enabled = false;
            this.vremia.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vremia.Location = new System.Drawing.Point(1259, 41);
            this.vremia.Name = "vremia";
            this.vremia.Size = new System.Drawing.Size(347, 91);
            this.vremia.TabIndex = 7;
            this.vremia.Text = "00:00:00";
            this.vremia.Click += new System.EventHandler(this.vremia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStr);
            this.groupBox1.Location = new System.Drawing.Point(1199, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(5, 15);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(219, 27);
            this.tbStr.TabIndex = 0;
            this.tbStr.TextChanged += new System.EventHandler(this.tbStr_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1435, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Lavender;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1363, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(224, 33);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Официальный сайт";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1161, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rezervTableAdapter1
            // 
            this.rezervTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1355, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uchetrezervDataSetBindingSource
            // 
            this.uchetrezervDataSetBindingSource.DataSource = this.uchetrezervDataSet;
            this.uchetrezervDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1587, 741);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vremia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кадровый резерв";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public uchetrezervDataSet uchetrezervDataSet;
        public System.Windows.Forms.BindingSource uchetBindingSource;
        public uchetrezervDataSetTableAdapters.UchetTableAdapter uchetTableAdapter;
        public System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label vremia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private uchetrezervDataSetTableAdapters.RezervTableAdapter rezervTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource uchetBindingSource1;
        private System.Windows.Forms.BindingSource uchetrezervDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doljnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opitrabotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podgotovkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrezervDataGridViewTextBoxColumn;
    }
}

