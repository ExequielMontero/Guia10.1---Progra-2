using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Asalariado:Empleado
    {
        public Asalariado(int dni, string nombre, double basico, double aportes) : base(dni, nombre)
        {
            Basico = basico;
            AportesPrevisionales = aportes;

        }

        public double Basico { get; private set; }
        public double AportesPrevisionales { get; private set; }


        public override double CalcularImporteAPagar()
        {
            return Basico - AportesPrevisionales;
        }

        public override string[] GenerarRecibo()
        {
            string[] recibo = new string[5];
            recibo[0] = $"Nombre: {Nombre}  - DNI: {Dni}";
            recibo[1] = "";
            recibo[2] = $"Básico:".PadRight(40) + $"$ {Basico.ToString("N2")}";
            recibo[3] = $"Aportes Previsionales:".PadRight(30) + $"-$ {AportesPrevisionales.ToString("N2")}";
            recibo[4] = $"Importe a percibir:".PadRight(35) + $"$ {CalcularImporteAPagar().ToString("N2")}";
            return recibo;
        }

        public override string ToString()
        {
            return $"{Nombre}({Dni})";
        }

    }
}
