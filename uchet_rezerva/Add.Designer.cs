namespace uchet_rezerva
{
    partial class Add
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetrezervDataSet = new uchet_rezerva.uchetrezervDataSet();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.SotrudnikTableAdapter();
            this.rezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.RezervTableAdapter();
            this.documentsTableAdapter = new uchet_rezerva.uchetrezervDataSetTableAdapters.DocumentsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sotrudnikBindingSource;
            this.comboBox1.DisplayMember = "FIO";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id_sotrudnik";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.uchetrezervDataSet;
            // 
            // uchetrezervDataSet
            // 
            this.uchetrezervDataSet.DataSetName = "uchetrezervDataSet";
            this.uchetrezervDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.uchetrezervDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // rezervBindingSource
            // 
            this.rezervBindingSource.DataMember = "Rezerv";
            this.rezervBindingSource.DataSource = this.uchetrezervDataSet;
            // 
            // rezervTableAdapter
            // 
            this.rezervTableAdapter.ClearBeforeFill = true;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(242, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(147, 320);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(103, 38);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Добавить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.documentsBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(242, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 33);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID_doc";
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(342, 320);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(97, 38);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "ДОБАВИТЬ ЗАПИСЬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите документ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите подготовку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите номер";
            // 
            // tbNomer
            // 
            this.tbNomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNomer.Location = new System.Drawing.Point(242, 153);
            this.tbNomer.Multiline = true;
            this.tbNomer.Name = "tbNomer";
            this.tbNomer.Size = new System.Drawing.Size(275, 33);
            this.tbNomer.TabIndex = 8;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(626, 445);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Add";
            this.Text = "Добавить запись в резерв";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetrezervDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uchetrezervDataSet uchetrezervDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private uchetrezervDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource rezervBindingSource;
        private uchetrezervDataSetTableAdapters.RezervTableAdapter rezervTableAdapter;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private uchetrezervDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbNomer;
    }
}