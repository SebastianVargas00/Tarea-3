using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_P2
{
    public partial class Categoria : Form
    {
        private int n = 0;
        int i = -1;
        int posicion;

        public Categoria()
        {
            InitializeComponent();

        }

        private void Categoria_Load(object sender, EventArgs e)
        {
          

        }

     
        public void Limpiar()
        {
            textcodigo.Clear();
            textestado.Clear();
            textnombre.Clear();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(textcodigo.Text))
                {
                    MessageBox.Show("Error, celda vacia!");
                } else if (string.IsNullOrEmpty(textnombre.Text)) {
                    MessageBox.Show("Error, celda vacia!");
                } else if (string.IsNullOrEmpty(textestado.Text)) {
                    MessageBox.Show("Error, celda vacia!");
                }
                else
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = textcodigo.Text;
                    dataGridView1.Rows[n].Cells[1].Value = textnombre.Text;
                    dataGridView1.Rows[n].Cells[2].Value = textestado.Text;

                    Limpiar();
                } 
        
        }
            
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Categoria"].FormattedValue.ToString();
                textnombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                textestado.Text = dataGridView1.Rows[e.RowIndex].Cells["Estado"].FormattedValue.ToString();


            }

        }

        private void buttonalter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textcodigo.Text))
            {
                MessageBox.Show("Error, seleccione celda!");
            }
            else if (string.IsNullOrEmpty(textnombre.Text))
            {
                MessageBox.Show("Error, seleccione celda!");
            }
            else if (string.IsNullOrEmpty(textestado.Text))
            {
                MessageBox.Show("Error, seleccione celda!");
            }
            else
            {
                string id, nombre, estado;
                id = textcodigo.Text;
                nombre = textnombre.Text;
                estado = textestado.Text;
                dataGridView1[0, posicion].Value = textcodigo.Text;
                dataGridView1[1, posicion].Value = textnombre.Text;
                dataGridView1[2, posicion].Value = textestado.Text;
                Limpiar();
                textcodigo.Focus();

            }

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (n != 1)
                {
                    dataGridView1.Rows.RemoveAt(n);

                }
            }
            catch (Exception) {
                MessageBox.Show("Error, no hay celdas para eliminar! ");
            }

 
        
        }

        private void textcodigo_Validated(object sender, EventArgs e)
        {
    
        }

        private void textcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
           
}

