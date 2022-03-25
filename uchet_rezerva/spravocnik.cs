using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uchet_rezerva
{
    public partial class spravocnik : Form
    {
        public spravocnik()
        {
            InitializeComponent();
        }

        private void spravocnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spravocnikDataSet.Spravocnik". При необходимости она может быть перемещена или удалена.
            this.spravocnikTableAdapter.Fill(this.spravocnikDataSet.Spravocnik);

        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            af.Owner = this;
            af.Show();

            Close();
        }



        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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


        private void button2_Click(object sender, EventArgs e)
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

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalculator af = new kalculator();
            af.Owner = this;
            af.Show();
        }
    }
}