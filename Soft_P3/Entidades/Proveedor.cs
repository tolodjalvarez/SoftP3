using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
   public class Proveedor
    {
        private int id;
        private string nombre;
        private string telefono ;
        private string rnc;
        private string pais;
        private string ciudad;
        private string email;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Rnc
        {
            get { return rnc; }
            set { rnc = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Proveedor()
        {
            
        }

        public Proveedor(int id, string nombre, string telefono, string rnc, string pais, string ciudad, string email)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Rnc = rnc;
            Pais = pais;
            Ciudad = ciudad;
            Email = email;
        }
    }
}
