using MySql.Data.MySqlClient;
using Programacion_I_clase_15.Datos.Acceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_I_clase_15
{
    public partial class Form1 : Form
    {
        private Personajes personajes;
        public Form1()
        {
            InitializeComponent();
            personajes = new Personajes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personajes.pruebaConexion())
            {
                MessageBox.Show("Funciona");
            }
            else
            {
                MessageBox.Show("No Sirve");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personajes.LeerPersonajes();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Nombre.Text;
            string raza = textBox_Raza.Text;
            int nivelPoder = (int)numericUpDown_Poder.Value;
            int respuesta = personajes.CrearPersonaje(nombre, raza, nivelPoder);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje Creado Exitosamente");
                dataGridViewPersonajes.DataSource = personajes.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Error, no se pudo Crear el Personaje");
            }
        }
    }
}
