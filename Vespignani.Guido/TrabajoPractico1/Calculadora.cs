using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    class Calculadora
    {
        // Realiza la operacion segun el operador. Valida operador valido.
        public static double operar(Numero numero1, Numero numero2, String operador)
        {
            String operacion = Calculadora.validarOperador(operador);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;
                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() != 0)
                        resultado = numero1.getNumero() / numero2.getNumero();
                    else
                        resultado = 0;
                    break;
            }
            return resultado;
        }
        // Validacion del operador. Si no es valido devuelve el operador "+".
        public static String validarOperador(String operador)
        {
            String retorno = "+";
            if (operador.Equals("+") || operador.Equals("-") || operador.Equals("*") || operador.Equals("/"))
                retorno = operador;
            return retorno;
        }
    }
}
