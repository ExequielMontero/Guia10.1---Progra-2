using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Jornaleros:Empleado
    {
        public Jornaleros(int dni, string nombre, int horas, double valorporhora, double retencion) : base(dni, nombre)
        {
            HorasTrabajadas = horas;
            ImportePorHora = valorporhora;
            RetencionesImpositivas = retencion;
        }

        public int HorasTrabajadas { get; private set; }
        public  double ImportePorHora { get; private set; }
        public double RetencionesImpositivas { get; private set; }

        public override double CalcularImporteAPagar()
        {
            return (HorasTrabajadas * ImportePorHora) - RetencionesImpositivas;
        }

        public override string[] GenerarRecibo()
        {
            string[] recibo = new string[5];
            recibo[0] = $"Nombre: {Nombre}  - DNI: {Dni} ";
            recibo[1] = "";
            recibo[2] = $"Importe en horas trabajadas: ({HorasTrabajadas}/${ImportePorHora})".PadRight(45) + $"$     {HorasTrabajadas*ImportePorHora}";
            recibo[3] = $"Retenciones impositivos:".PadRight(53) + $" -$     {RetencionesImpositivas}";
            recibo[4] = $"Importe a Percibir:".PadRight(53) + $"       $     {CalcularImporteAPagar()}";
            return recibo;
        }

        public override string ToString()
        {
            return $"{Nombre}({Dni})";
        }
    }
}
