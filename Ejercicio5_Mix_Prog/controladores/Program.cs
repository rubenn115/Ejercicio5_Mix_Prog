// Ruben Bernal Ramos, CSI1

using Ejercicio5_Mix_Prog.servicios;

namespace Ejercicio5_Mix_Prog.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 061123
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// rbr - 061123
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Declaro las variables
            int mes, anyo;
            char respuesta;

            //Instancio las interfaces con sus implementaciones
            solicitarInterfaz si = new solicitarImplementacion();
            mostrarInterfaz mi = new mostrarImplementacion();

            do
            {
                //Pido por consola que el usuario introduzca el año
                anyo = si.solicitudAnyo();
                //Pido por consola que el usuario introduzca el mes
                mes = si.solicitudMes();

                //Realizo el procedimiento básico de la aplicación
                mi.mostrarNumDias(mes, anyo);

                //Pido al usuario si desea continuar
                Console.WriteLine("Desea hacer otra consulta??? (s = si // n = no): ");
                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');
        }
    }
}