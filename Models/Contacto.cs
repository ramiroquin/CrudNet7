using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    // Tabla de contacto
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]  
        public string? Nombre { get; set; }

        [Required(ErrorMessage ="El apellido es obligatorio")]
        public string? Apellido { get; set; }

        [Range(1, 20)]
        [Required(ErrorMessage = "El celular es obligatorio")]
        public int Celular { get; set; }

        [Required(ErrorMessage ="El email es obligatorio")]
        public string? Email { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
