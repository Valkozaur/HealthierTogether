using HealthierTogether.Server.Data;
using HealthierTogether.Server.Data.Models;
using HealthierTogether.Server.Models.Post;
using HealthierTogether.Server.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HealthierTogether.Server.Services
{
    public class PostService
    {
        private readonly HealthierTogetherDbContext dbContext;

        public PostService(HealthierTogetherDbContext dbContext, ITagService tagService)
        {
            this.dbContext = dbContext;
            this.tagService = tagService
        }

        public async Task<int> CreatePost(CreatePostModel model)
        {
            if(await isStringNameAsync(model.Name) == false)
            {
                throw new ArgumentException("Name is not unique");
            }

            var post = new Post()
            {
                Name = model.Name,
                Content = model.Content,
                CreatorId = model.CreatorId,
            };

            model.TagIds.Select(x => )
        }

        private Task<bool> isStringNameAsync(string name) 
            => this.dbContext.Post.AnyAsync(x => x.Name == name);
    }
}
