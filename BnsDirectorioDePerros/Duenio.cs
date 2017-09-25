using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnsDirectorioDePerros
{
    public class Duenio
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public ICollection<Perro> Perros { get; set; }
        public Duenio()
        {
            Nombre = " Duenio ";
            Celular = " Celular ";
            Direccion = " Direccion ";
            Perros = new List<Perro>();
        }
        public Duenio(string unNombre, string unCelular, string unaDireccion)
        {
            Nombre = unNombre;
            Celular = unCelular;
            Direccion = unaDireccion;
            Perros = new List<Perro>();
        }
        public override string ToString()
        {
            return Nombre + " vive en " + Direccion + " y su cel es: " + Celular;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                return Nombre == ((Duenio)obj).Nombre && Nombre ==
                ((Duenio)obj).Celular;
            }
        }
    }
}
