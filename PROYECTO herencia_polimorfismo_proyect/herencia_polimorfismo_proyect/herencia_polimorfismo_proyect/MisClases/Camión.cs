using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_polimorfismo_proyect.MisClases
{
    internal class Camión : Vehiculo
    {
        private int capacidadCarga;
        private int ejes;
        private bool tieneRemolque;

        public Camión(int anio, string elColor, string elModelo, int capacidad, int numEjes)
            : base(anio, elColor, elModelo)
        {
            capacidadCarga = capacidad;
            ejes = numEjes;
            tieneRemolque = false;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto / 2);
        }

        public override void Frenar()
        {
            Console.WriteLine("Camión frenando... Necesita más distancia para detenerse");
        }

        public void EngancharRemolque()
        {
            tieneRemolque = true;
            Console.WriteLine("Remolque enganchado. Capacidad de carga aumentada.");
        }
    }

}
