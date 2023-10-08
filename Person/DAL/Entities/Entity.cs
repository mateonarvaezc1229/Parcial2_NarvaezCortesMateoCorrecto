using System.ComponentModel.DataAnnotations;

namespace Parcial2_NaturalPerson.DAL.Entities
{
    public class Entity
    {
        #region
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        #endregion
    }
}
