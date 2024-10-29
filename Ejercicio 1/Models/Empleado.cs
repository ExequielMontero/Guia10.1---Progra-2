using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    abstract class Empleado : IComparable
    {
        public Empleado(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public int Dni { get; private set; }
        public string Nombre { get; private set; }


        abstract public double CalcularImporteAPagar();
        abstract public string[] GenerarRecibo();


        public int CompareTo(object obj)
        {
            Empleado actual = obj as Empleado;
            if (actual != null)
            {
                return this.Dni.CompareTo(actual.Dni);
            }
            return 1;
        }

    }
}
