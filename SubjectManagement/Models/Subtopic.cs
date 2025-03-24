using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubManagement.Models
{
    public class SubTopic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SubtopicName { get; set; }

        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}