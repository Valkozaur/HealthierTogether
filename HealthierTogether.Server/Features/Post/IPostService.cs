using HealthierTogether.Server.Data.Models;
using HealthierTogether.Server.Models.Post;
using System.Threading.Tasks;

namespace HealthierTogether.Server.Services
{
    public interface IPostService
    {
        Task<Post> CreatePost(string name, string content, string creatorId);
    }
}
