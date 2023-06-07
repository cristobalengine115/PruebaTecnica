using Microsoft.EntityFrameworkCore;



public class User
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    // Agrega más propiedades según las necesidades de tu entidad Usuario
}
public class AppDbContext : DbContext
{
    public DbSet<User> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("LogginDB"); // Reemplaza "TuCadenaDeConexion" con tu cadena de conexión real.
    }
}

