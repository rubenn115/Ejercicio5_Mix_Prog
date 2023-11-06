// Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Mix_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz mostrar
    /// rbr - 061123
    /// </summary>
    internal class mostrarImplementacion : mostrarInterfaz
    {
        /// <summary>
        /// Método que mostrará el número de días que tiene el mes introducido
        /// rbr - 061123
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        public void mostrarNumDias(int mes, int anyo)
        {

            if (anyo % 4 == 0 && anyo % 100 == 0 && anyo % 400 == 0)
            {
                Console.WriteLine("El año " + anyo + " es bisiesto");
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Enero tiene 31 dias");
                            break;
                        case 3:
                            Console.WriteLine("Marzo tiene 31 dias");
                            break;
                        case 5:
                            Console.WriteLine("Mayo tiene 31 dias");
                            break;
                        case 7:
                            Console.WriteLine("Julio tiene 31 dias");
                            break;
                        case 8:
                            Console.WriteLine("Agosto tiene 31 dias");
                            break;
                        case 10:
                            Console.WriteLine("Octubre tiene 31 dias");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre tiene 31 dias");
                            break;
                    }
                }else if (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    switch(mes) 
                    { 
                        case 2:
                            Console.WriteLine("Febrero tiene 29 dias");
                            break;
                        case 4:
                            Console.WriteLine("Abril tiene 30 dias");
                            break;
                        case 6:
                            Console.WriteLine("Junio tiene 30 dias");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre tiene 30 dias");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre tiene 30 dias");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("El año " + anyo + " no es bisiesto");
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Enero tiene 31 dias");
                            break;
                        case 3:
                            Console.WriteLine("Marzo tiene 31 dias");
                            break;
                        case 5:
                            Console.WriteLine("Mayo tiene 31 dias");
                            break;
                        case 7:
                            Console.WriteLine("Julio tiene 31 dias");
                            break;
                        case 8:
                            Console.WriteLine("Agosto tiene 31 dias");
                            break;
                        case 10:
                            Console.WriteLine("Octubre tiene 31 dias");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre tiene 31 dias");
                            break;
                    }
                }
                else if (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    switch (mes)
                    {
                        case 2:
                            Console.WriteLine("Febrero tiene 28 dias");
                            break;
                        case 4:
                            Console.WriteLine("Abril tiene 30 dias");
                            break;
                        case 6:
                            Console.WriteLine("Junio tiene 30 dias");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre tiene 30 dias");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre tiene 30 dias");
                            break;
                    }
                }
            }
        }
    }
}
