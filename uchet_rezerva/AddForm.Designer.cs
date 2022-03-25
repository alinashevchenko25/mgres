namespace uchet_rezerva
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboklad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbopit_raboti = new System.Windows.Forms.TextBox();
            this.tbdoljnost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbobrazovanie = new System.Windows.Forms.TextBox();
            this.tbMesto_jitelstva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetrezervDataSet = new uchet_rezerva.uchetrezervDataSet();
            this.spravocnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spravocnikDataSet = new uchet_rezerva.spravocnikDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.sotrudnikTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.SotrudnikTableAdapter();
            this.spravocnikTableAdapter = new uchet_rezerva.spravocnikDataSetTableAdapters.SpravocnikTableAdapter();
            this.documentsTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.DocumentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.documentsRezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.RezervTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsRezervBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.tboklad);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbopit_raboti);
            this.groupBox1.Controls.Add(this.tbdoljnost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbobrazovanie);
            this.groupBox1.Controls.Add(this.tbMesto_jitelstva);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbfio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tboklad
            // 
            this.tboklad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboklad.Location = new System.Drawing.Point(730, 168);
            this.tboklad.Name = "tboklad";
            this.tboklad.Size = new System.Drawing.Size(263, 36);
            this.tboklad.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(528, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Оклад";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(528, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Дата поступления";
            // 
            // tbopit_raboti
            // 
            this.tbopit_raboti.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbopit_raboti.Location = new System.Drawing.Point(730, 80);
            this.tbopit_raboti.Name = "tbopit_raboti";
            this.tbopit_raboti.Size = new System.Drawing.Size(263, 36);
            this.tbopit_raboti.TabIndex = 29;
            // 
            // tbdoljnost
            // 
            this.tbdoljnost.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbdoljnost.Location = new System.Drawing.Point(730, 38);
            this.tbdoljnost.Name = "tbdoljnost";
            this.tbdoljnost.Size = new System.Drawing.Size(263, 36);
            this.tbdoljnost.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(528, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Должность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(528, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Опыт работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Телефон";
            // 
            // tbobrazovanie
            // 
            this.tbobrazovanie.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbobrazovanie.Location = new System.Drawing.Point(211, 168);
            this.tbobrazovanie.Name = "tbobrazovanie";
            this.tbobrazovanie.Size = new System.Drawing.Size(263, 36);
            this.tbobrazovanie.TabIndex = 23;
            // 
            // tbMesto_jitelstva
            // 
            this.tbMesto_jitelstva.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMesto_jitelstva.Location = new System.Drawing.Point(211, 126);
            this.tbMesto_jitelstva.Name = "tbMesto_jitelstva";
            this.tbMesto_jitelstva.Size = new System.Drawing.Size(263, 36);
            this.tbMesto_jitelstva.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Образование";
            // 
            // tbfio
            // 
            this.tbfio.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbfio.Location = new System.Drawing.Point(211, 38);
            this.tbfio.Name = "tbfio";
            this.tbfio.Size = new System.Drawing.Size(263, 36);
            this.tbfio.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Место жительства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "ФИО";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.uchetrezervDataSet;
            // 
            // uchetrezervDataSet
            // 
            this.uchetrezervDataSet.DataSetName = "uchetrezervDataSet";
            this.uchetrezervDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.uchetrezervDataSet;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(297, 428);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(123, 49);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(654, 426);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(123, 51);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // spravocnikTableAdapter
            // 
            this.spravocnikTableAdapter.ClearBeforeFill = true;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(301, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "ДОБАВИТЬ ЗАПИСЬ";
            // 
            // documentsRezervBindingSource
            // 
            this.documentsRezervBindingSource.DataMember = "DocumentsRezerv";
            this.documentsRezervBindingSource.DataSource = this.documentsBindingSource;
            // 
            // rezervTableAdapter
            // 
            this.rezervTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 36);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.maskedTextBox1.Location = new System.Drawing.Point(211, 210);
            this.maskedTextBox1.Mask = "(999) 00-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(263, 36);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.dateTimePicker2.Location = new System.Drawing.Point(730, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(263, 36);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1017, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddForm";
            this.Text = "Добавить запись в справочник";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravocnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsRezervBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private uchetrezervDataSet uchetrezervDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private uchetrezervDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.TextBox tbfio;
        private spravocnikDataSet spravocnikDataSet;
        private System.Windows.Forms.BindingSource spravocnikBindingSource;
        private spravocnikDataSetTableAdapters.SpravocnikTableAdapter spravocnikTableAdapter;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private uchetrezervDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource documentsRezervBindingSource;
        private uchetrezervDataSetTableAdapters.RezervTableAdapter rezervTableAdapter;
        private System.Windows.Forms.TextBox tbopit_raboti;
        private System.Windows.Forms.TextBox tbdoljnost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbobrazovanie;
        private System.Windows.Forms.TextBox tbMesto_jitelstva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboklad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}