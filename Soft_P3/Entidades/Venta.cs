using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
   public class Venta
    {
        private int noFactura;
        private Cliente codCliente;
        private string tipoPago;
        private DateTime fechaFactura;
        private Usuario idUsuario;
        private string codFactura;


        public int NoFactura
        {
            get { return noFactura; }
            set { noFactura = value; }
        }

        public Cliente CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public string TipoPago
        {
            get { return tipoPago; }
            set { tipoPago = value; }
        }

        public DateTime FechaFactura
        {
            get { return fechaFactura; }
            set { fechaFactura = value; }
        }

        

        public string CodFactura
        {
            get { return codFactura; }
            set { codFactura = value; }
        }

       public Usuario IdUsuario
       {
           get { return idUsuario; }
           set { idUsuario = value; }
       }

       public Venta()
        {
            CodCliente=new Cliente();
           IdUsuario=new Usuario();
        }

    }
}
