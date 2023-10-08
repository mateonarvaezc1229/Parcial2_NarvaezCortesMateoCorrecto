using System.ComponentModel.DataAnnotations;

namespace Parcial2_NaturalPerson.DAL.Entities
{
    public class Entity
    {
        #region
        [Required]
        public Guid Id { get; set; }

        [Display(Name ="Fecha de Creación :")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de Modificación :")]
        public DateTime? ModifiedDate { get; set; }

        #endregion
    }
}
