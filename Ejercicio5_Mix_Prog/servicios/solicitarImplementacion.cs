// Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Mix_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz solicitar
    /// rbr - 061123
    /// </summary>
    internal class solicitarImplementacion : solicitarInterfaz
    {
        /// <summary>
        /// Método que pedirá por consola el mes
        /// rbr - 061123
        /// </summary>
        /// <returns></returns>
        public int solicitudAnyo()
        {
            int anyo;
            Console.WriteLine("Introduce el año: ");
            anyo = Convert.ToInt32(Console.ReadLine());

            return anyo;
        }

        /// <summary>
        /// Método que pedirá por consola el año
        /// rbr - 061123
        /// </summary>
        /// <returns></returns>
        public int solicitudMes()
        {
            int mes;
            Console.WriteLine("Introduce el mes (1-Enero.....12-Diciembre): ");
            mes = Convert.ToInt32(Console.ReadLine());

            return mes;
        }
    }
}
