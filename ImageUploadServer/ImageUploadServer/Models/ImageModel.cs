using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploading.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Upload Name")]
        public string? ImageName { get; set; }

        [NotMapped]  
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Upload File")]
        public IFormFile? ImageFile { get; set; }

    }
}
