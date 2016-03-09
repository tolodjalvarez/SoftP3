using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
   public class DetalleVenta
   {
       private int id;
       private double impuesto;
       private Venta noFactura;
       private double precioVenta;
       private int cantidad;
       private  Articulo codArticulo;


       public int Id
       {
           get { return id; }
           set { id = value; }
       }

       public double Impuesto
       {
           get { return impuesto; }
           set { impuesto = value; }
       }

       public Venta NoFactura
       {
           get { return noFactura; }
           set { noFactura = value; }
       }

       public double PrecioVenta
       {
           get { return precioVenta; }
           set { precioVenta = value; }
       }

       public int Cantidad
       {
           get { return cantidad; }
           set { cantidad = value; }
       }

       public Articulo CodArticulo
       {
           get { return codArticulo; }
           set { codArticulo = value; }
       }

       public DetalleVenta()
       {
           CodArticulo=new Articulo();
           NoFactura=new Venta();
       }
   }
}
