using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitSample
{
    public class Car
    {
        public int IdCar { get; set; }
        public string  Description { get; set; }
        public Marca Marca { get; set; }
        public Tipo Tipo { get; set; }
    }

    public enum Marca
    {
        Ferrari,
        Renault,
        Opel,
        Mercedes
    }

    public enum Tipo
    {
        Utilitario,
        Camion,
        Motocicleta,
        Modificacion
    }
}
