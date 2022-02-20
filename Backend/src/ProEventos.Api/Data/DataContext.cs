using Microsoft.EntityFrameworkCore;
using ProEventos.Api.Models;

namespace ProEventos.Api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        
    }
}