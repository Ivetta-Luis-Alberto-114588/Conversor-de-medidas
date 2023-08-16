using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    public  class ServicioConversion
    {
        public double ConvertirTiempo(double valor, tiempoEnumerador p_desde, tiempoEnumerador p_a)
        {
            double resultado = Math.Round(valor, 3);

            if (p_desde == tiempoEnumerador.segundos && p_a == tiempoEnumerador.minutos)
            {
                resultado = valor / 60;
            }
            else if (p_desde == tiempoEnumerador.segundos && p_a == tiempoEnumerador.horas)
            {
                resultado = valor / 3600;
            }
            else if (p_desde == tiempoEnumerador.minutos && p_a == tiempoEnumerador.segundos)
            {
                resultado = valor * 60;
            }
            else if (p_desde == tiempoEnumerador.minutos && p_a == tiempoEnumerador.horas)
            {
                resultado = valor / 60;
            }
            else if (p_desde == tiempoEnumerador.horas && p_a == tiempoEnumerador.segundos)
            {
                resultado = valor * 3600;
            }
            else if (p_desde == tiempoEnumerador.horas && p_a == tiempoEnumerador.minutos)
            {
                resultado = valor * 60;
            }

            return resultado;
        }

        public double ConvertirMasa(double valor, masaEnumerador p_desde, masaEnumerador p_a)
        {
            double resultado = Math.Round(valor, 3);

            if (p_desde == masaEnumerador.gramos && p_a == masaEnumerador.kilogramos)
            {
                resultado = valor / 1000;
            }
            else if (p_desde == masaEnumerador.gramos && p_a == masaEnumerador.libras)
            {
                resultado = valor / 454;
            }
            else if (p_desde == masaEnumerador.kilogramos && p_a == masaEnumerador.gramos)
            {
                resultado = valor * 1000;
            }
            else if (p_desde == masaEnumerador.kilogramos && p_a == masaEnumerador.libras)
            {
                resultado = valor * 2;
            }
            else if (p_desde == masaEnumerador.libras && p_a == masaEnumerador.gramos)
            {
                resultado = valor * 454;
            }
            else if (p_desde == masaEnumerador.libras && p_a == masaEnumerador.kilogramos)
            {
                resultado = valor / 2;
            }

            return resultado;
        }

        public double ConvertirTemperatura(double valor, temperaturaEnumerador p_desde, temperaturaEnumerador p_a)
        {
            double resultado = Math.Round(valor, 3);

            if (p_desde == temperaturaEnumerador.celsius && p_a == temperaturaEnumerador.fahrenheit)
            {
                resultado = (valor * 9 / 5) + 32;
            }
            else if (p_desde == temperaturaEnumerador.celsius && p_a == temperaturaEnumerador.kelvin)
            {
                resultado = valor + 273;
            }
            else if (p_desde == temperaturaEnumerador.fahrenheit && p_a == temperaturaEnumerador.celsius)
            {
                resultado = (valor - 32) * 5 / 9;
            }
            else if (p_desde == temperaturaEnumerador.fahrenheit && p_a == temperaturaEnumerador.kelvin)
            {
                resultado = (valor - 32) * 5 / 9 + 273;
            }
            else if (p_desde == temperaturaEnumerador.kelvin && p_a == temperaturaEnumerador.celsius)
            {
                resultado = valor - 273;
            }
            else if (p_desde == temperaturaEnumerador.kelvin && p_a == temperaturaEnumerador.fahrenheit)
            {
                resultado = (valor - 273) * 9 / 5 + 32;
            }

            return resultado;
        }
    }
}
