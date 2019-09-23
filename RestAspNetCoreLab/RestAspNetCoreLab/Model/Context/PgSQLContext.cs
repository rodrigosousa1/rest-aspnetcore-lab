using Microsoft.EntityFrameworkCore;

namespace RestAspNetCoreLab.Model.Context
{
    public class PgSQLContext : DbContext
    {
        public PgSQLContext()
        {

        }

        public PgSQLContext(DbContextOptions<PgSQLContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
