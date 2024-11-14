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
            // Verificar si todos los TextBox y el ComboBox están completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEstudianteID.Text) ||
                string.IsNullOrWhiteSpace(txtPromedioGeneral.Text) ||
                string.IsNullOrWhiteSpace(txtMateriasA.Text) ||
                string.IsNullOrWhiteSpace(cmbCarrera.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // No continuar si hay campos vacíos
            }

            // Agregar una nueva fila al DataGridView
            dataGridView1.Rows.Add(txtNombre.Text, txtApellido.Text, txtEstudianteID.Text, cmbCarrera.Text, txtPromedioGeneral.Text, txtMateriasA.Text);

            // Limpiar los cuadros de texto y deseleccionar el combo
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEstudianteID.Text = "";
            txtPromedioGeneral.Text = "";
            txtMateriasA.Text = "";
            cmbCarrera.SelectedIndex = -1;

            // Actualizar el archivo de texto con los datos actuales
            GrabarDatos();

            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirmar si se desea eliminar el registro
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?","Confirmar Eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    int selectedIndex = dataGridView1.SelectedRows[0].Index; // Obtener el índice de la fila seleccionada
                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    // Llamar a la función para guardar los cambios (GrabarBorrado)
                    GrabarBorrado();

                    MessageBox.Show("Datos del estudiante seleccionado eliminados","Eliminar Registro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.","Sin selección", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirmar si se desea eliminar el registro
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?","Confirmar Eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    GrabarBorrado();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Datos del estudiante seleccionado eliminados","Eliminar Registro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mostrar mensaje si no se selecciona ninguna fila
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.","Sin selección", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEstudianteID.Text = "";
            txtPromedioGeneral.Text = "";
            txtMateriasA.Text = "";
            cmbCarrera.SelectedIndex = -1;


            // Limpiar cualquier selección del DataGridView, si aplica
            dataGridView1.ClearSelection();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si todos los TextBox y el ComboBox están completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEstudianteID.Text) ||
                string.IsNullOrWhiteSpace(txtPromedioGeneral.Text) ||
                string.IsNullOrWhiteSpace(txtMateriasA.Text) ||
                string.IsNullOrWhiteSpace(cmbCarrera.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.","Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // No continuar si hay campos vacíos
            }

            // Agregar una nueva fila al DataGridView
            dataGridView1.Rows.Add(txtNombre.Text, txtApellido.Text, txtEstudianteID.Text, cmbCarrera.Text,txtPromedioGeneral.Text, txtMateriasA.Text);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEstudianteID.Text = "";
            txtPromedioGeneral.Text = "";
            txtMateriasA.Text = "";
            cmbCarrera.SelectedIndex = -1;

            GrabarDatos();

            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirmar si se desea eliminar el registro
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    int selectedIndex = dataGridView1.SelectedRows[0].Index; // Obtener el índice de la fila seleccionada
                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    // Llamar a la función para guardar los cambios (GrabarBorrado)
                    GrabarBorrado();

                    MessageBox.Show("Datos del estudiante seleccionado eliminados", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Solo se permiten letras en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Solo se permiten letras en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEstudianteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Solo se permiten números enteros en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPromedioGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;  
            }

            // Si se presiona el punto decimal
            if (e.KeyChar == '.')
            {
                // Si ya hay un punto en el texto, no permitir otro
                if (txtPromedioGeneral.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            // Validar que no se ingresen más de 3 cifras después del punto
            if (txtPromedioGeneral.Text.Contains(".") && e.KeyChar != (char)8) // Excluir la tecla de retroceso
            {
                // Contar la cantidad de cifras después del punto
                int decimalCount = txtPromedioGeneral.Text.Substring(txtPromedioGeneral.Text.IndexOf('.') + 1).Length;

                if (decimalCount >= 3)
                {
                    e.Handled = true;  
                    MessageBox.Show("Solo se permiten hasta 3 cifras después del punto decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMateriasA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Solo se permiten números enteros en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Verificar si todos los TextBox y el ComboBox están completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEstudianteID.Text) ||
                string.IsNullOrWhiteSpace(txtPromedioGeneral.Text) ||
                string.IsNullOrWhiteSpace(txtMateriasA.Text) ||
                string.IsNullOrWhiteSpace(cmbCarrera.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // No continuar si hay campos vacíos
            }

            // Agregar una nueva fila al DataGridView
            dataGridView1.Rows.Add(txtNombre.Text, txtApellido.Text, txtEstudianteID.Text, cmbCarrera.Text, txtPromedioGeneral.Text, txtMateriasA.Text);

            // Limpiar los cuadros de texto y deseleccionar el combo
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEstudianteID.Text = "";
            txtPromedioGeneral.Text = "";
            txtMateriasA.Text = "";
            cmbCarrera.SelectedIndex = -1;

            // Actualizar el archivo de texto con los datos actuales
            GrabarDatos();

            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlsbtnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirmar si se desea eliminar el registro
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?","Confirmar Eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Obtener el índice de la fila seleccionada
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    // Eliminar la fila seleccionada
                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    // Llamar a la función para guardar los cambios (GrabarBorrado)
                    GrabarBorrado();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Datos del estudiante seleccionado eliminados","Eliminar Registro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mostrar mensaje si no se selecciona ninguna fila
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.","Sin selección", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void tlsbtnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si se está editando un registro existente
            if (btnActualizar.Tag != null) // Si hay un Tag asignado, sabemos que estamos editando un registro
            {
                int rowIndex = (int)btnActualizar.Tag;  // Obtener el índice de la fila a actualizar

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

                // Restablecer el Tag
                btnActualizar.Tag = null;

                // Deshabilitar el botón "Actualizar" y habilitar el botón "Guardar" nuevamente
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;

                // Guardar los cambios realizados
                GrabarDatos();

                // Mostrar mensaje de éxito
                MessageBox.Show("Registro actualizado exitosamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje con la descripción del sistema
            MessageBox.Show("Sistema de gestión de estudiantes\n\nPermite registrar, actualizar y eliminar información de estudiantes en un entorno académico.", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
