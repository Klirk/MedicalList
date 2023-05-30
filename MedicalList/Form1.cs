using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MedicalList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.InvoiceMedications". При необходимости она может быть перемещена или удалена.
            this.invoiceMedicationsTableAdapter.FillBy(this.medicalListDataSet.InvoiceMedications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.FillBy(this.medicalListDataSet.Invoice);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (dataGridView2.Rows.Count <= 1)
            {
                if (MessageBox.Show("Ви действительно хотите удалить накладную", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    invoiceTableAdapter.DeleteInvoice((int)dataGridView1.CurrentRow.Cells[0].Value);
                    invoiceTableAdapter.Update(medicalListDataSet.Invoice); //осуществляет удаление записей в БД
                    invoiceTableAdapter.FillBy(medicalListDataSet.Invoice);
                    MessageBox.Show("Good", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Нельзя удалить накладную, в которой есть медикаменты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви действительно хотите удалить накладную", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                invoiceMedicationsTableAdapter.DeleteMedInvoice((int)dataGridView2.CurrentRow.Cells[0].Value);
                invoiceMedicationsTableAdapter.Update(medicalListDataSet.InvoiceMedications); //осуществляет удаление записей в БД
                invoiceMedicationsTableAdapter.FillBy(medicalListDataSet.InvoiceMedications);
                MessageBox.Show("Good", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); //открывает форму
            invoiceTableAdapter.FillBy(medicalListDataSet.Invoice);
            invoiceMedicationsTableAdapter.FillBy(medicalListDataSet.InvoiceMedications);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(); //открывает форму
            
        }
    }
}
