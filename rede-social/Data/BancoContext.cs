using Microsoft.EntityFrameworkCore;
using rede_social.Models;

namespace rede_social.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
