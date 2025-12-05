using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {

        PilaDinamica<Alumno> pila = new PilaDinamica<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgAlumnos.Columns.Add("colNombre", "Nombre");
            dtgAlumnos.Columns.Add("colEdad", "Edad");
            dtgAlumnos.Columns.Add("colEstatura", "Estatura");
            dtgAlumnos.ReadOnly = true;
            dtgAlumnos.AllowUserToAddRows = false;
            dtgAlumnos.AllowUserToDeleteRows = false;
            dtgAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                double promedio = double.Parse(txtPromedio.Text);

                Alumno nuevo = new Alumno(nombre, edad, promedio);
                pila.Apilar(nuevo);

                MostrarPila();
                LimpiarCampos();
            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados.");
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno eliminado = pila.Desapilar();
                MessageBox.Show($"Alumno desapilado:\n{eliminado}");
                MostrarPila();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerTope_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno tope = pila.VerTope();
                MessageBox.Show($"Tope de la pila:\n{tope}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            pila.Vaciar();
            MostrarPila();
        }
        public void MostrarPila()
        {
            dtgAlumnos.Rows.Clear();
            foreach (Alumno a in pila.ObtenerElementos())
            {
                dtgAlumnos.Rows.Add(a.Nombre, a.Edad, a.Promedio);
            }
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtPromedio.Clear();
        }
    }
}
