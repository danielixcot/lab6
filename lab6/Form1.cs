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

namespace lab6
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Cliente> Clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
        }
        public void CargarClientes()
        {
            // leer archivo y cargar la lista
            string fileName = "Clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.Nit = Convert.ToInt16(reader.ReadLine());
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();

                Clientes.Add(cliente);
            }
            reader.Close();
        }
        public void CargarVehiculos()
        {
            // leer archivo y cargar la lista
            string fileName = "Clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.Nit = Convert.ToInt16(reader.ReadLine());
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();

                Clientes.Add(cliente);
            }
            reader.Close();
        }
        private void Guardar(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.Kilometro);
            }
            writer.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculo nuevehiculo = new Vehiculo();
            nuevehiculo.Placa = Convert.ToInt32(textBox1.Text);
            nuevehiculo.Marca = textBox2.Text;
            nuevehiculo.Modelo = textBox3.Text;
            nuevehiculo.Color = textBox4.Text;
            nuevehiculo.Kilometro = Convert.ToInt32(textBox5.Text);
            vehiculos.Add(nuevehiculo);
            Guardar("Vehiculos.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarClientes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Clientes ;
            dataGridView1.Refresh();
        }
    }
}
