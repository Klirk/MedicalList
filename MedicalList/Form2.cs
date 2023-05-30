using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.invoiceTableAdapter.Fill(this.medicalListDataSet.Invoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.Medications". При необходимости она может быть перемещена или удалена.
            this.medicationsTableAdapter.Fill(this.medicalListDataSet.Medications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.medicalListDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicalListDataSet.InvoiceMedications". При необходимости она может быть перемещена или удалена.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (MessageBox.Show("Ви дійсно бажаєте створити накладку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    invoiceTableAdapter.InsertQuery(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, (int)textBox2.Tag,"Med","Center","Address");
                    invoiceTableAdapter.Update(medicalListDataSet.Invoice);
                    invoiceTableAdapter.Fill(medicalListDataSet.Invoice);
                    textBox1.ReadOnly = true;
                    MessageBox.Show("Good", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ви маєте ввести номер наказу", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Додати до розрахунку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                invoiceMedicationsTableAdapter.Insert((int)invoiceTableAdapter.MaxQuery(), (int)textBox6.Tag, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                invoiceMedicationsTableAdapter.Update(medicalListDataSet.InvoiceMedications);
                this.invoiceMedicationsTableAdapter.FillBy1(this.medicalListDataSet.InvoiceMedications, (int)invoiceTableAdapter.MaxQuery());
            }
        }
    }
}
