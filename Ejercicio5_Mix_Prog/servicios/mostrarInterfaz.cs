// Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Mix_Prog.servicios
{
    /// <summary>
    /// Interfaz para mostrar los datos
    /// rbr - 061123
    /// </summary>
    internal interface mostrarInterfaz
    {
        /// <summary>
        /// Enunciado del método que tendrá la implementación
        /// rbr - 061123
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        public void mostrarNumDias(int mes, int anyo);
    }
}
