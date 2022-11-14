using Agencia.Models.;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Controllers.usuario
{
    public class SistemaTarefasDBContex : DbContext

    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
            : base(options)
        {
        }
        public DbSet<DestinoModel> destinos { get; set; }
        public DbSet<DestinoModel> Destino { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
    }
}
