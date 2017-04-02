using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autos;

namespace Ej04
{
    class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;

        public Carrera()
        {
            auto1 = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();
            auto4 = new Auto();
            auto5 = new Auto();
            auto6 = new Auto();
        }

        public void MostrarCarrera()
        {
            Console.WriteLine("Carrera\n\n" + auto1.MostrarAuto() + auto2.MostrarAuto() + auto3.MostrarAuto() +
                auto4.MostrarAuto() + auto5.MostrarAuto() + auto6.MostrarAuto());
        }
        public void PorTiempo(int minutos)
        {
            Random aux = new Random();

            for (int i = 0; i < minutos; i++)
            {
                auto1.AgregarKilometros(aux.Next(101));
                auto2.AgregarKilometros(aux.Next(101));
                auto3.AgregarKilometros(aux.Next(101));
                auto4.AgregarKilometros(aux.Next(101));
                auto5.AgregarKilometros(aux.Next(101));
                auto6.AgregarKilometros(aux.Next(101));
            }
            Auto ganador = Ganador();
            Console.WriteLine("El ganador es: \n" + ganador.MostrarAuto() + " " + ganador.GetKms());
        }
        private Auto Ganador()   
        {
            Auto ganador = auto1;
            if (auto2.GetKms() > ganador.GetKms())
                ganador = auto2;
            if (auto3.GetKms() > ganador.GetKms())
                ganador = auto3;
            if (auto4.GetKms() > ganador.GetKms())
                ganador = auto4;
            if (auto5.GetKms() > ganador.GetKms())
                ganador = auto5;
            if (auto6.GetKms() > ganador.GetKms())
                ganador = auto6;
            return ganador;
        }
    }

    
}
