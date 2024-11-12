using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAcademico_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("registro.txt"))
            {
                StreamWriter archivo = new StreamWriter("registro.txt");
                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("registro.txt");
                while (!archivo.EndOfStream)
                {
                    string nombre = archivo.ReadLine();
                    string apellido = archivo.ReadLine();
                    string estudianteID = archivo.ReadLine();
                    string carrera = archivo.ReadLine();
                    string promedioGeneral = archivo.ReadLine();
                    string materiasAprobadas = archivo.ReadLine();
                    dataGridView1.Rows.Add(nombre, apellido, estudianteID, carrera, promedioGeneral, materiasAprobadas);
                }
                archivo.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Agregar una nueva fila al DataGridView
            dataGridView1.Rows.Add(txtNombre.Text, txtApellido.Text, txtEstudianteID.Text, cmbCarrera.Text, txtPromedioGeneral.Text, txtMateriasA.Text);

            // Limpiar los cuadros de texto
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEstudianteID.Text = "";
            cmbCarrera.Text = "";
            txtPromedioGeneral.Text = "";
            txtMateriasA.Text = "";

            // Actualizar el archivo de texto con los datos actuales
            GrabarDatos();
        }

        private void GrabarDatos()
        {
            // Sobrescribir el archivo de texto con los datos actuales del DataGridView
            StreamWriter archivo = new StreamWriter("registro.txt", false); // false para sobrescribir el archivo
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                archivo.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[2].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[3].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[4].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            archivo.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (txtNombre.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    dataGridView1.Rows.RemoveAt(i);
                    GrabarBorrado();
                    MessageBox.Show("Datos del estudiante seleccionado eliminados", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GrabarBorrado()
        {
            StreamWriter archivo = new StreamWriter("registro.txt"); //   Se borra el archivo y se actualiza con los datos que quedan en el GridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                archivo.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[2].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[3].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[4].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            archivo.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (btnActualizar.Tag != null) // Si hay un Tag asignado, sabemos que estamos editando un registro existente
            {
                int rowIndex = (int)btnActualizar.Tag;

                // Actualizar los valores de la fila seleccionada en el DataGridView
                dataGridView1.Rows[rowIndex].Cells[0].Value = txtNombre.Text;
                dataGridView1.Rows[rowIndex].Cells[1].Value = txtApellido.Text;
                dataGridView1.Rows[rowIndex].Cells[2].Value = txtEstudianteID.Text;
                dataGridView1.Rows[rowIndex].Cells[3].Value = cmbCarrera.Text;
                dataGridView1.Rows[rowIndex].Cells[4].Value = txtPromedioGeneral.Text;
                dataGridView1.Rows[rowIndex].Cells[5].Value = txtMateriasA.Text;

                // Limpiar los cuadros de texto
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEstudianteID.Text = "";
                cmbCarrera.Text = "";
                txtPromedioGeneral.Text = "";
                txtMateriasA.Text = "";

                btnActualizar.Tag = null;

                // Deshabilitar el botón "Actualizar" y habilitar el botón "Guardar" nuevamente
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;

                GrabarDatos();

                MessageBox.Show("Registro actualizado exitosamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(rowIndex);

                GrabarBorrado();

                MessageBox.Show("Estudiante eliminado con éxito", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             //no hace nada
            }
        }

        private void toolStripMenuEditar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Cargar los valores de la fila seleccionada en los controles de entrada
                txtNombre.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                txtApellido.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                txtEstudianteID.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                cmbCarrera.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                txtPromedioGeneral.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                txtMateriasA.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();

                btnActualizar.Tag = rowIndex;

                // Habilitar el botón "Actualizar" y deshabilitar el botón "Guardar"
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuevo Archivo", "Archivo", MessageBoxButtons.OK);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
