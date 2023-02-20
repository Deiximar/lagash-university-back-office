using System;

namespace BackOfficeLU.Utilidades
{
    public class FechasCalendario
    {
        public int id { get; set; }

        public string title { get; set; }
        public DateTime start { get; set; }

        public bool allDay { get; set; }

        public string className { get; set; }
    }
}