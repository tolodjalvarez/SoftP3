using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
    class Cliente
    {
        public int Id { get; private set; }
        public string NombCliente { get; private set; }
        public string ApelliCliente { get; private set; }
        public string Telefono { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }
        public string Cedula { get; private set; }
        public string Direccion { get; private set; }
        public string Nacionalidad { get; private set; }
        public string Rnc { get; private set; }
        public DateTime Fecha { get; private set; }

        public Cliente()
        {
            
        }

        public Cliente(int id, string nombcliente, string apellicliente, string telefono,
            string celular, string email, string cedula, string direccion, string nacionalidad, string rnc,
            DateTime fecha)
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
