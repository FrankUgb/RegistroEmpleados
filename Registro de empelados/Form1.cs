using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_empelados
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(textId.Text, out ID))
            {
                errorProvider1.SetError(textId, "No ingresó un ID válido");
                textNombre.Focus();
                return;
            }
            errorProvider1.SetError(textId, "");


            if (textNombre.Text == "")
            {
                errorProvider1.SetError(textNombre, "No ingreso el nombre");
                textNombre.Focus(); 
                return;
            }
            errorProvider1.SetError(textNombre, "");

            if (textDui.Text == "")
            {
                errorProvider1.SetError(textDui, "No ingreso el DUI");
                textNombre.Focus();
                return;
            }
            errorProvider1.SetError(textNombre, "");

            double Salario;
            if (!double.TryParse(textSalario.Text, out Salario))
            {
                errorProvider1.SetError(textSalario, "No ingresó el salario de forma correcta");
                textSalario.Focus();
                return;
            }
            errorProvider1.SetError(textId, "");

            Empleado.Id = Convert.ToInt32(textId.Text);
            Empleado.Nombre = textNombre.Text;
            Empleado.Dui = textDui.Text;
            Registro.Text = "¡Registro guardado!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNeto.Text = Empleado.Neto(Empleado.Salario).ToString();
        }
    }
}
