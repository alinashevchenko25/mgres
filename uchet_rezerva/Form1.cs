using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace uchet_rezerva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.uchetrezervDataSet.Uchet);

        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravocnik af = new spravocnik();
            af.Owner = this;
            af.Show();

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            vremia.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void vremia_Click(object sender, EventArgs e)
        {

        }

        private void tbStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://moldgres.com/");
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalculator af = new kalculator();
            af.Owner = this;
            af.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add f = new Add(); // создать форму

            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то добавить работника
                int id_sotrudnik, id_document;
                String podgotovka;

                id_sotrudnik = int.Parse(f.comboBox1.SelectedValue.ToString());
                id_document = int.Parse(f.comboBox2.SelectedValue.ToString());
                podgotovka = f.textBox1.Text;


                //this.вBindingSource.EndEdit();
                this.rezervTableAdapter1.Insert(id_sotrudnik, id_document, podgotovka); // вставка
                this.rezervTableAdapter1.Update(uchetrezervDataSet);

                this.uchetTableAdapter.Fill(this.uchetrezervDataSet.Uchet);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            // Inventory => Delete
            DeleteForm f = new DeleteForm();
            int id_sotrudnik, id_document, id_rezerv;
            String podgotovka;

            int index;
            // взять индекс выделенной (текущей) строки в dataGridView2
            index = dataGridView1.CurrentRow.Index;

            // взять значения полей строки с номером index

            id_sotrudnik = Convert.ToInt32(dataGridView1[9, index].Value);
            id_document = Convert.ToInt32(dataGridView1[8, index].Value);
            podgotovka = dataGridView1[4, index].Value.ToString();
            id_rezerv = Convert.ToInt32(dataGridView1[10, index].Value);
            // сформировать информационную строку в окне FormDelAccount
            //f.label2.Text = FIO + " / " + Doljnosti + " / " + Opit_raboti + " / " + Podgotovka + " / " + Naimenovanie + " / " + Nomer + " / " + Data;

            if (f.ShowDialog() == DialogResult.OK) // вывести окно
            {
                this.rezervTableAdapter1.Delete(id_sotrudnik, id_document, podgotovka, id_rezerv); // удалить строку
                this.rezervTableAdapter1.Update(uchetrezervDataSet); // зафиксировать изменения
                this.uchetTableAdapter.Fill(this.uchetrezervDataSet.Uchet);
            }
        }
    }
}
           
            

    

        
      

