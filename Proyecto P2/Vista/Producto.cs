using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_P2
{
    public partial class Producto : Form
    {
        int n= 0;
        int i = -1;
        int posicion;
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar() {
            textcode.Clear();
            textnombre.Clear();
            textcodigo.Clear();
            textstock.Clear();
            textfecha.Clear();
            textdes.Clear();
            textid.Clear();
            textestado.Clear();
        }

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textcode.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textnombre.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textestado.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textcodigo.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textstock.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textdes.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textid.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else if (string.IsNullOrEmpty(textfecha.Text))
            {
                MessageBox.Show("Error, celda vacia!");
            }
            else
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = textcode.Text;
                dataGridView1.Rows[n].Cells[1].Value = textnombre.Text;
                dataGridView1.Rows[n].Cells[2].Value = textestado.Text;
                dataGridView1.Rows[n].Cells[3].Value = textcodigo.Text;
                dataGridView1.Rows[n].Cells[4].Value = textstock.Text;
                dataGridView1.Rows[n].Cells[5].Value = textdes.Text;
                dataGridView1.Rows[n].Cells[6].Value = textid.Text;
                dataGridView1.Rows[n].Cells[7].Value = textfecha.Text;

                Limpiar();
            }
                    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textcode.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Producto"].FormattedValue.ToString();
                textnombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                textcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                textdes.Text = dataGridView1.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                textestado.Text = dataGridView1.Rows[e.RowIndex].Cells["Estado"].FormattedValue.ToString();
                textstock.Text = dataGridView1.Rows[e.RowIndex].Cells["Stock"].FormattedValue.ToString();
                textid.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Categoria"].FormattedValue.ToString();
                textfecha.Text = dataGridView1.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].FormattedValue.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textcode.Text))
            {
                MessageBox.Show("Error, seleccionar celda! ");
            }
            else if (string.IsNullOrEmpty(textnombre.Text))
            {
                MessageBox.Show("Error, seleccionar celda!");
            }
            else if (string.IsNullOrEmpty(textestado.Text))
            {
                MessageBox.Show("Error, seleccionar celda!");
            }
            else if (string.IsNullOrEmpty(textcodigo.Text))
            {
                MessageBox.Show("Error, seleccionar celda!");
            }
            else if (string.IsNullOrEmpty(textstock.Text))
            {
                MessageBox.Show("Error, seleccionar celda!");
            }
            else if (string.IsNullOrEmpty(textdes.Text))
            {
                MessageBox.Show("Error, seleccionar celda! ");
            }
            else if (string.IsNullOrEmpty(textid.Text))
            {
                MessageBox.Show("Error, seleccionar celda!");
            }
            else if (string.IsNullOrEmpty(textfecha.Text))
            {
                MessageBox.Show("Error, seleccionar celda!");
            }
            else
            {
                string id, nombre, codigo, stock, fecha, descripcion, categoria, estado;
                id = textcode.Text;
                nombre = textnombre.Text;
                codigo = textcodigo.Text;
                stock = textstock.Text;
                fecha = textfecha.Text;
                descripcion = textdes.Text;
                categoria = textid.Text;
                estado = textestado.Text;

                dataGridView1[0, posicion].Value = textcode.Text;
                dataGridView1[1, posicion].Value = textnombre.Text;
                dataGridView1[2, posicion].Value = textcodigo.Text;
                dataGridView1[3, posicion].Value = textstock.Text;
                dataGridView1[4, posicion].Value = textfecha.Text;
                dataGridView1[5, posicion].Value = textdes.Text;
                dataGridView1[6, posicion].Value = textid.Text;
                dataGridView1[7, posicion].Value = textestado.Text;
                Limpiar();
                textcode.Focus();



            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (n != 1)
                {
                    dataGridView1.Rows.RemoveAt(n);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no hay celdas para eliminar! ");
            }

            Limpiar();
        }

 
        private void textstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
