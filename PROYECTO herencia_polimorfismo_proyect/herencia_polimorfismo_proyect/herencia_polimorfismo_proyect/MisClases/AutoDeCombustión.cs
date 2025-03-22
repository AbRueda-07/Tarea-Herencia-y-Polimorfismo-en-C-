using herencia_polimorfismo_proyect.MisClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace herencia_polimorfismo_proyect.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private int NivelCombustible;
        private string tipoCombustible;
        private bool encendido;

        public AutoDeCombustion(int anio, string elColor, string elModelo, string tipoComb)
            : base(anio, elColor, elModelo)
        {
            NivelCombustible = 100;
            tipoCombustible = tipoComb;
            encendido = false;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            NivelCombustible -= 2;
        }

        public override void Frenar()
        {
            Console.WriteLine("Auto frenando... Reducción de velocidad y consumo mínimo de combustible");
        }

        public void CargarCombustible(int cantidad)
        {
            NivelCombustible += cantidad;
            Console.WriteLine("Combustible cargado. Nivel actual: {0}", NivelCombustible);
        }
    }
}

