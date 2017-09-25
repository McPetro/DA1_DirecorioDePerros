using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnsDirectorioDePerros
{
    public class Perro
    {
        public enum Tamanio { MuyChico, Chico, Mediano, Grande, MuyGrande }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public Tamanio ElTamanio { get; set; }
        public Perro()
        {
            Nombre = " Bobby ";
            Raza = " Perro ";
            ElTamanio = Tamanio.Mediano;
        }
        public Perro(string unNombre, string unaRaza, Tamanio unTamanio)
        {
            Nombre = unNombre;
            Raza = unaRaza;
            ElTamanio = unTamanio;
        }
        public override string ToString()
        {
            return Nombre + " de raza: " + Raza + " y tamanio: " +
            ImprimirTamanio(ElTamanio);
        }
        private string ImprimirTamanio(Tamanio tamanio)
        {
            switch (ElTamanio)
            {
                case Tamanio.MuyChico:
                    return " Muy Chico ";
                case Tamanio.Chico:
                    return " Chico ";
                case Tamanio.Mediano:
                    return " Mediano ";
                case Tamanio.Grande:
                    return " Grande ";
                case Tamanio.MuyGrande:
                    return " Muy Grande ";
                default:
                    return " ---- ";
            }
        }
    }
}
