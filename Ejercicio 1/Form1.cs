using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ejercicio_1.Models;
using System.Text.RegularExpressions;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        List<Empleado> lista = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIEmpleados_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            openFileDialog1.Title = "Importar empleados";
            openFileDialog1.Filter = "Archivos de documentos .txt|*.txt|Todos los archivos *.|*.|Todos los archivos .CSV|*.CSV";
            openFileDialog1.FilterIndex = 3;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    sr.ReadLine();
                    string tipo;
                    string nombre;
                    int dni;
                    double aporte;
                    double basico;
                    double valorporhora;
                    double retencion;
                    int horastrabajadas;
                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        string[] parts = linea.Split(';');
                        tipo = parts[0];
                        dni = Convert.ToInt32(parts[1]);
                        nombre = parts[2];
                        if (Regex.Match(tipo, @"^asalariado{1}$", RegexOptions.IgnoreCase).Success == true)
                        {

                            basico = Convert.ToDouble(parts[3]);
                            aporte = Convert.ToDouble(parts[4]);
                            Empleado asalariado = new Asalariado(dni, nombre, basico, aporte);
                            lista.Add(asalariado);
                        }
                        else
                        {
                            horastrabajadas = Convert.ToInt32(parts[3]);
                            valorporhora = Convert.ToDouble(parts[4]);
                            retencion = Convert.ToDouble(parts[5]);

                            Empleado jornalero = new Jornaleros(dni, nombre, horastrabajadas, valorporhora, retencion);
                            lista.Add(jornalero);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("La estructura del archivo debe estar incompleta");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
            btnVer.Enabled = true;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            foreach (Empleado F in lista)
            {
                lbVer.Items.Add(F.ToString());
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            double montocobrar;
            FileStream fs = null;
            StreamWriter sw = null;
            saveFileDialog1.Title = "Importar empleados";
            saveFileDialog1.Filter = "Archivos de documentos .txt|*.txt|Todos los archivos *.|*.|Todos los archivos .CSV|*.CSV";
            saveFileDialog1.FilterIndex = 3;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("Tipo:Asalariado; DNI; Nombre;Básico; Aportes provisionales; Monto a cobrar");
                    sw.WriteLine("Tipo: Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones; Monto a cobrar");
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i] is Asalariado)
                        {
                            Asalariado actual = (Asalariado)lista[i];
                            montocobrar = actual.CalcularImporteAPagar();
                            sw.WriteLine($"Asalariado;{actual.Dni};{actual.Nombre};{actual.Basico};{actual.AportesPrevisionales};{montocobrar}");
                        }
                        else
                        {
                            Jornaleros actual = (Jornaleros)lista[i];
                            montocobrar = actual.CalcularImporteAPagar();
                            sw.WriteLine($"Jornalero;{actual.Dni};{actual.Nombre};{actual.HorasTrabajadas};{actual.ImportePorHora};{actual.RetencionesImpositivas};{montocobrar}");
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Debe haber un error en algun objeto");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ticket;
            Tickets vertickets = new Tickets();
            foreach(Empleado f in lista)
            {
                ticket = f.GenerarRecibo();
                vertickets.tbVer.Text += $"{ticket[0]}\r\n";
                for (int i = 1; i < ticket.Length; i++)
                {
                    string linea = ticket[i];
                    vertickets.tbVer.Text += $"{linea}\r\n";
                }
                vertickets.tbVer.Text += $"\r\n\r\n\r\n\r\n";
            }
            vertickets.ShowDialog();
        }
    }

}
