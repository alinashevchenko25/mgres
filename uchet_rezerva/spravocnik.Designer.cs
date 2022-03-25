namespace uchet_rezerva
{
    partial class spravocnik
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
            System.Windows.Forms.Timer timer1;
            System.Windows.Forms.Timer timer2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarojdeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestojitelstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrazovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opitrabotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapostupleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spravocnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spravocnikDataSet = new uchet_rezerva.spravocnikDataSet();
            this.spravocnikTableAdapter = new uchet_rezerva.spravocnikDataSetTableAdapters.SpravocnikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.наГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            timer1 = new System.Windows.Forms.Timer(this.components);
            timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsotrudnikaDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.datarojdeniaDataGridViewTextBoxColumn,
            this.mestojitelstvaDataGridViewTextBoxColumn,
            this.obrazovanieDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.doljnostDataGridViewTextBoxColumn,
            this.opitrabotiDataGridViewTextBoxColumn,
            this.datapostupleniaDataGridViewTextBoxColumn,
            this.okladDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.spravocnikBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Lavender;
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1516, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // idsotrudnikaDataGridViewTextBoxColumn
            // 
            this.idsotrudnikaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idsotrudnikaDataGridViewTextBoxColumn.DataPropertyName = "id_sotrudnika";
            this.idsotrudnikaDataGridViewTextBoxColumn.FillWeight = 532.9949F;
            this.idsotrudnikaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idsotrudnikaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idsotrudnikaDataGridViewTextBoxColumn.Name = "idsotrudnikaDataGridViewTextBoxColumn";
            this.idsotrudnikaDataGridViewTextBoxColumn.Width = 50;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 270;
            // 
            // datarojdeniaDataGridViewTextBoxColumn
            // 
            this.datarojdeniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datarojdeniaDataGridViewTextBoxColumn.DataPropertyName = "Data_rojdenia";
            this.datarojdeniaDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.datarojdeniaDataGridViewTextBoxColumn.HeaderText = "Дата рождения ";
            this.datarojdeniaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.datarojdeniaDataGridViewTextBoxColumn.Name = "datarojdeniaDataGridViewTextBoxColumn";
            // 
            // mestojitelstvaDataGridViewTextBoxColumn
            // 
            this.mestojitelstvaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mestojitelstvaDataGridViewTextBoxColumn.DataPropertyName = "Mesto_jitelstva";
            this.mestojitelstvaDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.mestojitelstvaDataGridViewTextBoxColumn.HeaderText = "Место жительства";
            this.mestojitelstvaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.mestojitelstvaDataGridViewTextBoxColumn.Name = "mestojitelstvaDataGridViewTextBoxColumn";
            this.mestojitelstvaDataGridViewTextBoxColumn.Width = 270;
            // 
            // obrazovanieDataGridViewTextBoxColumn
            // 
            this.obrazovanieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.obrazovanieDataGridViewTextBoxColumn.DataPropertyName = "obrazovanie";
            this.obrazovanieDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.obrazovanieDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.obrazovanieDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.obrazovanieDataGridViewTextBoxColumn.Name = "obrazovanieDataGridViewTextBoxColumn";
            this.obrazovanieDataGridViewTextBoxColumn.Width = 110;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // doljnostDataGridViewTextBoxColumn
            // 
            this.doljnostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.doljnostDataGridViewTextBoxColumn.DataPropertyName = "doljnost";
            this.doljnostDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.doljnostDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.doljnostDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.doljnostDataGridViewTextBoxColumn.Name = "doljnostDataGridViewTextBoxColumn";
            this.doljnostDataGridViewTextBoxColumn.Width = 200;
            // 
            // opitrabotiDataGridViewTextBoxColumn
            // 
            this.opitrabotiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.opitrabotiDataGridViewTextBoxColumn.DataPropertyName = "opit_raboti";
            this.opitrabotiDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.opitrabotiDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            this.opitrabotiDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opitrabotiDataGridViewTextBoxColumn.Name = "opitrabotiDataGridViewTextBoxColumn";
            this.opitrabotiDataGridViewTextBoxColumn.Width = 120;
            // 
            // datapostupleniaDataGridViewTextBoxColumn
            // 
            this.datapostupleniaDataGridViewTextBoxColumn.DataPropertyName = "data_postuplenia";
            this.datapostupleniaDataGridViewTextBoxColumn.FillWeight = 35.17041F;
            this.datapostupleniaDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.datapostupleniaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.datapostupleniaDataGridViewTextBoxColumn.Name = "datapostupleniaDataGridViewTextBoxColumn";
            // 
            // okladDataGridViewTextBoxColumn
            // 
            this.okladDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.okladDataGridViewTextBoxColumn.DataPropertyName = "oklad";
            this.okladDataGridViewTextBoxColumn.FillWeight = 235.6418F;
            this.okladDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.okladDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.okladDataGridViewTextBoxColumn.Name = "okladDataGridViewTextBoxColumn";
            this.okladDataGridViewTextBoxColumn.Width = 70;
            // 
            // spravocnikBindingSource
            // 
            this.spravocnikBindingSource.DataMember = "Spravocnik";
            this.spravocnikBindingSource.DataSource = this.spravocnikDataSet;
            // 
            // spravocnikDataSet
            // 
            this.spravocnikDataSet.DataSetName = "spravocnikDataSet";
            this.spravocnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spravocnikTableAdapter
            // 
            this.spravocnikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1052, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(289, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1195, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "СПРАВОЧНИК РАБОТНИКОВ\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГлавнуюToolStripMenuItem,
            this.добавитьЗаписьToolStripMenuItem,
            this.калькуляторToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1835, 41);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // наГлавнуюToolStripMenuItem
            // 
            this.наГлавнуюToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.наГлавнуюToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.наГлавнуюToolStripMenuItem.Name = "наГлавнуюToolStripMenuItem";
            this.наГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(163, 37);
            this.наГлавнуюToolStripMenuItem.Text = "На главную";
            this.наГлавнуюToolStripMenuItem.Click += new System.EventHandler(this.наГлавнуюToolStripMenuItem_Click);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.добавитьЗаписьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(224, 37);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.калькуляторToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(178, 37);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.label2.Location = new System.Drawing.Point(1263, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 91);
            this.label2.TabIndex = 4;
            this.label2.Text = "00:00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1453, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStr);
            this.groupBox1.Location = new System.Drawing.Point(1238, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(6, 17);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(197, 22);
            this.tbStr.TabIndex = 0;
            this.tbStr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // spravocnik
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1835, 690);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "spravocnik";
            this.Text = "Справочник";
            this.TransparencyKey = System.Drawing.SystemColors.ControlText;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.spravocnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public spravocnikDataSet spravocnikDataSet;
        public System.Windows.Forms.BindingSource spravocnikBindingSource;
        public spravocnikDataSetTableAdapters.SpravocnikTableAdapter spravocnikTableAdapter;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem наГлавнуюToolStripMenuItem;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsotrudnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarojdeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestojitelstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doljnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opitrabotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapostupleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okladDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}