using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

            double Precio, Cantidad, Total;

            Precio = Convert.ToDouble(textBoxPrecio.Text);
            Cantidad = Convert.ToDouble( textBoxCantidad.Text);
            Total = Precio * Cantidad;

            labelTotal.Text = Convert.ToString(Total);

            }
            catch(Exception Error) {
                MessageBox.Show("Estoy en el catch, y este es el error: ", Error.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxPrecio.Text = "";
                textBoxCantidad.Text = "";
                labelTotal.Text = "";
                textBoxPrecio.Focus();
                
            }
            finally
            {
                MessageBox.Show("Ahora estoy en el finally. ");
            }

        }
    }
}
