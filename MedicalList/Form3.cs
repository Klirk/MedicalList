using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalList
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.Medications". При необходимости она может быть перемещена или удалена.
            this.medicationsTableAdapter.Fill(this.medicalListDataSet.Medications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.medicalListDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.View". При необходимости она может быть перемещена или удалена.
            this.viewTableAdapter.Fill(this.medicalListDataSet.View);
            label1.Text = "Total sum:" + total_sum("priceDataGridViewTextBoxColumn").ToString();
            label2.Text = "Total number:" + total_sum("numberDataGridViewTextBoxColumn").ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("(date >= '{0}') and (date <= '{1}')", dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            
            if(comboBox1.SelectedIndex == 0)
            {
                str.AppendFormat("and (name_category = '{0}')", dataGridView2.CurrentRow.Cells["namecategoryDataGridViewTextBoxColumn1"].Value.ToString());
            }
            if (comboBox1.SelectedIndex == 1)
            {
                str.AppendFormat("and (name_medication = '{0}')", dataGridView3.CurrentRow.Cells["namemedicationDataGridViewTextBoxColumn1"].Value.ToString());
            }
            viewBindingSource.Filter = str.ToString();

            label1.Text ="Total sum:" + total_sum("priceDataGridViewTextBoxColumn").ToString();
            label2.Text = "Total number:" + total_sum("numberDataGridViewTextBoxColumn").ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView3.Visible = false;
                dataGridView2.Visible = true;
            }
            else
            {
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
            }
        }

        private int total_sum(string name)
        {
            int columnIndex = dataGridView1.Columns[name].Index; // Замените "ColumnName" на имя нужного столбца

            int sum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    int cellValue;
                    if (int.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            return sum;
        }
    }

}
