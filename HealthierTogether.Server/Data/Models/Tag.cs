<<<<<<< HEAD
﻿namespace HealthierTogether.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Validation.Tag;

    public class Tag
    {
        public Tag()
=======
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthierTogether.Server.Data.Models
{
    public class Category
    {
        public Category()
>>>>>>> remotes/origin/master
        {
            this.Posts = new HashSet<Post>();
        }

        public int Id { get; set; }

        [Required]
<<<<<<< HEAD
        [MaxLength(MaxTagNameLength)]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
=======
        [MaxLength(40)]
        public string Name { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
>>>>>>> remotes/origin/master
    }
}