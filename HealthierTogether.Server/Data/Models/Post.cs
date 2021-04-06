
namespace HealthierTogether.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Validation.Post;

    public class Post
    {
        public Post()
        {
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(MaxPostNameLength)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        public string CreatorId { get; set; }
        
        public virtual  User Creator { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
