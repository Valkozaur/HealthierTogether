﻿using HealthierTogether.Server.Data;

namespace HealthierTogether.Server.Models.Post
{
    using HealthierTogether.Server.Mapper;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Validation.Post;

    public class CreatePostModel : IMapTo<Data.Models.Post>
    {
        [Required]
        [MaxLength(MaxPostNameLength)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        public string CreatorId { get; set; }

        public IEnumerable<int> TagIds { get; set; }
    }
}