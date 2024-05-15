namespace TPherencia
{
    partial class FPersonas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pPersona = new Panel();
            chEstudiante = new CheckBox();
            dtFechaNacimiento = new DateTimePicker();
            mtDni = new MaskedTextBox();
            tApellido = new TextBox();
            tNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pLista = new Panel();
            lCantidad = new Label();
            lbPersonas = new ListBox();
            cbFiltros = new ComboBox();
            label5 = new Label();
            pEstudiante = new Panel();
            label8 = new Label();
            dtFechaIngreso = new DateTimePicker();
            tCarrera = new TextBox();
            label7 = new Label();
            mtLegajo = new MaskedTextBox();
            label6 = new Label();
            bBuscar = new Button();
            bGuardar = new Button();
            bCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            pPersona.SuspendLayout();
            pLista.SuspendLayout();
            pEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pPersona
            // 
            pPersona.BackColor = Color.PaleTurquoise;
            pPersona.Controls.Add(chEstudiante);
            pPersona.Controls.Add(dtFechaNacimiento);
            pPersona.Controls.Add(mtDni);
            pPersona.Controls.Add(tApellido);
            pPersona.Controls.Add(tNombre);
            pPersona.Controls.Add(label4);
            pPersona.Controls.Add(label3);
            pPersona.Controls.Add(label2);
            pPersona.Controls.Add(label1);
            pPersona.Location = new Point(17, 20);
            pPersona.Margin = new Padding(4, 5, 4, 5);
            pPersona.Name = "pPersona";
            pPersona.Size = new Size(439, 245);
            pPersona.TabIndex = 0;
            // 
            // chEstudiante
            // 
            chEstudiante.AutoSize = true;
            chEstudiante.Location = new Point(131, 202);
            chEstudiante.Margin = new Padding(4, 5, 4, 5);
            chEstudiante.Name = "chEstudiante";
            chEstudiante.Size = new Size(120, 29);
            chEstudiante.TabIndex = 9;
            chEstudiante.Text = "Estudiante";
            chEstudiante.UseVisualStyleBackColor = true;
            chEstudiante.CheckedChanged += chEstudiante_CheckedChanged;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtFechaNacimiento.Location = new Point(131, 153);
            dtFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(137, 31);
            dtFechaNacimiento.TabIndex = 8;
            dtFechaNacimiento.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtFechaNacimiento.Leave += dtFechaNacimiento_Leave;
            // 
            // mtDni
            // 
            mtDni.Location = new Point(131, 105);
            mtDni.Margin = new Padding(4, 5, 4, 5);
            mtDni.Mask = "00,000,000";
            mtDni.Name = "mtDni";
            mtDni.Size = new Size(280, 31);
            mtDni.TabIndex = 7;
            mtDni.Leave += mtDni_Leave;
            // 
            // tApellido
            // 
            tApellido.Location = new Point(131, 58);
            tApellido.Margin = new Padding(4, 5, 4, 5);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(280, 31);
            tApellido.TabIndex = 6;
            tApellido.KeyPress += tApellido_KeyPress;
            tApellido.Leave += tApellido_Leave;
            // 
            // tNombre
            // 
            tNombre.Location = new Point(131, 10);
            tNombre.Margin = new Padding(4, 5, 4, 5);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(280, 31);
            tNombre.TabIndex = 5;
            tNombre.KeyPress += tNombre_KeyPress;
            tNombre.Leave += tNombre_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nac.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 3;
            label3.Text = "Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // pLista
            // 
            pLista.BackColor = Color.PeachPuff;
            pLista.Controls.Add(lCantidad);
            pLista.Controls.Add(lbPersonas);
            pLista.Controls.Add(cbFiltros);
            pLista.Controls.Add(label5);
            pLista.Location = new Point(464, 20);
            pLista.Margin = new Padding(4, 5, 4, 5);
            pLista.Name = "pLista";
            pLista.Size = new Size(277, 425);
            pLista.TabIndex = 10;
            // 
            // lCantidad
            // 
            lCantidad.AutoSize = true;
            lCantidad.Location = new Point(17, 385);
            lCantidad.Margin = new Padding(4, 0, 4, 0);
            lCantidad.Name = "lCantidad";
            lCantidad.Size = new Size(87, 25);
            lCantidad.TabIndex = 13;
            lCantidad.Text = "Cantidad:";
            // 
            // lbPersonas
            // 
            lbPersonas.FormattingEnabled = true;
            lbPersonas.HorizontalExtent = 700;
            lbPersonas.HorizontalScrollbar = true;
            lbPersonas.ItemHeight = 25;
            lbPersonas.Location = new Point(17, 88);
            lbPersonas.Margin = new Padding(4, 5, 4, 5);
            lbPersonas.Name = "lbPersonas";
            lbPersonas.Size = new Size(241, 279);
            lbPersonas.TabIndex = 12;
            // 
            // cbFiltros
            // 
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "TODOS", "Estudiantes", "NO Estudiantes" });
            cbFiltros.Location = new Point(17, 40);
            cbFiltros.Margin = new Padding(4, 5, 4, 5);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(241, 33);
            cbFiltros.TabIndex = 11;
            cbFiltros.Text = "TODOS";
            cbFiltros.SelectedIndexChanged += cbFiltros_SelectedIndexChanged;
            cbFiltros.KeyPress += cbFiltros_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 10;
            label5.Text = "Filtro:";
            // 
            // pEstudiante
            // 
            pEstudiante.BackColor = Color.PaleGreen;
            pEstudiante.Controls.Add(label8);
            pEstudiante.Controls.Add(dtFechaIngreso);
            pEstudiante.Controls.Add(tCarrera);
            pEstudiante.Controls.Add(label7);
            pEstudiante.Controls.Add(mtLegajo);
            pEstudiante.Controls.Add(label6);
            pEstudiante.Location = new Point(17, 275);
            pEstudiante.Margin = new Padding(4, 5, 4, 5);
            pEstudiante.Name = "pEstudiante";
            pEstudiante.Size = new Size(439, 170);
            pEstudiante.TabIndex = 13;
            pEstudiante.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 125);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 12;
            label8.Text = "Fecha Ingreso:";
            // 
            // dtFechaIngreso
            // 
            dtFechaIngreso.Format = DateTimePickerFormat.Short;
            dtFechaIngreso.Location = new Point(146, 117);
            dtFechaIngreso.Margin = new Padding(4, 5, 4, 5);
            dtFechaIngreso.Name = "dtFechaIngreso";
            dtFechaIngreso.Size = new Size(137, 31);
            dtFechaIngreso.TabIndex = 10;
            dtFechaIngreso.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtFechaIngreso.Leave += dtFechaIngreso_Leave;
            // 
            // tCarrera
            // 
            tCarrera.Location = new Point(140, 68);
            tCarrera.Margin = new Padding(4, 5, 4, 5);
            tCarrera.Name = "tCarrera";
            tCarrera.Size = new Size(257, 31);
            tCarrera.TabIndex = 10;
            tCarrera.KeyPress += tCarrera_KeyPress;
            tCarrera.Leave += tCarrera_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 82);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 11;
            label7.Text = "Carrera:";
            // 
            // mtLegajo
            // 
            mtLegajo.Location = new Point(140, 13);
            mtLegajo.Margin = new Padding(4, 5, 4, 5);
            mtLegajo.Mask = "000000";
            mtLegajo.Name = "mtLegajo";
            mtLegajo.Size = new Size(114, 31);
            mtLegajo.TabIndex = 10;
            mtLegajo.Leave += mtLegajo_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 10;
            label6.Text = "Legajo:";
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(17, 455);
            bBuscar.Margin = new Padding(4, 5, 4, 5);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(107, 38);
            bBuscar.TabIndex = 14;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
            bBuscar.Click += bBuscar_Click;
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(309, 455);
            bGuardar.Margin = new Padding(4, 5, 4, 5);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(107, 38);
            bGuardar.TabIndex = 15;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bCancelar
            // 
            bCancelar.Location = new Point(634, 455);
            bCancelar.Margin = new Padding(4, 5, 4, 5);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(107, 38);
            bCancelar.TabIndex = 16;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FPersonas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 507);
            Controls.Add(bCancelar);
            Controls.Add(bGuardar);
            Controls.Add(bBuscar);
            Controls.Add(pEstudiante);
            Controls.Add(pLista);
            Controls.Add(pPersona);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FPersonas";
            Text = "Personas";
            pPersona.ResumeLayout(false);
            pPersona.PerformLayout();
            pLista.ResumeLayout(false);
            pLista.PerformLayout();
            pEstudiante.ResumeLayout(false);
            pEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pPersona;
        private TextBox tNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtDni;
        private TextBox tApellido;
        private DateTimePicker dtFechaNacimiento;
        private CheckBox chEstudiante;
        private Panel pLista;
        private ListBox lbPersonas;
        private ComboBox cbFiltros;
        private Label label5;
        private Panel pEstudiante;
        private Label label6;
        private Label lCantidad;
        private Label label8;
        private DateTimePicker dtFechaIngreso;
        private TextBox tCarrera;
        private Label label7;
        private MaskedTextBox mtLegajo;
        private Button bBuscar;
        private Button bGuardar;
        private Button bCancelar;
        private ErrorProvider errorProvider;
    }
}