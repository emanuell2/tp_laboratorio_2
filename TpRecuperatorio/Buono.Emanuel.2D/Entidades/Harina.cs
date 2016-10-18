using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina:Producto
    {

        protected ETipoHarina _tipo;
        protected static bool _deConsumo;

        public override float CalcularCostoDeProduccion { get { return this._precio * 0.60F; } }

        static Harina()
        {
            _deConsumo = true;
        }

        public Harina(int codigoDeBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoDeBarra, marca, precio)
        {
            this._tipo = tipo;
        }

        private string MostrarHarina()
        {
            return this._codigoDeBarra.ToString() + " " + this._marca + " " + this._precio.ToString() + " " + this._tipo;
        }

        public override string ToString()
        {
            return MostrarHarina();
        }
    }
}
