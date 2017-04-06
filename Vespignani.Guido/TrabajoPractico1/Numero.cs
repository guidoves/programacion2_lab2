using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Numero
    {
        private double numero; // Esta variable representa el numero para operar.

        #region Contructores 
        // Si el usuario deja el campo vacio el numero vale 0. 
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(String numero)
        {
            this.numero = validarNumero(numero);
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        #endregion

        #region Metodos

        public double getNumero()
        {
            return this.numero;
        }
        private void setNumero(String numero)
        {
            this.numero = validarNumero(numero);
        }
        private double validarNumero(String numeroString)
        {
            double numero;
            double.TryParse(numeroString, out numero);
            return numero;
        }

        #endregion

    }
}
