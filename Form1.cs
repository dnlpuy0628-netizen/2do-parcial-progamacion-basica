using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Cafeteria_Daniel_Dupuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            double precio;
            Convert.ToDouble(txtPrecio);

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            this.txtProducto.Text = txtProducto.ToString();
        }

        private void lstPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstPedido.Items.Clear();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            decimal cantidad;
            cantidad = this.nudCantidad.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("ESCRIBA EL NOMBRE DEL PRODUCTO");
                txtProducto.Focus();
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("INGRESE UN PRECIO VALIDO");
                txtPrecio.Focus();

            }
            int cantidad = (int)nudCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("INGRESE UNA CANTIDAD VALIDA");
                nudCantidad.Focus();
                return;
            }
            const decimal AumentoxTamaño = 25m;
            const decimal AumentoxPorcion = 25m;
            const decimal AumentoxLlevar = 20m;
            const decimal Descuento_frecuente = 0.10m;
            decimal subtotal = 0m;
            decimal precioUnit = precio;
            decimal descFrecuente = 0.10m;
            decimal ITBIS = 0.18m;
            if (rbtGrande.Checked) precioUnit += AumentoxTamaño;
            if (chkPorcionnExtra.Checked) precioUnit += AumentoxPorcion;

            decimal totalLinea = precioUnit * cantidad;
            subtotal += totalLinea;

            lstPedido.Items.Add(
                cantidad.ToString().PadRight(8) + txtProducto.Text.Trim().PadRight(20) + precioUnit.ToString() + totalLinea.ToString());
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 0;
            rbtNormal.Checked = true;
            chkPorcionnExtra.Checked = false;
            txtProducto.Focus();
   }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(lstPedido.Items.Count == 0)
            {
                MessageBox.Show("INGRESE AL MENOS UN PRODUCTO");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            chkFrecuente.Checked = false;
            txtFecha.Text = DateTime.Now.ToString();
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 0;
            rbtNormal.Checked= true;
            rbtServicioNormal.Checked= true;
            lstPedido.Items.Clear();
            txtCliente.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
        }
