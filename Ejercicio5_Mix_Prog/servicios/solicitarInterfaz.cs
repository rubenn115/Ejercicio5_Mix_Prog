// Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Mix_Prog.servicios
{
    /// <summary>
    /// Interfaz para la solicitud de los datos
    /// rbr - 061123
    /// </summary>
    internal interface solicitarInterfaz
    {
        /// <summary>
        /// Enunciado de los métodos que tendrá la implementación de la interfaz
        /// rbr - 061123
        /// </summary>
        /// <returns></returns>
        public int solicitudMes();

        public int solicitudAnyo();
    }
}
