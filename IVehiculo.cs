using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    // La interfaz IVehiculo define un conjunto de propiedades y métodos que deben ser implementados por las clases que la utilicen
    interface IVehiculo
    {
        // Propiedades de la interfaz
        string Tipo_Auto { get; set; }
        string Modelo_Auto { get; set; }
        string Pito();
        string Color_Auto { get; set; }
        string Start();
        int Pedal_Acelerar(int valor);
        string Apagar_Vehiculo();
        string Identificacion_Auto { get; set; }
        int Pedal_Freno(int valor);
        string Marca_Auto { get; set; }
        int Año_Auto { get; set; }
        int Velocidad_Tope { get; }
        int Velocidad_Actual { get; }
    }
}

