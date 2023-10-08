using System.ComponentModel.DataAnnotations;

namespace Parcial2_NaturalPerson.DAL.Entities
{
    public class NaturalPerson : Entity
    {
        #region
        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [Display(Name ="Ingrese Nombre Completo: ")]

        public string FullName { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [Display(Name = "Ingrese el año de Nacimiento: ")]

        public int BirthYear {  get; set; }
        public int Age { get; set; }
        #endregion

    }
}
