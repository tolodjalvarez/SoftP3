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
        public string nombre;
        public int salida;
        public Categoria categoria1;
        private DateTime fechaVencimiento ;
     
        public int minimo;
        public double precioCompra;
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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

        public int Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }

        public double PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public Articulo()
        {
            Categoria1 = new Categoria();
            nProveedor = new Proveedor();

        }

        public Articulo(int id,string descArt,double precioVenta,int existencia,
            string nombre,Categoria categoria,DateTime fechaV,int minimo,double precioCompra,Proveedor proveedor)
        {
            Id = id;
            Categoria1 = categoria;
            DescArt = descArt;
            PrecioVenta = precioVenta;
            Existencia = existencia;
            Nombre = nombre;
            FechaVencimiento = fechaV;
            
            Minimo = minimo;
            PrecioCompra = precioCompra;
            nProveedor = proveedor;
        }
    }

}
