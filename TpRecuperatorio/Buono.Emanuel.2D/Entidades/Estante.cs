using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        private Estante()
        {
            this._productos = new List<Producto>();
        }
        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public float ValorEstanteTotal
        {
            get
            {
                float total = 0F;
                for (int i = 0; i < this._productos.Count; i++)
                {
                    total += this._productos[i].Precio;
                }

                return total;
            }
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string returnMostrar = "";
            for (int i = 0; i < e._productos.Count; i++)
            {
                if (e._productos[i] is Jugo)
                    returnMostrar = returnMostrar + e._productos[i].ToString();

                if (e._productos[i] is Galletita)
                    returnMostrar = returnMostrar + e._productos[i].ToString();

                if (e._productos[i] is Harina)
                    returnMostrar = returnMostrar + e._productos[i].ToString();

                if (e._productos[i] is Gaseosa)
                    returnMostrar = returnMostrar + e._productos[i].ToString();
            }

            return returnMostrar;
        }

        public float GetValorEstante(ETipoProducto tProd)
        {
            float totalVEstante = 0F;
            for (int i = 0; i < this._capacidad; i++)
            {
                if (this._productos[i].GetType().Name == tProd.ToString())
                    totalVEstante = totalVEstante + this._productos[i].Precio;
            }
            return totalVEstante;
        }

        private float GetValorEstante()
        {
            return ValorEstanteTotal;
        }

        #region operadores

        public static bool operator ==(Estante e, Producto prod)
        {
            bool retorno  =false;
            for (int i = 0; i < e._productos.Count; i++)
            {
                if (e._productos[i].Marca == prod.Marca && e._productos[i].CodigoDeBarra == prod.CodigoDeBarra)
                    retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator +(Estante e, Producto prod)
        {
            bool retorno = false;
            if (e._capacidad > e._productos.Count)
            {
                if (e != prod)
                {
                    e._productos.Add(prod);
                    retorno = true;
                }
            }

            return retorno;
        }

        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
                e._productos.Remove(prod);

            return e;
        }

        public static Estante operator -(Estante e, ETipoProducto prod)
        {
            for (int i = e._capacidad - 1; i > 0; i-- )
            {
                if (e._productos[i].GetType().Name == prod.ToString())
                    e._productos.Remove(e._productos[i]);
                if (prod.ToString() == "Todos")
                {
                    e._productos.Clear();
                    break;
                }
            }

                return e;
        }

        #endregion
    }
}
