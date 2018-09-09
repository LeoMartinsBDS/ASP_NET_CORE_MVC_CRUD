using Microsoft.EntityFrameworkCore;

namespace BookList.Models{
    public class ApplicationDBContext : DbContext{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}

        public DbSet<Book> Books {get;set;}
    }
}