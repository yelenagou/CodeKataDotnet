using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace List.Core
{
    public class StorageInfo
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string ContainerName { get; set; }
        [Required, StringLength(80)]
        public string BlobName { get; set; }
        public FileType FileType { get; set; }
    }
}
