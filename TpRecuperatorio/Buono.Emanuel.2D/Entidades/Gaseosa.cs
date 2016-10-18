using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        protected float _litros;
        protected static bool _deConsumo;

        public override float CalcularCostoDeProduccion { get { return this._precio * 0.42F; } }

        static Gaseosa()
        {
            _deConsumo = true;
        }

        public Gaseosa(int codigoDeBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoDeBarra, marca, precio)
        {
            this._litros = litros;
        }

        private string MostrarGaseosa()
        {
            return this._codigoDeBarra.ToString() + " " + this._marca.ToString() + " " + this._precio.ToString() + " " + this._litros.ToString();
        }

        public override string ToString()
        {
            return MostrarGaseosa();
        }

        public override string Consumir()
        {
            return "Bebible";
        }

    }
}
