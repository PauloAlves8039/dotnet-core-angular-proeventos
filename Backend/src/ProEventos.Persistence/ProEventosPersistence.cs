using System.Threading.Tasks;
using ProEventos.Domain.Models;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class ProEventosPersistence : IProEventosPersistence
    {
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
        
        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }
    }
}