using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnsDirectorioDePerros
{
    public class Directorio
    {
        public List<Duenio> Duenios { get; set; }
        public Directorio()
        {
            Duenios = new List<Duenio>();
        }
        public void AgregarPerro(Duenio duenioDelPerro, Perro perroAAgregar)
        {
            if (ElDuenioExiste(duenioDelPerro))
            {
                Duenio elDuenioReal = ObtenerDuenio(duenioDelPerro);
                elDuenioReal.Perros.Add(perroAAgregar);
            }
        }
        public void AgregarDuenio(Duenio duenioAAgregar)
        {
            Duenios.Add(duenioAAgregar);
        }
        private Duenio ObtenerDuenio(Duenio duenioDelPerro)
        {
            return Duenios.Find(unDuenio => unDuenio.Equals(duenioDelPerro));
        }
        private bool ElDuenioExiste(Duenio duenioDelPerro)
        {
            return Duenios.Any(unDuenio => unDuenio.Equals(duenioDelPerro));
        }
    }
}
