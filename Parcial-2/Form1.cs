using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        DataTable tabla = new DataTable();
        DataColumn column;
        DataRow row;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            double Salario = Convert.ToDouble(txtSalario.Text);

            Gerente gerente = new Gerente (Salario, Nombre);
            {
                Salario = Convert.ToDouble(txtSalario.Text);
                Nombre = txtNombre.Text;
            }

            empleados.Add(gerente);
            column = new DataColumn();
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Rows.Add(empleados);
            txtNombre.Clear();
            txtEdad.Clear();
            txtSalario.Clear();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpleados.CurrentCell = dgvEmpleados.CurrentRow.Cells["Monto"];
            dgvEmpleados.BeginEdit(true);
        }

        private void btnMostrarEmpleado_Click(object sender, EventArgs e)
        {

            string Nombre = txtNombre.Text;
            int Edad = txtEdad.Text.Length;
            //double Salario = Convert.ToDouble(txtSalario.Text);
        }
    }
}
