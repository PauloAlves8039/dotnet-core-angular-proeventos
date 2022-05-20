using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProEventos.Api.helpers
{
    public interface IUtil
    {
        Task<string> SaveImage(IFormFile imageFile, string destino);
        void DeleteImage(string imageName, string detino);
    }
}