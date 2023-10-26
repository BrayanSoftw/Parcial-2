using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
        class Empleado
        {
            string Nombre;
        public double CalcularSalarioAnual(double Salario)
        {
            return Salario * 12;
        }
            public Empleado(string nombre)
            {
                Nombre = nombre;
            }
            public int Edad(int Edad)
            {
                return Edad;
            }
            public double Salario(double Salario)
            {
                return Salario;
            }
        }
 }

