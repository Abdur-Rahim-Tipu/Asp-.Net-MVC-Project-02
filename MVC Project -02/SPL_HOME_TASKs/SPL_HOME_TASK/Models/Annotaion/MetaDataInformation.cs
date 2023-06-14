using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPL_HOME_TASK.Models
{
    [MetadataType(typeof(MetaDataInformationMetadata))]
    public partial class  MetaDataInformation
    {
    }
    public partial class MetaDataInformationMetadata
    {
        [Required, Key]
        public long MetaIdentity { get; }
        [Required, StringLength(150, MinimumLength = 3), Index(IsUnique = true)]
        public string MetaName { get; set; }
        [StringLength(250, MinimumLength = 3)]
        public string MetaNameBangla { get; }
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }
        [Required, Index(IsUnique = true), ForeignKey("DocumentInformation")]
        public long DocumentyIdentity { get; set; }
    }
}