using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SchoolRegister.ViewModels.DTOs
{
    public class AddOrUpdateSubjectDto
    {
        public int? Id { get; set; }
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Required]
        [JsonProperty("description")]
        public string Description { get; set; }

        [Required]
        [JsonProperty("teacherId")]
        public int TeacherId { get; set; }
    }
}
