using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        protected ESaborJugo _sabor;
        protected static bool _deConsumo;

        public override float CalcularCostoDeProduccion { get { return base.Precio * 0.60F; } }

        static Jugo()
        {
            _deConsumo = true;
        }

        public Jugo(int codigoDeBarra, float precio, EMarcaProducto marca, ESaborJugo sabor):base(codigoDeBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        private string MostrarJugo()
        {
            return this._codigoDeBarra.ToString() + " " + this._marca.ToString() + " " + this._precio.ToString() + " " + this._sabor.ToString();
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        public override string ToString()
        {
            return MostrarJugo();
        }
    }
}
