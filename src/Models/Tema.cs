using System.ComponentModel.DataAnnotations;

namespace BackOfficeLU.Models
{
    public class Tema
    {
        public int IdTema { get; set; }

        [Required]
        //[StringLength(60, ErrorMessage = "El titulo del Tema no puede contener más de 60 caracteres. ")]
        public string TituloTema { get; set; }

        [Required]

        public int IdClase { get; set; }
    }
}