using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
    public class Cliente
    {
        private int id;
        private string  nombCliente;
        private string apelliCliente;
        private string telefono;
        private string celular;
        private string email;
        private string cedula;
        private string direccion;
        private string nacionalidad;
        private string rnc;
        private DateTime fecha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombCliente
        {
            get { return nombCliente; }
            set { nombCliente = value; }
        }

        public string ApelliCliente
        {
            get { return apelliCliente; }
            set { apelliCliente = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public string Rnc
        {
            get { return rnc; }
            set { rnc = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Cliente()
        {
            
        }

        public Cliente(int id, string nombcliente, string apellicliente, string telefono, string celular, string email, string cedula, string direccion, string nacionalidad, string rnc,DateTime fecha)
        {
            Id = id;
            NombCliente = nombcliente;
            ApelliCliente = apellicliente;
            Telefono = telefono;
            Celular = celular;
            Email = email;
            Cedula = cedula;
            Direccion = direccion;
            Nacionalidad = nacionalidad;
            Rnc = rnc;
            Fecha = fecha;
        }
    }
}
