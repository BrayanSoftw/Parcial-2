using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    class Asistente : Empleado
    {
        new double Salario;
        public Asistente(string Nombre, double Salario) : base(Nombre)
        {
            this.Salario = Salario;
        }
        public double getSalario()
        {
            return this.Salario;
        }
        public double setSalario()
        {
            return Salario;
        }
        public int HorasExtra(int HorasExtra)
        {
            return HorasExtra;
        }
    }
}
