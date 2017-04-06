using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numero
    {
        private double _numero;

        #region Constructores
        public Numero()
        {
            this._numero = 0;
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

 
        public Numero(string numero)
        {
            setNumero(numero);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene el valor del atributo _numero
        /// </summary>
        /// <returns></returns>
        public double getNumero()
        {
            return this._numero;
        }
        /// <summary>
        /// Carga el valor dentro del atributo numero usando el metodo validarNumero
        /// </summary>
        /// <param name="numero"></param>
        private void setNumero(string numero)
        {
           this._numero= validarNumero(numero);
        }
        /// <summary>
        /// Metodo que toma un string por parametro y valida que sea un numero 
        /// retornando un double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static double validarNumero(string numero)
        {
            Numero num = new Numero();
            if (double.TryParse(numero, out num._numero))
                return num._numero;
            else
                return 0;
        }
        #endregion
    }
}
