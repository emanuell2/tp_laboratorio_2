using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        /// <summary>
        /// Opera utilizando el atributo numero de los parametros de tipo numero retornando el resultado de la operacion segun el operador o 0 si alguno de los parametros no fuera valido
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            switch (validarOperador(operador))
            {
                case "+":
                    return numero1.getNumero() + numero2.getNumero();
                   
                case "-": 
                    return numero1.getNumero() - numero2.getNumero();
                   
                case "/":
                    if (numero2.getNumero() != 0)
                        return numero1.getNumero() / numero2.getNumero();
                    else
                        return 0;
                   
                case "*": 
                    return numero1.getNumero() * numero2.getNumero();
                    
                default: 
                    return 0;
            }

        }
        /// <summary>
        /// Valida que el parametro de tipo string sea un operador matematico valido.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
            if (operador == "-" || operador == "/" || operador == "*")
                return operador;
            else
                return "+";
        }
    }
}
