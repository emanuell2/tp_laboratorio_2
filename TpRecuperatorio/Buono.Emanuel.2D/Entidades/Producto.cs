using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public Producto(int codigoDeBarra, EMarcaProducto marca, float precio)
        {
            this._codigoDeBarra = codigoDeBarra;
            this._marca = marca;
            this._precio = precio;
        }

        public int CodigoDeBarra { get { return _codigoDeBarra; } }
        public float Precio { get { return _precio; } }
        public abstract float CalcularCostoDeProduccion { get;}
        public EMarcaProducto Marca { get { return this._marca; } }

        private string Mostrar()
        {
            return "-" + _codigoDeBarra.ToString() + " - " + _marca.ToString() + " - " + _precio.ToString();
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            bool retorno = false;
            if(object.Equals(prod1, prod2))
            {
                if (prod1._marca == prod2._marca && prod1._precio == prod2._precio)
                    retorno = true;  
            }

            return retorno;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public static bool operator ==(Producto prod, EMarcaProducto prodMarca)
        {
            if (prod._marca == prodMarca)
                return true;
            else
                return false;
        }

        public static bool operator !=(Producto prod, EMarcaProducto prodMarca)
        {
            return !(prod == prodMarca);
        }

        public static explicit operator int(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static implicit operator string(Producto p)
        {
            return p.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla ";
        }
    }
}
