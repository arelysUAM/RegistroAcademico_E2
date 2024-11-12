namespace RegistroAcademico_Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpInformacionEstudiante = new System.Windows.Forms.GroupBox();
            this.txtEstudianteID = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstudianteID = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtPromedioGeneral = new System.Windows.Forms.TextBox();
            this.lblMateriasAprobadas = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.grpDatodAcademicos = new System.Windows.Forms.GroupBox();
            this.txtMateriasA = new System.Windows.Forms.TextBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblEncabezado2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriasAprobadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInformacionEstudiante.SuspendLayout();
            this.grpDatodAcademicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacionEstudiante
            // 
            this.grpInformacionEstudiante.Controls.Add(this.txtEstudianteID);
            this.grpInformacionEstudiante.Controls.Add(this.txtApellido);
            this.grpInformacionEstudiante.Controls.Add(this.txtNombre);
            this.grpInformacionEstudiante.Controls.Add(this.lblEstudianteID);
            this.grpInformacionEstudiante.Controls.Add(this.lblApellido);
            this.grpInformacionEstudiante.Controls.Add(this.lblNombre);
            this.grpInformacionEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpInformacionEstudiante.Location = new System.Drawing.Point(13, 76);
            this.grpInformacionEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.grpInformacionEstudiante.Name = "grpInformacionEstudiante";
            this.grpInformacionEstudiante.Padding = new System.Windows.Forms.Padding(4);
            this.grpInformacionEstudiante.Size = new System.Drawing.Size(345, 143);
            this.grpInformacionEstudiante.TabIndex = 0;
            this.grpInformacionEstudiante.TabStop = false;
            // 
            // txtEstudianteID
            // 
            this.txtEstudianteID.Location = new System.Drawing.Point(194, 75);
            this.txtEstudianteID.Name = "txtEstudianteID";
            this.txtEstudianteID.Size = new System.Drawing.Size(98, 26);
            this.txtEstudianteID.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(88, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(204, 26);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // lblEstudianteID
            // 
            this.lblEstudianteID.AutoSize = true;
            this.lblEstudianteID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstudianteID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEstudianteID.Location = new System.Drawing.Point(8, 81);
            this.lblEstudianteID.Name = "lblEstudianteID";
            this.lblEstudianteID.Size = new System.Drawing.Size(182, 22);
            this.lblEstudianteID.TabIndex = 2;
            this.lblEstudianteID.Text = "Número de Estudiante:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApellido.Location = new System.Drawing.Point(8, 52);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 22);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNombre.Location = new System.Drawing.Point(8, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Derecho",
            "Psicología",
            "Medicina",
            "Odontología",
            "Arquitectura",
            "Ingeniería Civil",
            "Ingeniería Industrial",
            "Ingeniería en Sistemas",
            "Marketing"});
            this.cmbCarrera.Location = new System.Drawing.Point(93, 15);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(204, 28);
            this.cmbCarrera.TabIndex = 10;
            // 
            // txtPromedioGeneral
            // 
            this.txtPromedioGeneral.Location = new System.Drawing.Point(171, 54);
            this.txtPromedioGeneral.Name = "txtPromedioGeneral";
            this.txtPromedioGeneral.Size = new System.Drawing.Size(98, 26);
            this.txtPromedioGeneral.TabIndex = 9;
            // 
            // lblMateriasAprobadas
            // 
            this.lblMateriasAprobadas.AutoSize = true;
            this.lblMateriasAprobadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMateriasAprobadas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMateriasAprobadas.Location = new System.Drawing.Point(14, 92);
            this.lblMateriasAprobadas.Name = "lblMateriasAprobadas";
            this.lblMateriasAprobadas.Size = new System.Drawing.Size(166, 22);
            this.lblMateriasAprobadas.TabIndex = 5;
            this.lblMateriasAprobadas.Text = "Materias Aprobadas:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPromedio.Location = new System.Drawing.Point(14, 54);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(151, 22);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio General:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarrera.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCarrera.Location = new System.Drawing.Point(14, 21);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(73, 22);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Carrera:";
            // 
            // grpDatodAcademicos
            // 
            this.grpDatodAcademicos.Controls.Add(this.txtMateriasA);
            this.grpDatodAcademicos.Controls.Add(this.cmbCarrera);
            this.grpDatodAcademicos.Controls.Add(this.lblCarrera);
            this.grpDatodAcademicos.Controls.Add(this.txtPromedioGeneral);
            this.grpDatodAcademicos.Controls.Add(this.lblPromedio);
            this.grpDatodAcademicos.Controls.Add(this.lblMateriasAprobadas);
            this.grpDatodAcademicos.Location = new System.Drawing.Point(379, 76);
            this.grpDatodAcademicos.Margin = new System.Windows.Forms.Padding(4);
            this.grpDatodAcademicos.Name = "grpDatodAcademicos";
            this.grpDatodAcademicos.Padding = new System.Windows.Forms.Padding(4);
            this.grpDatodAcademicos.Size = new System.Drawing.Size(331, 143);
            this.grpDatodAcademicos.TabIndex = 1;
            this.grpDatodAcademicos.TabStop = false;
            // 
            // txtMateriasA
            // 
            this.txtMateriasA.Location = new System.Drawing.Point(186, 89);
            this.txtMateriasA.Name = "txtMateriasA";
            this.txtMateriasA.Size = new System.Drawing.Size(98, 26);
            this.txtMateriasA.TabIndex = 11;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEncabezado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEncabezado.Location = new System.Drawing.Point(13, 59);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(209, 22);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Información del Estudiante";
            // 
            // lblEncabezado2
            // 
            this.lblEncabezado2.AutoSize = true;
            this.lblEncabezado2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEncabezado2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEncabezado2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEncabezado2.Location = new System.Drawing.Point(379, 59);
            this.lblEncabezado2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado2.Name = "lblEncabezado2";
            this.lblEncabezado2.Size = new System.Drawing.Size(153, 22);
            this.lblEncabezado2.TabIndex = 10;
            this.lblEncabezado2.Text = "Datos Académicos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Location = new System.Drawing.Point(603, 242);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 29);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(487, 242);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 29);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Location = new System.Drawing.Point(379, 242);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 29);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.NumEstudiante,
            this.Carrera,
            this.PromedioGeneral,
            this.MateriasAprobadas});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // NumEstudiante
            // 
            this.NumEstudiante.HeaderText = "N° Estudiante";
            this.NumEstudiante.MinimumWidth = 6;
            this.NumEstudiante.Name = "NumEstudiante";
            this.NumEstudiante.ReadOnly = true;
            this.NumEstudiante.Width = 145;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 200;
            // 
            // PromedioGeneral
            // 
            this.PromedioGeneral.HeaderText = "Promedio";
            this.PromedioGeneral.MinimumWidth = 6;
            this.PromedioGeneral.Name = "PromedioGeneral";
            this.PromedioGeneral.ReadOnly = true;
            this.PromedioGeneral.Width = 125;
            // 
            // MateriasAprobadas
            // 
            this.MateriasAprobadas.HeaderText = "Materias Aprobadas";
            this.MateriasAprobadas.MinimumWidth = 6;
            this.MateriasAprobadas.Name = "MateriasAprobadas";
            this.MateriasAprobadas.ReadOnly = true;
            this.MateriasAprobadas.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEditar,
            this.toolStripMenuEliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // toolStripMenuEditar
            // 
            this.toolStripMenuEditar.Name = "toolStripMenuEditar";
            this.toolStripMenuEditar.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuEditar.Text = "Editar";
            this.toolStripMenuEditar.Click += new System.EventHandler(this.toolStripMenuEditar_Click);
            // 
            // toolStripMenuEliminar
            // 
            this.toolStripMenuEliminar.Name = "toolStripMenuEliminar";
            this.toolStripMenuEliminar.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuEliminar.Text = "Eliminar";
            this.toolStripMenuEliminar.Click += new System.EventHandler(this.toolStripMenuEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.ToolTipText = "Abrir nuevo archivo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Salir del Sistema";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.estudianteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.ToolTipText = "Guardar registro de estudiante";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.ToolTipText = "Guardar regisrtro de estudiante";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.ToolTipText = "Eliminar registro de estudiante";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(792, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblEncabezado2);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.grpDatodAcademicos);
            this.Controls.Add(this.grpInformacionEstudiante);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Información Académica de Estudiantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInformacionEstudiante.ResumeLayout(false);
            this.grpInformacionEstudiante.PerformLayout();
            this.grpDatodAcademicos.ResumeLayout(false);
            this.grpDatodAcademicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacionEstudiante;
        private System.Windows.Forms.GroupBox grpDatodAcademicos;
        private System.Windows.Forms.Label lblEstudianteID;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateriasAprobadas;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtEstudianteID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPromedioGeneral;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblEncabezado2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMateriasA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriasAprobadas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEliminar;
    }
}

