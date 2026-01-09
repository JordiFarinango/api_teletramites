using NuevaAPIteletramite.Models; //carpeta Models que contiene nuestros modelos de tablas
using Microsoft.EntityFrameworkCore; //necesario para usar DbContext, DbSet<>, etc.

namespace NuevaAPIteletramite.Data

{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
        public DbSet<UsuarioExterno> UsuariosExternos { get; set; }
        public DbSet<UsuarioInterno> UsuariosInternos { get; set; }

        //Esos son los nombres que quedaran para las tablas "UsuariosExternos" y "UsuariosInternos"


    }
}
