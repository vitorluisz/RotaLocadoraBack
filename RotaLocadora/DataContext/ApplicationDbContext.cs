using System.Collections.Generic;
using RotaLocadora.Model;
using Microsoft.EntityFrameworkCore;


namespace RotaLocadora.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CarsModel> Cars { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<HistoryActivitiesModel> Historico { get; set; }

    }
}