using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //lo que hace el boton es que dependiendo de lo seleccionado en el checkbox proyecta los datos requeridos:
        private void aceptarBoton_Click(object sender, EventArgs e)
        {
          //  figurasCheckbox
                if (figurasCheckbox.SelectedIndex != -1)
            {
              //  MessageBox.Show(figurasCheckbox.SelectedIndex.ToString());
                switch (figurasCheckbox.SelectedIndex)
                {
                    case -1:
                        deshabilitar();
                        break;
                    case 0:
                        mostrarTriangulo();
                        break;
                    case 1:
                        mostrarRectangulo();
                        break;
                    default:
                        mostrarCirculo();
                        break;
                }



            }
        }
        private void deshabilitar()
        {
            b.Enabled = false;
            h.Enabled = false;
            r.Enabled = false;
        }
        //Ciruclo sex
        private void mostrarCirculo()
        {
            b.Enabled = false;
            h.Enabled = false;
            r.Enabled = true;
        }

        //mostrar lo requerido para el rectangulo
        private void mostrarRectangulo()
        {
            b.Enabled = true;
            h.Enabled = true;
            r.Enabled = false;
        }

        //metodo para mostrar lo requerido para el triangulo
        private void mostrarTriangulo()
        {
            b.Enabled = true;
            h.Enabled = true;
            r.Enabled = false;
        }

        private void figurasCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calcularBoton_Click(object sender, EventArgs e)
        {
            if (figurasCheckbox.SelectedIndex != -1)
            {
                //  MessageBox.Show(figurasCheckbox.SelectedIndex.ToString());
                switch (figurasCheckbox.SelectedIndex)
                {
                    case -1:
                        MessageBox.Show("No haz seleccionado nada pa");
                        break;
                    case 0:
                        calcularTriangulo();
                        break;
                    case 1:
                        calcularRectangulo();
                        break;
                    default:
                        calcularCirculo();
                        break;
                }
            }
        }

        private void calcularCirculo()
        {
            String res =(3.14* double.Parse(r.Text) * double.Parse(r.Text)).ToString();

            resultado.Text = res; 
        }

        private void calcularRectangulo()
        {
            resultado.Text =(Convert.ToDouble(h.Text)*Convert.ToDouble(b.Text)).ToString();
        }

        private void calcularTriangulo()
        {
            resultado.Text = ((Convert.ToDouble(b.Text)*Convert.ToDouble(h.Text))/2).ToString();
            
        }

        private void h_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiarBoton_Click(object sender, EventArgs e)
        {
            b.Clear();
            h.Clear();
            r.Clear();
            resultado.Clear();
            b.Enabled = false;
            h.Enabled = false;
            r.Enabled = false;

        }
    }
}
