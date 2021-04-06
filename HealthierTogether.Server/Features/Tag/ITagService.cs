namespace HealthierTogether.Server.Features.Tag
{
    using System.Threading.Tasks;

    using HealthierTogether.Server.Data.Models;

    public interface ITagService
    {
        Task<Tag> CreateAsync(string t);

        Task<Tag> FindByIdAsync(int id);
    }
}