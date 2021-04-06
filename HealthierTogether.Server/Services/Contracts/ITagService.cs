using HealthierTogether.Server.Data.Models;
using System.Threading.Tasks;

namespace HealthierTogether.Server.Services.Contracts
{
    public interface ITagService
    {
        Task<Tag> CreateAsync(string t);

        Task<Tag> FindByIdAsync(int id);
    }
}