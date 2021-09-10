using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEAN_PIERRE
{
    public partial class Form2 : Form
    {
        private string ruta = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void hotel_baseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotel_baseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_hotel_archiDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_hotel_archiDataSet.hotel_base' Puede moverla o quitarla según sea necesario.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotel_baseBindingSource.AddNew();
            panel1.Enabled = true;
            button5.Visible = true;
            button4.Enabled = true;
            nombreTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            button5.Visible = true;
            button4.Enabled = true;
            nombreTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea borrar este registro", "borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.base_hotel_archiDataSet.hotel_base.Rows.RemoveAt(this.hotel_baseDataGridView.CurrentCell.RowIndex);
                this.hotel_baseTableAdapter.Update(base_hotel_archiDataSet.hotel_base);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hotel_baseBindingSource.EndEdit();
            this.hotel_baseTableAdapter.Update(base_hotel_archiDataSet.hotel_base);
            this.hotel_baseDataGridView.Refresh();
            panel1.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.hotel_baseBindingSource.CancelEdit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                label1.Text = ruta;
            }
            Image miimagen = Image.FromFile(ruta);
            pictureBox1.Image = miimagen;
        }
    }
}
