using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPL_HOME_TASK.Models
{
    [MetadataType(typeof(DocumentInformationMetadata))]
    public partial class DocumentInformation
    {
    }
    public partial class DocumentInformationMetadata
    {
        [Required, Key]
        public long DocumentyIdentity { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        public string DocumentReferenceName { get; set; }
        [Required, Column(TypeName = "date"),DataType(DataType.Date)]
        public DateTime DocumentDate { get; set; }
        [Required, StringLength(250, MinimumLength = 3), Index(IsUnique = true)]
        public string DocumentName { get; set; }
        [StringLength(500, MinimumLength = 3)]
        public string DocumentNameBangla { get; set; }
        [StringLength(1500, MinimumLength = 3)]
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required, Index(IsUnique = true), ForeignKey("DocumentCategoryInfo")]
        public int CategoryId { get; set; }

    }
}