using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace core_mvc_CRUD_EF.Models
{
    public class Units
    {

        [Key]
        [Display(Name = "Unit ID")]
        public int UnitID { get; set; }
        [Display(Name = "Unit Name")]
        public string Unit_Name { get; set; }
        [MaybeNull]
        public string Status { get; set; }
    }
}
