using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        protected float _peso;
        protected static bool _deConsumo;

        public override float CalcularCostoDeProduccion { get { return this._precio * 0.33F; } }

        static Galletita()
        {
            _deConsumo = true;
        }

        public Galletita(int codigoDeBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoDeBarra, marca, precio)
        {
            this._peso = peso;
        }

        private static string MostrarGalletita(Galletita g)
        {
            return g._codigoDeBarra.ToString() + " " + g._marca.ToString() + " " + g._precio.ToString() + " " + g._peso.ToString();
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        public override string ToString()
        {
            return this._codigoDeBarra.ToString() + " " + this._marca.ToString() + " " + this._precio.ToString() + " " + this._peso.ToString();
        }
    }
}
