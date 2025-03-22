using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_polimorfismo_proyect.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int Cilindrada;
        private bool TieneCasco;
        private string TipoManillar;

        public Motocicleta(int anio, string elColor, string elModelo, int cilindraje, string manillar)
            : base(anio, elColor, elModelo)
        {
            Cilindrada = cilindraje;
            TieneCasco = false;
            TipoManillar = manillar;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto * 2);
        }

        public override void Frenar()
        {
            Console.WriteLine("Motocicleta frenando... Baja velocidad más rápido");
        }

        public void UsarCasco()
        {
            TieneCasco = true;
            Console.WriteLine("Casco colocado. Seguridad incrementada.");
        }
    }
}
