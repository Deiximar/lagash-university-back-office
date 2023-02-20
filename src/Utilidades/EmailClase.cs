using System;

namespace BackOfficeLU.Utilidades
{
    public class EmailClase
    {
        public string[] CorreoElectronicoPostulantes { get; set; }
        public int NumeroClase { get; set; }

        public string Responsable1 { get; set; }
        public string Responsable2 { get; set; }

        public DateTime Fecha { get; set; }

        public string TituloClase { get; set; }

        public string[] Temas { get; set; }
    }
}