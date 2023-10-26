using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    class Gerente : Empleado
    {
        new double Salario;
        public Gerente(double Salario, string nombre) : base(nombre)
        {
            this.Salario = Salario;
        }
        public double getSalario()
        {
            return Salario;
        }
        public double setSalario(double salario)
        {
            //this.Salario = Salario; return this.Salario;
            return this.Salario = salario;
        }
        public string Departamento(string Departamento)
        {
            return Departamento;
        }
    }
}
