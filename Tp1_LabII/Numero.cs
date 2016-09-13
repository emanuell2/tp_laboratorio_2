using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_LabII
{
    class Numero
    {
        #region Atributo privado numero
        /// <summary>
        /// 
        /// </summary>
        private double _numero;
        #endregion
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }
        #endregion
        #region Constructor una sobrecarga
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero):this()
        {
            numero = getNumero();
        }
        #endregion
        #region Constructor una sobrecarga
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroString"></param>
        public Numero(string numeroString): this()
        {
            setNumero(numeroString);
        }
        #endregion
        #region Validar Numero
        /// <summary>
        /// Valida que el numero pasado por parametro sea correcto
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns>retornara 0 si el numero fue invalido o retornara el mismo numero como double</returns>
        private double validarNumero(string numeroString)
        {
            double retornoVal = 0;
            double numeroAValidar;

            bool validacionNumero = double.TryParse(numeroString, out numeroAValidar);

            if (validacionNumero)
                retornoVal = numeroAValidar;

            return retornoVal;
        }
        #endregion
        #region Set Numero
        /// <summary>
        /// Setea el numero usando la funcion validarNumero
        /// </summary>
        /// <param name="numero"></param>
        private void setNumero(string numero)
        {
            this._numero = validarNumero(numero);
        }
        #endregion
        #region Get Numero
        /// <summary>
        /// Permite acceder al numero desde fuera de la clase
        /// </summary>
        /// <returns>retorna un double con el numero</returns>
        public double getNumero()
        {
            return this._numero;
        }
        #endregion
    }
}
