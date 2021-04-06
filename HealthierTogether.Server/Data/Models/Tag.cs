namespace HealthierTogether.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Validation.Tag;

    public class Tag
    {
        public Tag()
        {
            this.Posts = new HashSet<Post>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTagNameLength)]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}