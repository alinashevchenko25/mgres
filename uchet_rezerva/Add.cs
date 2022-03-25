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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.uchetrezervDataSet.Documents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Rezerv". При необходимости она может быть перемещена или удалена.
            this.rezervTableAdapter.Fill(this.uchetrezervDataSet.Rezerv);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.uchetrezervDataSet.Sotrudnik);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
