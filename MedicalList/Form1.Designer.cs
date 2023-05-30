namespace MedicalList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idinvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresscompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalListDataSet = new MedicalList.MedicalListDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinvoiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_medication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispensing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medical_form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummedicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceInvoiceMedicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.invoiceTableAdapter = new MedicalList.MedicalListDataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceMedicationsTableAdapter = new MedicalList.MedicalListDataSetTableAdapters.InvoiceMedicationsTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInvoiceMedicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinvoiceDataGridViewTextBoxColumn,
            this.number,
            this.dateDataGridViewTextBoxColumn,
            this.idworkerDataGridViewTextBoxColumn,
            this.full_name,
            this.position,
            this.companyDataGridViewTextBoxColumn,
            this.typecompanyDataGridViewTextBoxColumn,
            this.addresscompanyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idinvoiceDataGridViewTextBoxColumn
            // 
            this.idinvoiceDataGridViewTextBoxColumn.DataPropertyName = "id_invoice";
            this.idinvoiceDataGridViewTextBoxColumn.HeaderText = "id_invoice";
            this.idinvoiceDataGridViewTextBoxColumn.Name = "idinvoiceDataGridViewTextBoxColumn";
            this.idinvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idinvoiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "number";
            this.number.Name = "number";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "full_name";
            this.full_name.Name = "full_name";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "position";
            this.position.Name = "position";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // typecompanyDataGridViewTextBoxColumn
            // 
            this.typecompanyDataGridViewTextBoxColumn.DataPropertyName = "type_company";
            this.typecompanyDataGridViewTextBoxColumn.HeaderText = "type_company";
            this.typecompanyDataGridViewTextBoxColumn.Name = "typecompanyDataGridViewTextBoxColumn";
            // 
            // addresscompanyDataGridViewTextBoxColumn
            // 
            this.addresscompanyDataGridViewTextBoxColumn.DataPropertyName = "address_company";
            this.addresscompanyDataGridViewTextBoxColumn.HeaderText = "address_company";
            this.addresscompanyDataGridViewTextBoxColumn.Name = "addresscompanyDataGridViewTextBoxColumn";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.medicalListDataSet;
            // 
            // medicalListDataSet
            // 
            this.medicalListDataSet.DataSetName = "MedicalListDataSet";
            this.medicalListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idinvoiceDataGridViewTextBoxColumn1,
            this.idmedicationDataGridViewTextBoxColumn,
            this.name_medication,
            this.name_category,
            this.unit,
            this.dispensing,
            this.medical_form,
            this.manufacturer_name,
            this.nummedicationsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sum});
            this.dataGridView2.DataSource = this.invoiceInvoiceMedicationsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(944, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idinvoiceDataGridViewTextBoxColumn1
            // 
            this.idinvoiceDataGridViewTextBoxColumn1.DataPropertyName = "id_invoice";
            this.idinvoiceDataGridViewTextBoxColumn1.HeaderText = "id_invoice";
            this.idinvoiceDataGridViewTextBoxColumn1.Name = "idinvoiceDataGridViewTextBoxColumn1";
            this.idinvoiceDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idmedicationDataGridViewTextBoxColumn
            // 
            this.idmedicationDataGridViewTextBoxColumn.DataPropertyName = "id_medication";
            this.idmedicationDataGridViewTextBoxColumn.HeaderText = "id_medication";
            this.idmedicationDataGridViewTextBoxColumn.Name = "idmedicationDataGridViewTextBoxColumn";
            this.idmedicationDataGridViewTextBoxColumn.Visible = false;
            // 
            // name_medication
            // 
            this.name_medication.DataPropertyName = "name_medication";
            this.name_medication.HeaderText = "name_medication";
            this.name_medication.Name = "name_medication";
            // 
            // name_category
            // 
            this.name_category.DataPropertyName = "name_category";
            this.name_category.HeaderText = "name_category";
            this.name_category.Name = "name_category";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "unit";
            this.unit.Name = "unit";
            // 
            // dispensing
            // 
            this.dispensing.DataPropertyName = "dispensing";
            this.dispensing.HeaderText = "dispensing";
            this.dispensing.Name = "dispensing";
            // 
            // medical_form
            // 
            this.medical_form.DataPropertyName = "medical_form";
            this.medical_form.HeaderText = "medical_form";
            this.medical_form.Name = "medical_form";
            // 
            // manufacturer_name
            // 
            this.manufacturer_name.DataPropertyName = "manufacturer_name";
            this.manufacturer_name.HeaderText = "manufacturer_name";
            this.manufacturer_name.Name = "manufacturer_name";
            // 
            // nummedicationsDataGridViewTextBoxColumn
            // 
            this.nummedicationsDataGridViewTextBoxColumn.DataPropertyName = "num_medications";
            this.nummedicationsDataGridViewTextBoxColumn.HeaderText = "num_medications";
            this.nummedicationsDataGridViewTextBoxColumn.Name = "nummedicationsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sum
            // 
            this.sum.DataPropertyName = "sum";
            this.sum.HeaderText = "sum";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // invoiceInvoiceMedicationsBindingSource
            // 
            this.invoiceInvoiceMedicationsBindingSource.DataMember = "Invoice_InvoiceMedications";
            this.invoiceInvoiceMedicationsBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(973, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceMedicationsTableAdapter
            // 
            this.invoiceMedicationsTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(844, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInvoiceMedicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MedicalListDataSet medicalListDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private MedicalListDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource invoiceInvoiceMedicationsBindingSource;
        private MedicalListDataSetTableAdapters.InvoiceMedicationsTableAdapter invoiceMedicationsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresscompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvoiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_medication;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispensing;
        private System.Windows.Forms.DataGridViewTextBoxColumn medical_form;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummedicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.Button button4;
    }
}

