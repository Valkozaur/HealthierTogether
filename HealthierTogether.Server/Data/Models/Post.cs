using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthierTogether.Server.Data.Models
{
    public class Post
    {
        public Post()
        {
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        public string CreatorId { get; set; }
        
        public virtual  User Creator { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
