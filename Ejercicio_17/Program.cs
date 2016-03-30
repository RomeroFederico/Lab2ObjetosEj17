using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{

    /*
    17.  Crear una clase llamada Cuenta y un enumerado llamado
    ETipoInteres.
    Se pide crear los métodos públicos (getters y setters) necesarios 
    para poder manipular un objeto de tipo Cuenta, sabiendo que 
    dichos métodos deberán de realizar las validaciones 
    correspondientes (en ningún caso se deberá pedir el reingreso de 
    datos dentro del método).
    */

    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 17";

            Cuenta miCuenta = new Cuenta();
            miCuenta.SetNombre("Romero Federico");
            miCuenta.SetNroCuenta(123);
            miCuenta.SetSaldo(100.58);
            miCuenta.SetTipoInteres(ETipoInteres.TAE);

            Ejercicio_17.MostrarCuenta(miCuenta);

            miCuenta.SetNombre("");
            miCuenta.SetNroCuenta(456);
            miCuenta.SetSaldo(-1);
            miCuenta.SetTipoInteres((ETipoInteres) 3);

            Ejercicio_17.MostrarCuenta(miCuenta);

            Console.ReadKey();
        }

        public static void MostrarCuenta(Cuenta cuentaAMostrar)
        {
            Console.WriteLine("Nombre: {0}", cuentaAMostrar.GetNombre());
            Console.WriteLine("Numero de cuenta: {0}", cuentaAMostrar.GetNroCuenta());
            Console.WriteLine("Saldo: {0, 0: #,###.00}", cuentaAMostrar.GetSaldo());
            Console.WriteLine("Tipo de interes: {0}\n", cuentaAMostrar.GetTipoInteres());
        }
    }
}
