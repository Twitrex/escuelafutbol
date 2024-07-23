using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscuelaFutbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CargarAlumnosdgv()
        {
            try
            {
                List<Alumnos> alumnos = AlumnoDAL.ListarAlumnos();
                dataGridView1.DataSource = alumnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los alumnos: " + ex.Message);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Alumnos alumno = row.DataBoundItem as Alumnos;
                if (alumno != null)
                {
                    txtAlumnoID.Text = alumno.AlumnoID.ToString();
                    txtNombres.Text = alumno.Nombre;
                    txtApellidos.Text = alumno.Apellido;
                    txtDNI.Text = alumno.DNI;
                    dtpFechaNaci.Value = alumno.FechaNacimiento;
                    txtCategoria.Text = alumno.CategoriaID?.ToString() ?? string.Empty;
                    txtPprincipal.Text = alumno.PuestoPrincipalID?.ToString() ?? string.Empty;
                    txtPespecifico.Text = alumno.PuestoEspecificoID?.ToString() ?? string.Empty;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Validar datos antes de crear el objeto Alumno
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPprincipal.Text) ||
                string.IsNullOrWhiteSpace(txtPespecifico.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!DateTime.TryParse(dtpFechaNaci.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("Fecha de nacimiento no válida.");
                return;
            }

            if (!int.TryParse(txtCategoria.Text, out int categoriaID) ||
                !int.TryParse(txtPprincipal.Text, out int puestoPrincipalID) ||
                !int.TryParse(txtPespecifico.Text, out int puestoEspecificoID))
            {
                MessageBox.Show("Categoria, Puesto Principal y Puesto Especifico deben ser números enteros.");
                return;
            }

            // Crear el objeto Alumno después de validar los datos
            Alumnos alumno = new Alumnos
            {
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                DNI = txtDNI.Text,
                FechaNacimiento = fechaNacimiento,
                CategoriaID = categoriaID,
                PuestoPrincipalID = puestoPrincipalID,
                PuestoEspecificoID = puestoEspecificoID
            };

            // Llamar al método AgregarAlumno y manejar el resultado
            try
            {
                int result = AlumnoDAL.AgregarAlumno(alumno);
                if (result > 0)
                {
                    MessageBox.Show("Éxito al guardar");
                    CargarAlumnos();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            try
            {
                List<Alumnos> alumnos = AlumnoDAL.ListarAlumnos();
                dataGridView1.DataSource = alumnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los alumnos: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Validar datos antes de crear el objeto Alumno
                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtDNI.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtPprincipal.Text) ||
                    string.IsNullOrWhiteSpace(txtPespecifico.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                if (!DateTime.TryParse(dtpFechaNaci.Text, out DateTime fechaNacimiento))
                {
                    MessageBox.Show("Fecha de nacimiento no válida.");
                    return;
                }

                if (!int.TryParse(txtCategoria.Text, out int categoriaID) ||
                    !int.TryParse(txtPprincipal.Text, out int puestoPrincipalID) ||
                    !int.TryParse(txtPespecifico.Text, out int puestoEspecificoID))
                {
                    MessageBox.Show("Categoria, Puesto Principal y Puesto Especifico deben ser números enteros.");
                    return;
                }

                // Obtener el AlumnoID desde el campo oculto
                if (!int.TryParse(txtAlumnoID.Text, out int alumnoID))
                {
                    MessageBox.Show("Error al obtener el ID del alumno.");
                    return;
                }

                // Crear el objeto Alumno después de validar los datos
                Alumnos alumno = new Alumnos
                {
                    AlumnoID = alumnoID,
                    Nombre = txtNombres.Text,
                    Apellido = txtApellidos.Text,
                    DNI = txtDNI.Text,
                    FechaNacimiento = fechaNacimiento,
                    CategoriaID = categoriaID,
                    PuestoPrincipalID = puestoPrincipalID,
                    PuestoEspecificoID = puestoEspecificoID
                };

                // Llamar al método ActualizarAlumno y manejar el resultado
                try
                {
                    int result = AlumnoDAL.ActualizarAlumno(alumno);
                    if (result > 0)
                    {
                        MessageBox.Show("Éxito al actualizar");
                        CargarAlumnos(); // Volver a cargar los alumnos para actualizar el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No se realizó ninguna actualización en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el AlumnoID desde el campo oculto
                if (!int.TryParse(txtAlumnoID.Text, out int alumnoID))
                {
                    MessageBox.Show("Error al obtener el ID del alumno.");
                    return;
                }

                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este alumno?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int filasAfectadas = AlumnoDAL.EliminarAlumno(alumnoID);
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Alumno eliminado con éxito");
                            CargarAlumnos(); // Volver a cargar los alumnos para actualizar el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se eliminó ningún alumno.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para eliminar.");
            }
        }

    }
}