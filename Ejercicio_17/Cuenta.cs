using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        /// <summary>
        /// Retorna el nombre asociado a la cuenta.
        /// </summary>
        public string GetNombre()
        {
            return this._nombre;
        }

        /// <summary>
        /// Asigna un nuevo nombre a la cuenta.
        /// </summary>
        /// <param name="nombre">
        /// Nuevo nombre a asignar. Nota: Debe contener al menos un caracter.
        /// </param>
        public void SetNombre(string nombre)
        {
            if (nombre.Length != 0)
                this._nombre = nombre;
        }

        /// <summary>
        /// Retorna el numero de la cuenta.
        /// </summary>
        public long GetNroCuenta()
        {
            return this._nroCuenta;
        }

        /// <summary>
        /// Asigna un nuevo numero a la cuenta.
        /// </summary>
        /// <param name="nroCuenta">
        /// Nuevo numero de cuenta. Nota: Debe ser mayor a cero.
        /// </param>
        public void SetNroCuenta(long nroCuenta)
        {
            if (nroCuenta > 0)
                this._nroCuenta = nroCuenta;
        }

        /// <summary>
        /// Retorna el saldo disponible de la cuenta.
        /// </summary>
        public double GetSaldo()
        {
            return this._saldo;
        }

        /// <summary>
        /// Asigna un nuevo valor al saldo de la cuenta.
        /// </summary>
        /// <param name="saldo">
        /// Nuevo saldo de la cuenta. Nota: debe ser mayor o igual a cero.
        /// </param>
        public void SetSaldo(double saldo)
        {
            if (saldo >= 0)
                this._saldo = saldo;
        }

        /// <summary>
        /// Retorna el tipo de interes de la cuenta.
        /// </summary>
        public ETipoInteres GetTipoInteres()
        {
            return this._tipoInteres;
        }

        /// <summary>
        /// Asigna un nuevo tipo de interes a la cuenta.
        /// </summary>
        /// <param name="tipoInteres">
        /// Nuevo tipo de cuenta. Nota: Debe ser un tipo habilitado.
        /// </param>
        public void SetTipoInteres(ETipoInteres tipoInteres)
        {
            if ((int)tipoInteres <= 2 && (int)tipoInteres >= 0)
                this._tipoInteres = tipoInteres;
        }
    }
}
