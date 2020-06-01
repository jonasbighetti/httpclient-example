using HttpClientExample.API.Models;
using System.Threading.Tasks;

namespace HttpClientExample.API.Services.Interface
{
    public interface IPostService
    {
        Task<PostModel> GetPost(int id);
    }
}
