using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3.Entidades
{
  public  class Usuario
  {
      private int id;
      private string nombre;
      private string apellido;
      private string cedula;
      private string direccion;
      private string telefono;
      private string usuario;
      private string password;
      private string tipo;


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

      public string Apellido
      {
          get { return apellido; }
          set { apellido = value; }
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

      public string Telefono
      {
          get { return telefono; }
          set { telefono = value; }
      }

     

      public string Password
      {
          get { return password; }
          set { password = value; }
      }

      public string Tipo
      {
          get { return tipo; }
          set { tipo = value; }
      }

      public string Usuario1
      {
          get { return usuario; }
          set { usuario = value; }
      }

     }
}
