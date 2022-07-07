using System.ComponentModel.DataAnnotations;

namespace ErfanLearn.DataLayer.Entities
{
    public class FileManager
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] FileData { get; set; }
        [Required]
        public string FileExtension { get; set; }
        [Required]
        public string FileContent { get; set; }

    }
}
