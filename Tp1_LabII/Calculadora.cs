using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_LabII
{
    class Calculadora
    {
        #region Validar Operador
        /// <summary>
        /// Metodo que verificar que el operador ingresado sea valido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna "+" si no es valido o retorna el string con el operador</returns>
        public static string validarOperador(string operador)
        {
            string retValidar = "+";
            string div = "/";
            string resta = "-";
            string multip = "*";

            if(operador == div || operador == resta || operador == multip)
            {
                retValidar = div;
                if (operador == resta)
                    retValidar = resta;
                if (operador == multip)
                    retValidar = multip;
            }

            return retValidar;
        }
        #endregion

        #region Operar
        /// <summary>
        /// Realizar un operacion matematica basica en base al operador pasado por parametro
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>retorna el resultado de la operacion o 0 si no pudo realizar la operacion (division por 0)</returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double retornoOp = 0;
            string operacion = validarOperador(operador);

            if (operacion == "/")
            {
                if(numero2.getNumero()>0)
                retornoOp = numero1.getNumero()/numero2.getNumero();
            }

            if (operacion == "-")
                retornoOp = numero1.getNumero() - numero2.getNumero();

            if (operacion == "*")
                retornoOp = numero1.getNumero() * numero2.getNumero();

            if (operacion == "+")
                retornoOp = numero1.getNumero() + numero2.getNumero();

            return retornoOp;
        }
        #endregion


    }
}
