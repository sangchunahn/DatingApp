using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // this dbcontext represents a session with the database
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        // uses the value model that we have created
        public DbSet<Value> Values { get; set; }
    }
}