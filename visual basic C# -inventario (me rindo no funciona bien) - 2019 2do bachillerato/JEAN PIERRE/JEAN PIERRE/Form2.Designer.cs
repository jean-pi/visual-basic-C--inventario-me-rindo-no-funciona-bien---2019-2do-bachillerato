namespace JEAN_PIERRE
{
    partial class Form2
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label fecha_de_llegadaLabel;
            System.Windows.Forms.Label fecha_de_desalojoLabel;
            System.Windows.Forms.Label clase_de_habitacionLabel;
            System.Windows.Forms.Label numero_de_habitacionLabel;
            System.Windows.Forms.Label pago_totalLabel;
            System.Windows.Forms.Label forma_de_pagoLabel;
            this.base_hotel_archiDataSet = new JEAN_PIERRE.base_hotel_archiDataSet();
            this.hotel_baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_baseTableAdapter = new JEAN_PIERRE.base_hotel_archiDataSetTableAdapters.hotel_baseTableAdapter();
            this.tableAdapterManager = new JEAN_PIERRE.base_hotel_archiDataSetTableAdapters.TableAdapterManager();
            this.hotel_baseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_llegadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_de_desalojoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clase_de_habitacionTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_habitacionTextBox = new System.Windows.Forms.TextBox();
            this.pago_totalTextBox = new System.Windows.Forms.TextBox();
            this.forma_de_pagoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            fecha_de_llegadaLabel = new System.Windows.Forms.Label();
            fecha_de_desalojoLabel = new System.Windows.Forms.Label();
            clase_de_habitacionLabel = new System.Windows.Forms.Label();
            numero_de_habitacionLabel = new System.Windows.Forms.Label();
            pago_totalLabel = new System.Windows.Forms.Label();
            forma_de_pagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.base_hotel_archiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_baseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_baseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 6);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(16, 32);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(16, 58);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(46, 13);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "apellido:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(16, 84);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(42, 13);
            cedulaLabel.TabIndex = 6;
            cedulaLabel.Text = "cedula:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(16, 110);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(34, 13);
            edadLabel.TabIndex = 8;
            edadLabel.Text = "edad:";
            // 
            // fecha_de_llegadaLabel
            // 
            fecha_de_llegadaLabel.AutoSize = true;
            fecha_de_llegadaLabel.Location = new System.Drawing.Point(16, 137);
            fecha_de_llegadaLabel.Name = "fecha_de_llegadaLabel";
            fecha_de_llegadaLabel.Size = new System.Drawing.Size(89, 13);
            fecha_de_llegadaLabel.TabIndex = 10;
            fecha_de_llegadaLabel.Text = "fecha de llegada:";
            // 
            // fecha_de_desalojoLabel
            // 
            fecha_de_desalojoLabel.AutoSize = true;
            fecha_de_desalojoLabel.Location = new System.Drawing.Point(16, 163);
            fecha_de_desalojoLabel.Name = "fecha_de_desalojoLabel";
            fecha_de_desalojoLabel.Size = new System.Drawing.Size(94, 13);
            fecha_de_desalojoLabel.TabIndex = 12;
            fecha_de_desalojoLabel.Text = "fecha de desalojo:";
            // 
            // clase_de_habitacionLabel
            // 
            clase_de_habitacionLabel.AutoSize = true;
            clase_de_habitacionLabel.Location = new System.Drawing.Point(16, 188);
            clase_de_habitacionLabel.Name = "clase_de_habitacionLabel";
            clase_de_habitacionLabel.Size = new System.Drawing.Size(102, 13);
            clase_de_habitacionLabel.TabIndex = 14;
            clase_de_habitacionLabel.Text = "clase de habitacion:";
            // 
            // numero_de_habitacionLabel
            // 
            numero_de_habitacionLabel.AutoSize = true;
            numero_de_habitacionLabel.Location = new System.Drawing.Point(16, 214);
            numero_de_habitacionLabel.Name = "numero_de_habitacionLabel";
            numero_de_habitacionLabel.Size = new System.Drawing.Size(112, 13);
            numero_de_habitacionLabel.TabIndex = 16;
            numero_de_habitacionLabel.Text = "numero de habitacion:";
            // 
            // pago_totalLabel
            // 
            pago_totalLabel.AutoSize = true;
            pago_totalLabel.Location = new System.Drawing.Point(16, 240);
            pago_totalLabel.Name = "pago_totalLabel";
            pago_totalLabel.Size = new System.Drawing.Size(57, 13);
            pago_totalLabel.TabIndex = 18;
            pago_totalLabel.Text = "pago total:";
            // 
            // forma_de_pagoLabel
            // 
            forma_de_pagoLabel.AutoSize = true;
            forma_de_pagoLabel.Location = new System.Drawing.Point(16, 266);
            forma_de_pagoLabel.Name = "forma_de_pagoLabel";
            forma_de_pagoLabel.Size = new System.Drawing.Size(78, 13);
            forma_de_pagoLabel.TabIndex = 20;
            forma_de_pagoLabel.Text = "forma de pago:";
            // 
            // base_hotel_archiDataSet
            // 
            this.base_hotel_archiDataSet.DataSetName = "base_hotel_archiDataSet";
            this.base_hotel_archiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotel_baseBindingSource
            // 
            this.hotel_baseBindingSource.DataMember = "hotel base";
            this.hotel_baseBindingSource.DataSource = this.base_hotel_archiDataSet;
            // 
            // hotel_baseTableAdapter
            // 
            this.hotel_baseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hotel_baseTableAdapter = this.hotel_baseTableAdapter;
            this.tableAdapterManager.UpdateOrder = JEAN_PIERRE.base_hotel_archiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotel_baseDataGridView
            // 
            this.hotel_baseDataGridView.AllowUserToAddRows = false;
            this.hotel_baseDataGridView.AllowUserToDeleteRows = false;
            this.hotel_baseDataGridView.AutoGenerateColumns = false;
            this.hotel_baseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotel_baseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.hotel_baseDataGridView.DataSource = this.hotel_baseBindingSource;
            this.hotel_baseDataGridView.Location = new System.Drawing.Point(12, 12);
            this.hotel_baseDataGridView.Name = "hotel_baseDataGridView";
            this.hotel_baseDataGridView.ReadOnly = true;
            this.hotel_baseDataGridView.Size = new System.Drawing.Size(1105, 179);
            this.hotel_baseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cedula";
            this.dataGridViewTextBoxColumn4.HeaderText = "cedula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "edad";
            this.dataGridViewTextBoxColumn5.HeaderText = "edad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha de llegada";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha de llegada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha de desalojo";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha de desalojo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "clase de habitacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "clase de habitacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "numero de habitacion";
            this.dataGridViewTextBoxColumn9.HeaderText = "numero de habitacion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "pago total";
            this.dataGridViewTextBoxColumn10.HeaderText = "pago total";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "forma de pago";
            this.dataGridViewTextBoxColumn11.HeaderText = "forma de pago";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(apellidoLabel);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(cedulaLabel);
            this.panel1.Controls.Add(this.cedulaTextBox);
            this.panel1.Controls.Add(edadLabel);
            this.panel1.Controls.Add(this.edadTextBox);
            this.panel1.Controls.Add(fecha_de_llegadaLabel);
            this.panel1.Controls.Add(this.fecha_de_llegadaDateTimePicker);
            this.panel1.Controls.Add(fecha_de_desalojoLabel);
            this.panel1.Controls.Add(this.fecha_de_desalojoDateTimePicker);
            this.panel1.Controls.Add(clase_de_habitacionLabel);
            this.panel1.Controls.Add(this.clase_de_habitacionTextBox);
            this.panel1.Controls.Add(numero_de_habitacionLabel);
            this.panel1.Controls.Add(this.numero_de_habitacionTextBox);
            this.panel1.Controls.Add(pago_totalLabel);
            this.panel1.Controls.Add(this.pago_totalTextBox);
            this.panel1.Controls.Add(forma_de_pagoLabel);
            this.panel1.Controls.Add(this.forma_de_pagoTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 304);
            this.panel1.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(134, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(134, 29);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(134, 55);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 5;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(134, 81);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cedulaTextBox.TabIndex = 7;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(134, 107);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(200, 20);
            this.edadTextBox.TabIndex = 9;
            // 
            // fecha_de_llegadaDateTimePicker
            // 
            this.fecha_de_llegadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hotel_baseBindingSource, "fecha de llegada", true));
            this.fecha_de_llegadaDateTimePicker.Location = new System.Drawing.Point(134, 133);
            this.fecha_de_llegadaDateTimePicker.Name = "fecha_de_llegadaDateTimePicker";
            this.fecha_de_llegadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_llegadaDateTimePicker.TabIndex = 11;
            // 
            // fecha_de_desalojoDateTimePicker
            // 
            this.fecha_de_desalojoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hotel_baseBindingSource, "fecha de desalojo", true));
            this.fecha_de_desalojoDateTimePicker.Location = new System.Drawing.Point(134, 159);
            this.fecha_de_desalojoDateTimePicker.Name = "fecha_de_desalojoDateTimePicker";
            this.fecha_de_desalojoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_desalojoDateTimePicker.TabIndex = 13;
            // 
            // clase_de_habitacionTextBox
            // 
            this.clase_de_habitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "clase de habitacion", true));
            this.clase_de_habitacionTextBox.Location = new System.Drawing.Point(134, 185);
            this.clase_de_habitacionTextBox.Name = "clase_de_habitacionTextBox";
            this.clase_de_habitacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.clase_de_habitacionTextBox.TabIndex = 15;
            // 
            // numero_de_habitacionTextBox
            // 
            this.numero_de_habitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "numero de habitacion", true));
            this.numero_de_habitacionTextBox.Location = new System.Drawing.Point(134, 211);
            this.numero_de_habitacionTextBox.Name = "numero_de_habitacionTextBox";
            this.numero_de_habitacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.numero_de_habitacionTextBox.TabIndex = 17;
            // 
            // pago_totalTextBox
            // 
            this.pago_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "pago total", true));
            this.pago_totalTextBox.Location = new System.Drawing.Point(134, 237);
            this.pago_totalTextBox.Name = "pago_totalTextBox";
            this.pago_totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.pago_totalTextBox.TabIndex = 19;
            // 
            // forma_de_pagoTextBox
            // 
            this.forma_de_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotel_baseBindingSource, "forma de pago", true));
            this.forma_de_pagoTextBox.Location = new System.Drawing.Point(134, 263);
            this.forma_de_pagoTextBox.Name = "forma_de_pagoTextBox";
            this.forma_de_pagoTextBox.Size = new System.Drawing.Size(200, 20);
            this.forma_de_pagoTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "BORRAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(501, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "GUARDAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(615, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "CANCELAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(615, 245);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "SALIR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(395, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(651, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 46);
            this.button7.TabIndex = 11;
            this.button7.Text = "examinar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 619);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hotel_baseDataGridView);
            this.Name = "Form2";
            this.Text = "examinar";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_hotel_archiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_baseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_baseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private base_hotel_archiDataSet base_hotel_archiDataSet;
        private System.Windows.Forms.BindingSource hotel_baseBindingSource;
        private base_hotel_archiDataSetTableAdapters.hotel_baseTableAdapter hotel_baseTableAdapter;
        private base_hotel_archiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hotel_baseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_llegadaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_de_desalojoDateTimePicker;
        private System.Windows.Forms.TextBox clase_de_habitacionTextBox;
        private System.Windows.Forms.TextBox numero_de_habitacionTextBox;
        private System.Windows.Forms.TextBox pago_totalTextBox;
        private System.Windows.Forms.TextBox forma_de_pagoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}