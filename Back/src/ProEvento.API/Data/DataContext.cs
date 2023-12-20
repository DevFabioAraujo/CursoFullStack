using Microsoft.EntityFrameworkCore;
using ProEvento.API.Models;

namespace ProEventos.API.Data
{

    public class DataContext: DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

    }
}