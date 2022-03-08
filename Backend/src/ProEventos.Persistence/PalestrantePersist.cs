using System.Threading.Tasks;
using ProEventos.Domain.Models;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class PalestrantePersist : IPalestrantePersist
    {
        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }
    }
}