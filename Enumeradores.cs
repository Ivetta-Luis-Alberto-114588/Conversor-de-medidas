using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    public enum tipoEnumerador
    {
        tiempo = 1,
        masa = 2,
        temperatura = 3
    }

    public enum tiempoEnumerador
    {
        segundos = 1,
        minutos = 2,
        horas = 3        
    }

    public enum masaEnumerador
    {
        gramos = 1,
        kilogramos = 2,
        libras = 3
    }

    public enum temperaturaEnumerador
    {
        celsius = 1,
        fahrenheit = 2,
        kelvin = 3
    }
}
