

using System.ComponentModel.DataAnnotations;

namespace Ferretero11D.Models
{
    public class Categoria
    {

        //Definimos las propiedades de la entidad Categoria

        [Key]/*Indicamos cual es nuestro Primary Key*/
        public int Id { get; set; }


        //Nombre ES OBLIGATORIO
        [Required(ErrorMessage="Nombre de categoria obligatorio") ]
        public string NombreCategoria { get; set; }


        //Orden de dato ES OBLIGATORIO
        [Required(ErrorMessage = "El dato Orden es obligatorio")]
        //El orden de los datos sea mayor a 0, no puede ser un numero negativo
        [Range(1,int.MaxValue, ErrorMessage ="El orden debe ser mayor a cero")]
        public int MostrarOrden { get; set; }
    }
}
