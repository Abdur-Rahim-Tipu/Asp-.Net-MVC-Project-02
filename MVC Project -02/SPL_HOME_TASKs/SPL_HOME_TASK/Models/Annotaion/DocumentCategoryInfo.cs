using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPL_HOME_TASK.Models
{
    [MetadataType(typeof(DocumentMetadata))]
    public partial class DocumentCategoryInfo
    {
    }
    public partial class DocumentMetadata: IValidatableObject
    {
        [Required, Key]
        public int CategoryId { get; set; }
        [Required, StringLength(150, MinimumLength =3),Index("Ix_CategoryName", IsUnique = true),]
        public string CategoryName { get; set; }
        [StringLength(250, MinimumLength = 3)]
        public string CategoryNameBangla { get; set; }
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            SPL_HOME_TASKEntities db = new SPL_HOME_TASKEntities();
            List<ValidationResult> validationResult = new List<ValidationResult>();
            var validateName = db.DocumentCategoryInfoes.FirstOrDefault(x => x.CategoryName == CategoryName);
            if (validateName != null)
            {
                ValidationResult errorMessage = new ValidationResult
                ("Product name already exists.", new[] { "ProductName" });
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }
    }
}