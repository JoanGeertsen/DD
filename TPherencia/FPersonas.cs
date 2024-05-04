using DD_TP3_ej1;
using System.Windows.Forms;

namespace TPherencia
{
    public partial class FPersonas : Form
    {
        #region Atributos
        private Persona[] aPersonas;
        private Estudiante[] aEstudiantes;
        private int max;
        private int cantPersonas;
        private int cantEstudiantes;
        #endregion

        public FPersonas()
        {
            InitializeComponent();
            max = 50;
            aPersonas = new Persona[max];
            cantPersonas = 0;
            aEstudiantes = new Estudiante[max];
            cantEstudiantes = 0;
        }

        #region Funcionalidades
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstudiante.Checked)
                pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }

        private bool existePersona(Persona p)
        {
            int i = 0;
            while (i < cantPersonas && !aPersonas[i].esIgual(p))
                i++;
            return i < cantPersonas;
        }

        private bool existeEstudiante(Estudiante e)
        {
            int i = 0;
            while (i < cantEstudiantes && !aEstudiantes[i].esIgual(e))
                i++;
            return i < cantEstudiantes;
        }

        private bool deseaActualizar(Persona p)
        {
            return MessageBox.Show($"Se encontr�:\n\n{p.mostrar()}\n\n�Desea actualizarlo?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private void actualizarOcrearPersona()
        {
            Persona p = new Persona(mtDni.Text);
            if (existePersona(p)) //Actualizo la persona
            {
                int i = 0;
                while (i < cantPersonas && !aPersonas[i].esIgual(p)) i++;
                if (deseaActualizar(aPersonas[i]))
                {
                    aPersonas[i].Nombre = tNombre.Text; aPersonas[i].Apellido = tApellido.Text;
                    aPersonas[i].FechaNacimiento = dtFechaNacimiento.Text;
                    MessageBox.Show(aPersonas[i].mostrar(), "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else//Creo persona 
            {
                aPersonas[cantPersonas++] = new Persona(mtDni.Text, tNombre.Text, tApellido.Text, dtFechaNacimiento.Text);
                MessageBox.Show(aPersonas[cantPersonas - 1].mostrar(), "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void actualizarOcrearEstudiante()
        {
            Estudiante e = new Estudiante(mtDni.Text, mtLegajo.Text);
            if (existeEstudiante(e)) //Actualizo el estudiante
            {
                int i = 0;
                while (i < cantEstudiantes && !aEstudiantes[i].esIgual(e)) i++;
                if (deseaActualizar(aEstudiantes[i]))
                {
                    aEstudiantes[i].Nombre = tNombre.Text; aEstudiantes[i].Apellido = tApellido.Text;
                    aEstudiantes[i].FechaNacimiento = dtFechaNacimiento.Text;
                    aEstudiantes[i].Legajo = mtLegajo.Text; aEstudiantes[i].Carrera = tCarrera.Text;
                    aEstudiantes[i].FechaNacimiento = dtFechaIngreso.Text;
                    MessageBox.Show(aEstudiantes[i].mostrar(), "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else//Creo Estudiante 
            {
                aEstudiantes[cantEstudiantes++] = new Estudiante(mtDni.Text, tNombre.Text, tApellido.Text, dtFechaNacimiento.Text, mtLegajo.Text, tCarrera.Text, dtFechaIngreso.Text);
                MessageBox.Show(aEstudiantes[cantEstudiantes - 1].mostrar(), "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void actualizarListBoxConArreglo(Persona[] a, int tope)
        {
            int i = 0;
            while (i < tope)
                lbPersonas.Items.Add(a[i++].mostrar());
        }

        private void actualizarListBox()
        {
            lbPersonas.Items.Clear();
            if (cbFiltros.SelectedIndex == -1 || cbFiltros.SelectedIndex == 0) //Todos
            {
                actualizarListBoxConArreglo(aEstudiantes, cantEstudiantes);
                actualizarListBoxConArreglo(aPersonas, cantPersonas);
                lCantidad.Text = $"Cantidad: {cantPersonas + cantEstudiantes}";
            }
            else if (cbFiltros.SelectedIndex == 1) //Estudiantes
            {
                actualizarListBoxConArreglo(aEstudiantes, cantEstudiantes);
                lCantidad.Text = $"Cantidad: {cantEstudiantes}";
            }
            else //Personas
            {
                actualizarListBoxConArreglo(aPersonas, cantPersonas);
                lCantidad.Text = $"Cantidad: {cantPersonas}";
            }
        }
        private void limpiarCampos()
        {
            tNombre.Clear();tApellido.Clear();mtDni.Clear(); dtFechaNacimiento.Text = "1/1/2000";
            mtLegajo.Clear(); tCarrera.Clear(); dtFechaIngreso.Text = "1/1/2020";
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (!mtDni.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar un documento VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.SetError(mtDni, "Documento invalido"); mtDni.Focus();
            }

            else if (chEstudiante.Checked && !mtLegajo.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar un legajo VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.SetError(mtLegajo, "Legajo invalido"); mtLegajo.Focus();
            }
            else if (!chEstudiante.Checked) actualizarOcrearPersona();
            else actualizarOcrearEstudiante();

            limpiarCampos();
            actualizarListBox();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBox();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (!mtDni.MaskCompleted)
            {
                errorProvider.Clear();
                MessageBox.Show("Debe ingresar un documento VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.SetError(mtDni, "Documento invalido"); mtDni.Focus();
            }

            else if (chEstudiante.Checked && !mtLegajo.MaskCompleted)
            {
                errorProvider.Clear();
                MessageBox.Show("Debe ingresar un legajo VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.SetError(mtLegajo, "Legajo invalido"); mtLegajo.Focus();
            }
            else if (!chEstudiante.Checked)//Busco una persona
            {
                Persona p = new Persona(mtDni.Text);
                int i = 0;
                while(i < cantPersonas && !aPersonas[i].esIgual(p))                
                    i++;
                if (i < cantPersonas && cantPersonas > 0) MessageBox.Show($"Se encontr�:\n\n{aPersonas[i].mostrar()}","B�squeda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"No se encontraron resultados", "B�squeda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chEstudiante.Checked) //Busco un estudiante
            {
                Estudiante aux = new Estudiante(mtDni.Text, mtLegajo.Text); //Revisar donde esta la e global
                int i = 0;
                while (i < cantEstudiantes && !aEstudiantes[i].esIgual(aux))
                    i++;
                if (i < cantEstudiantes && cantEstudiantes > 0) MessageBox.Show($"Se encontr�:\n\n{aEstudiantes[i].mostrar()}", "B�squeda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"No se encontraron resultados", "B�squeda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region KeyPress
        private void tNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cbFiltros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Validaci�n de campos
        private void tNombre_Leave(object sender, EventArgs e)
        {
            if (tNombre.Text.Length <= 0)
                errorProvider.SetError(tNombre, "Nombre invalido");
            else errorProvider.SetError(tNombre, "");
        }

        private void tApellido_Leave(object sender, EventArgs e)
        {
            if (tApellido.Text.Length <= 0)
                errorProvider.SetError(tApellido, "Apellido invalido");
            else errorProvider.SetError(tApellido, "");
        }

        private void mtDni_Leave(object sender, EventArgs e)
        {
            if (!mtDni.MaskCompleted)
                errorProvider.SetError(mtDni, "Documento invalido");
            else errorProvider.SetError(mtDni, "");
        }

        private void dtFechaNacimiento_Leave(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtFechaNacimiento.Value;
            DateTime fechaHoy = DateTime.Today;

            if (fechaNacimiento >= fechaHoy)
                errorProvider.SetError(dtFechaNacimiento, "Fecha invalida");
            else
                errorProvider.SetError(dtFechaNacimiento, "");
        }

        private void mtLegajo_Leave(object sender, EventArgs e)
        {
            if (!mtLegajo.MaskCompleted)
                errorProvider.SetError(mtLegajo, "Legajo invalido");
            else errorProvider.SetError(mtLegajo, "");
        }

        private void tCarrera_Leave(object sender, EventArgs e)
        {
            if (tCarrera.Text.Length <= 0)
                errorProvider.SetError(tCarrera, "Carrera invalida");
            else errorProvider.SetError(tCarrera, "");
        }

        private void dtFechaIngreso_Leave(object sender, EventArgs e)
        {
            //Por el momento solo chequeamos que no sea una fecha futura
            DateTime fechaDeIngreso = dtFechaIngreso.Value;
            DateTime fechaHoy = DateTime.Today;


            if (fechaDeIngreso > fechaHoy)
                errorProvider.SetError(dtFechaIngreso, "Fecha invalida");
            else
                errorProvider.SetError(dtFechaIngreso, "");
        }
        #endregion
       
    }
}