using Microsoft.EntityFrameworkCore;

namespace Agencia.Controllers.NovaPasta
{
    public class usuarioDBContex : DbContext
    {
        public usuarioDBContext(DbContextOptions<usuarioDBContex>options)
            :base(options)

            public DbSet<usuarioModel> usuarios { get; set; }
    }
}
