using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionesMatematicas
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            num1.Text = "";num2.Text = "";
            opciones.SelectedIndex = 0;
            num1.Focus();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string mensaje = "Resultado ";
            string titulo = "Mensaje C#";
            Operaciones obj = new Operaciones();
            try
            {
                if (!num1.Text.Equals("") && !num2.Text.Equals(""))
                {
                    if (opciones.SelectedIndex != 0)
                    {
                        int n1 = int.Parse(num1.Text); int n2 = int.Parse(num2.Text);
                        if (opciones.SelectedIndex == 1)
                        {
                            MessageBox.Show(mensaje + "de la suma es: " + obj.sumar(n1, n2), titulo);
                        }
                        else if (opciones.SelectedIndex == 2)
                        {
                            MessageBox.Show(mensaje + "de la resta es: " + obj.restar(n1, n2), titulo);
                        }
                        else if (opciones.SelectedIndex == 3)
                        {
                            MessageBox.Show(mensaje + "de la multiplicación es: " + obj.multiplicar(n1, n2), titulo);
                        }
                        else {
                            if (n2 != 0)
                            {
                                MessageBox.Show(mensaje + "de la división es: " + obj.dividir(n1, n2), titulo);
                            }
                            else {
                                MessageBox.Show("No existe división para 0", titulo);
                                num2.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Elegir una opcion", titulo);
                    }

                }
                else {
                    MessageBox.Show("Existe campos vacios", titulo);
                    num1.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
