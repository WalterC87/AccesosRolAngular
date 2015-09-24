using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carretilla_Angular.Models
{
    public class IdentityViewModel
    {
    }

    public class IdentityUser
    {
        public string UserName { get; set; }
        public string Host { get; set; }
    }
    public class AccesoRol
    {
        public int RolId { get; set; }

        public string Name { get; set; }
        public ICollection<AccesoModulo> Modulos { get; set; }
        public ICollection<Data> Derechos { get; set; }
        public AccesoRol()
        {
            this.Modulos = new HashSet<AccesoModulo>();
            this.Derechos = new HashSet<Data>();
        }
    }

    public class AccesoModulo
    {
        public int ModuloId { get; set; }
        public string Nombre { get; set; }
        public ICollection<AccesoCaracteristica> Caracteristicas { get; set; }
        public AccesoModulo()
        {
            this.Caracteristicas = new HashSet<AccesoCaracteristica>();
        }
    }
    public class AccesoCaracteristica
    {
        public int CaracteristicaId { get; set; }
        public string Nombre { get; set; }
        public ICollection<AccesoDerecho> Derechos { get; set; }

        public AccesoCaracteristica()
        {
            this.Derechos = new HashSet<AccesoDerecho>();
        }
    }
    public class AccesoDerecho
    {
        public int DerechoId { get; set; }
        public bool? Status { get; set; }
    }
    public class Data
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

}