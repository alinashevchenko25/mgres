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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }



        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Rezerv". При необходимости она может быть перемещена или удалена.
            this.rezervTableAdapter.Fill(this.uchetrezervDataSet.Rezerv);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.uchetrezervDataSet.Documents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spravocnikDataSet.Spravocnik". При необходимости она может быть перемещена или удалена.
            this.spravocnikTableAdapter.Fill(this.spravocnikDataSet.Spravocnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetrezervDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.uchetrezervDataSet.Sotrudnik);

        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
         
                spravocnik main = this.Owner as spravocnik;
                if (main != null)
            {
                DataRow nRow = main.spravocnikDataSet.Tables[0].NewRow();
                //int rc = main.dataGridView1.RowCount + 1;
                //nRow[0] = rc;
                nRow[1] = tbfio.Text;
                nRow[2] = dateTimePicker1.Text;
                nRow[3] = tbMesto_jitelstva.Text;
                nRow[4] = tbobrazovanie.Text;
                nRow[5] = maskedTextBox1.Text;
                nRow[6] = tbdoljnost.Text;
                nRow[7] = tbopit_raboti.Text;
                nRow[8] = dateTimePicker2.Text;
                nRow[9] = tboklad.Text;
                main.spravocnikDataSet.Tables[0].Rows.Add(nRow);
                main.spravocnikTableAdapter.Update(main.spravocnikDataSet);
                main.spravocnikDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbfio.Text = "";
                //tbData_rojdenia.Text = "";
                tbMesto_jitelstva.Text = "";
                tbobrazovanie.Text = "";
                //tbtelefon.Text = "";
                tbdoljnost.Text = "";
                tbopit_raboti.Text = "";
                //tbdata_postuplenia.Text = "";
                tboklad.Text = "";

                Close();

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
