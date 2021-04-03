using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthierTogether.Server.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}