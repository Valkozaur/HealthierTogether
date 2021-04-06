using HealthierTogether.Server.Data;
using HealthierTogether.Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace HealthierTogether.Server.Services
{
    public class PostService : IPostService
    {
        private readonly HealthierTogetherDbContext dbContext;

        public PostService(HealthierTogetherDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Post> CreatePost(string name, string content, string creatorId)
        {
            if(await isStringNameAsync(name) == false)
            {
                throw new ArgumentException("Name is not unique");
            }

            var post = new Post()
            {
                Name = name,
                Content = content,
                CreatorId = creatorId,
            };

            this.dbContext.Posts.Add(post);
            this.dbContext.SaveChanges();

            return post;
        }

        private Task<bool> isStringNameAsync(string name) 
            => this.dbContext.Posts.AnyAsync(x => x.Name == name);
    }
}
