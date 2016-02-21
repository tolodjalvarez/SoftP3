using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
    class Articulo
    {
        public int Id { get; private set; }
        public string DescArt { get; private set; }
        public double PrecioVenta { get; private set; }
        public int Existencia { get; private set; }
        public int Entrada { get; private set; }
        public int Salida { get; private set; }
        public Categoria Categoria1 { get; private set; }
        public string Ubicacion { get; private set; }
        public int Maximo { get; private set; }
        public int Minimo { get; private set; }
        public double CostUnitario { get; private set; }
        public string Proveedor { get; private set; }

        public Articulo()
        {
            Categoria1 = new Categoria();
        }

        public Articulo(int id,string descArt,double precioVenta,int existencia,
            int entrada,int salida,Categoria categoria,string ubicacion,int maximo,int minimo,double costoUnitario,string proveedor)
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
            Proveedor = proveedor;
        }
    }

}
