using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPL_HOME_TASK.Models
{
    [MetadataType(typeof(FileInformationMetadata))]
    public partial class FileInformation
    {
    }
    public partial class FileInformationMetadata
    {
        [Required, Key]
        public long FileIdentity { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string FileNo { get; set; }
        [Required, StringLength(250, MinimumLength = 3), Index(IsUnique = true)]
        public string FileName { get; set; }
        [StringLength(450, MinimumLength = 3)]
        public string FileNameBangla { get; }
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }
        [StringLength(250, MinimumLength = 3)]
        public string FilePath { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string FileStatus { get; set; }
        [Required, Index(IsUnique = true), ForeignKey("DocumentInformation")]
        public long DocumentyIdentity { get; set; }
    }
}