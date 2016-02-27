using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soft_P3.Presentacion;

namespace Soft_P3.Entidades
{
    class Articulo
    {
        public int id;
        public string descArt;
        public double precioVenta;
        public int existencia;
        public int entrada;
        public int salida;
        public Categoria categoria1;
        public string ubicacion;
        public int maximo;
        public int minimo;
        public double costUnitario;
        public Proveedor nProveedor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DescArt
        {
            get { return descArt; }
            set { descArt = value; }
        }

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }

        public int Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        public int Salida
        {
            get { return salida; }
            set { salida = value; }
        }

        public Categoria Categoria1
        {
            get { return categoria1; }
            set { categoria1 = value; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public int Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }

        public int Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }

        public double CostUnitario
        {
            get { return costUnitario; }
            set { costUnitario = value; }
        }

        public Articulo()
        {
            Categoria1 = new Categoria();
            nProveedor = new Proveedor();

        }

        public Articulo(int id,string descArt,double precioVenta,int existencia,
            int entrada,int salida,Categoria categoria,string ubicacion,int maximo,int minimo,double costoUnitario,Proveedor proveedor)
        {
            Id = id;
            Categoria1 = categoria;
            DescArt = descArt;
            PrecioVenta = precioVenta;
            Existencia = existencia;
            Entrada = entrada;
            Salida = salida;
            Ubicacion = ubicacion;
            Maximo = maximo;
            Minimo = minimo;
            CostUnitario = costoUnitario;
            nProveedor = proveedor;
        }
    }

}
